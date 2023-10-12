using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using SMTLSoftwareTools.SensorConfig;
using BarCodeReader;

namespace SMTLSoftwareTools.SerialNumber
{
    public partial class RecordSerialNumber : Form
    {
        HttpClientClass httpClient;
        string IP { get; set; }
        string PortName { get; set; }
        private readonly string DevCode = "56";

        public RecordSerialNumber(HttpClientClass client)
        {
            httpClient = client;
            DevCode = "56";
            IP = client.Ip;
            InitializeComponent();
            LoadPortsName();
        }
        private async Task EnterSerialNumber()
        {
            string Command, Username = "smtl", Password = "perseus";

            using (SshClient Client = new SshClient(IP, Username, Password))
            {
                try
                {
                    Command = "sudo /usr/local/sbin/serial_number_update " + textBoxSerNum.Text;
                    Client.Connect();

                    IDictionary<Renci.SshNet.Common.TerminalModes, uint> modes =
                    new Dictionary<Renci.SshNet.Common.TerminalModes, uint>();
                    modes.Add(Renci.SshNet.Common.TerminalModes.ECHO, 53);

                    ShellStream shellStream =
                    Client.CreateShellStream("xterm", 80, 24, 800, 600, 1024, modes);
                    string output = shellStream.Expect(new Regex(@"[$>]"));

                    shellStream.WriteLine(Command);
                    output = shellStream.Expect(new Regex(@"([$#>:])"));
                    shellStream.WriteLine(Password);
                    Thread.Sleep(1000);
                    output = shellStream.Expect(new Regex(@"([$#>:])"));                   
                    MessageBox.Show(output.Substring(output.IndexOf('\n'), output.LastIndexOf('\n') - output.IndexOf('\n')), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await waitRestartGateway();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка записи серийного номера!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task waitRestartGateway()
        {
            Form form = new Form();
            form.Text = "Окно ожидания";
            Label label = new Label();
            label.Text = "Подождите, выполняется перезагрузка шлюза...";
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(10, 10);
            form.Controls.Add(label);

            // Показываем форму в отдельном потоке
            Thread thread = new Thread(() => Application.Run(form));
            thread.Start();

            await restartGateway();

            // Закрываем форму
            form.Invoke(new Action(() => form.Close()));
        }
        private async Task restartGateway()
        {
            await httpClient.restartingCommunicationGateway();
            await Task.Delay(10000);
        }

        private async void btWriteManual_Click(object sender, EventArgs e)
        {
            if (checkSerialNumber())
                await EnterSerialNumber();
        }

        private bool checkSerialNumber()
        {
            bool result = false;

            if (textBoxSerNum.TextLength == 0)
            {
                MessageBox.Show("Пустое значение серийного номера!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxSerNum.TextLength != 13)
            {
                MessageBox.Show("Не верный формат серийного номера!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxSerNum.Text.Substring(3, 2) != DevCode)
            {
                MessageBox.Show("Серийный номер не соответсвует типу прибора!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                result = true;

            return result;
        }


        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadPortsName()
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length > 0)
            {
                foreach (string port in ports)
                {
                    lstPorts.Items.Add(port);
                }

                lstPorts.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("В системе отсутствует COM порт. Сканер не доступен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btScan.Enabled = false;
            }
        }

        private void btPortSelect_Click(object sender, EventArgs e)
        {
            PortName = lstPorts.SelectedItem as string;
            btScan.Enabled = true;
        }

        private async void btScan_Click(object sender, EventArgs e)
        {
            
            SerialPort port = new SerialPort(PortName, 9600, Parity.None, 8, StopBits.One);
            if (port.IsOpen == true)
                port.Close();
            port.Open();
            BarCodeReaderClass reader = new BarCodeReaderClass(port);
            await reader.StartReadAsync();
            port.Close();
            textBoxSerNum.Text = reader.BarCode;
            if (checkSerialNumber())
                await EnterSerialNumber();
        }
    }
}
