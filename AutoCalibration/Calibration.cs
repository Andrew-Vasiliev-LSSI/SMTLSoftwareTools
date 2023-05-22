using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Aean.MidasTools.Services;
using SMTLSoftwareTools.SensorConfig;
using SMTLSoftwareTools.AutoCalibration;

namespace SMTLSoftwareTools.AutoCalibration
{
    public partial class Calibration : Form
    {
        private static HttpClientClass ClientCalibration;
        private static FlukeConnect Calibrator;
        VoltageInputCalibration voltageInputCalibration;
        public Calibration(HttpClientClass client)
        {
            InitializeComponent();
            ClientCalibration = client;
            LoadListboxes();
        }

        private void LoadListboxes()
        {
            //Three to load - ports, baudrates, datetype.  Also set default textbox values:
            //1) Available Ports:
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length > 0)
            {
                foreach (string port in ports)
                {
                    lstPorts.Items.Add(port);
                }

                lstPorts.SelectedIndex = 0;

                //2) Baudrates:
                string[] baudrates = { "230400", "115200", "57600", "38400", "19200", "9600" };

                foreach (string baudrate in baudrates)
                {
                    lstBaudrate.Items.Add(baudrate);
                }

                lstBaudrate.SelectedIndex = 5;
            }
            else
            {
                MessageBox.Show("В системе отсутствует COM порт. Программа будет закрыта.", "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Calibrator = new FlukeConnect();
                voltageInputCalibration = new VoltageInputCalibration(ClientCalibration, Calibrator);
                string port = lstPorts.SelectedItem as string;
                int speed = Int32.Parse(lstBaudrate.SelectedItem as string);
                Calibrator.BaudRate = speed;
                Calibrator.Initialize(port);
                string info = Calibrator.GetInfoDevice();
                lbInfo.Text = info;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private async void btStartVoltageInput_Click(object sender, EventArgs e)
        {
            // !!!!!!!!!!!!!!Не забыть убрать!!!!!!!!!!!!!!!!!
            Calibrator = new FlukeConnect();
            voltageInputCalibration = new VoltageInputCalibration(ClientCalibration, Calibrator);


            await voltageInputCalibration.prepareCalibration();
        }
    }
}

