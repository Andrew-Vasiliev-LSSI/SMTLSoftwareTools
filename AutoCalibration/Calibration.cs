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
        CalibrationAnalogOutputs calibrationAnalogOutputs;
        public Calibration(HttpClientClass client)
        {
            InitializeComponent();
            HttpClientCalibration = client;
            LoadListboxes();
            fillView(dataGridViewResultVoltage);
            fillView(dataGridViewResultCurrent);
        }

        private void fillView(DataGridView view)
        {
            for (int i = 0; i < 4; i++)
            {
                view.Rows.Add();
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
                currentInputCalibration = new CurrentInputCalibration(HttpClientCalibration, Calibrator);
                currentInputCalibration.LabelInfo = this.lbInfoCurrent;
                calibrationAnalogOutputs = new CalibrationAnalogOutputs(HttpClientCalibration, Calibrator);

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
            await voltageCalibration();
        }

        private async Task voltageCalibration()
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

                errorCheck(errors, dataGridViewResultVoltage, 2, 20);
                btStartCurrentInput.Enabled = true;
                btRepeatVoltage.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void errorCheck(double[] errors, DataGridView view, int column, double threshold)
        {
            for (int i = 0; i < errors.Length; i++)
            {
                DataGridViewCell cell = view.Rows[i].Cells[column];
                if (errors[i] > threshold)
                {
                    cell.Style.BackColor = Color.Red;
                }
                else
                {
                    cell.Style.BackColor = Color.Green;

                }
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
            await currentCalibration();
        }

        private async Task currentCalibration()
        {
            try
            {
                Calibrator.SetOperMode();
                await currentInputCalibration.prepareCalibration();
                double[] compensations = await currentInputCalibration.calculateCompensations();
                await currentInputCalibration.settingCompenstaions();
                double[] errors = await currentInputCalibration.errorCalculation();

                showResults(dataGridViewResultCurrent, 0, compensations);
                showResults(dataGridViewResultCurrent, 1, errors);

                errorCheck(errors, dataGridViewResultCurrent, 1, 80);
                btRepeatCurrent.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btStartCurrentOutput_Click(object sender, EventArgs e)
        {
            try
            {
                await calibrationAnalogOutputs.prepareCalibration(1);
                await calibrationAnalogOutputs.calibrations(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btVoltageRepeat_Click(object sender, EventArgs e)
        {
            dataGridViewResultVoltage.Rows.Clear();
            fillView(dataGridViewResultVoltage);
            await voltageCalibration();
        }

        private async void btRepeatCurrent_Click(object sender, EventArgs e)
        {
            dataGridViewResultCurrent.Rows.Clear();
            fillView(dataGridViewResultCurrent);
            await currentCalibration();
        }
    }
}

