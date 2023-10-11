﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;

namespace SMTLSoftwareTools.SerialNumber
{
    public partial class RecordSerialNumber : Form
    {
        string IP { get; set; }
        private readonly string DevCode = "56";

        public RecordSerialNumber(string Ip)
        {
            DevCode = "56";
            IP = Ip;
            InitializeComponent();
        }
        private void EnterSerialNumber()
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

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка записи серийного номера!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private  void btWriteManual_Click(object sender, EventArgs e)
        {
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
                EnterSerialNumber();
        }
    }
}