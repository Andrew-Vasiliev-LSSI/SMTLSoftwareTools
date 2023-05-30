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
using System.Data.Common;
using System.Linq.Expressions;

namespace SMTLSoftwareTools.AutoCalibration
{
    public partial class Calibration : Form
    {
        private static HttpClientClass HttpClientCalibration;
        private static FlukeConnect Calibrator;
        VoltageInputCalibration voltageInputCalibration;
        CurrentInputCalibration currentInputCalibration;
        public Calibration(HttpClientClass client)
        {
            InitializeComponent();
            HttpClientCalibration = client;
            LoadListboxes();
            for (int i = 0; i < 4; i++)
            {
                dataGridViewResultVoltage.Rows.Add();
                dataGridViewResultCurrent.Rows.Add();
            }
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
                string port = lstPorts.SelectedItem as string;
                int speed = Int32.Parse(lstBaudrate.SelectedItem as string);
                Calibrator.BaudRate = speed;
                Calibrator.Initialize(port);
                string info = Calibrator.GetInfoDevice();
                voltageInputCalibration = new VoltageInputCalibration(HttpClientCalibration, Calibrator);
                voltageInputCalibration.LabelInfo = this.lbInfoVoltage;
                //currentInputCalibration = new CurrentInputCalibration(HttpClientCalibration, Calibrator);

                lbInfo.Text = info;
            }
            catch (Exception ex)
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
            try
            {
                Calibrator.SetOperMode();
                await voltageInputCalibration.prepareCalibration();

                int[] coefficients = await voltageInputCalibration.calculateCoefficients();
                double[] offsets = voltageInputCalibration.calculateOffsets();
                await voltageInputCalibration.settingCoefficients();
                double[] errors = await voltageInputCalibration.errorCalculation();             

                showResults(dataGridViewResultVoltage, 0, coefficients);
                showResults(dataGridViewResultVoltage, 1, offsets);
                showResults(dataGridViewResultVoltage, 2, errors);

                for (int i = 0; i < errors.Length; i++)
                {
                    DataGridViewCell cell = this.dataGridViewResultVoltage.Rows[i].Cells[2];
                    if (errors[i] > 20)
                    {
                        cell.Style.BackColor = Color.Red;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.Green;

                    }
                }
                btStartCurrentInput.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showResults(DataGridView view, int column, int[] result)
        {
            for (int i = 0; i < result.Length; i++)
                view.Rows[i].Cells[column].Value = result[i].ToString();
        }

        private void showResults(DataGridView view, int column, double[] result)
        {
            for (int i = 0; i < result.Length; i++)
                view.Rows[i].Cells[column].Value = result[i].ToString();
        }

        private async void btStartCurrentInput_Click(object sender, EventArgs e)
        {
            try
            {
                await currentInputCalibration.prepareCalibration();
                double[] compensations = await currentInputCalibration.calculateCompensations();
                double[] errors = await currentInputCalibration.errorCalculation();

                showResults(dataGridViewResultCurrent, 0, compensations);
                showResults(dataGridViewResultCurrent, 1, errors);

                for (int i = 0; i < errors.Length; i++)
                {
                    DataGridViewCell cell = this.dataGridViewResultCurrent.Rows[i].Cells[1];
                    if (errors[i] > 80)
                    {
                        cell.Style.BackColor = Color.Red;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.Green;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btStartCurrentOutput_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

