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
        public const int numberChannels = 4;
        private static HttpClientClass HttpClientCalibration;
        private static FlukeConnect Calibrator = new FlukeConnect();
        VoltageInputCalibration voltageInputCalibration;
        CurrentInputCalibration currentInputCalibration;
        CalibrationAnalogOutputs calibrationAnalogOutputs;
        
        DataGridView[] viewArray = new DataGridView[4];
        public Calibration(HttpClientClass client)
        {
            InitializeComponent();
            HttpClientCalibration = client;
            LoadListboxes();
            dataGridViewResultVoltage.RowCount = numberChannels;
            dataGridViewResultCurrent.RowCount = numberChannels;

            viewArray[0] = dataGridViewResultOutput1;
            viewArray[1] = dataGridViewResultOutput2;
            viewArray[2] = dataGridViewResultOutput3;
            viewArray[3] = dataGridViewResultOutput4;
 
            disableControlsPage(1);
            disableControlsPage(2);
            disableControlsPage(3);
 
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

        private void disableControlsPage(int indexPage)
        {
            foreach (Control control in tabControlCalibr.TabPages[indexPage].Controls)
            {
                control.Enabled = false;
            }
        }

        private void enableControlsPage(int indexPage)
        {
            foreach (Control control in tabControlCalibr.TabPages[indexPage].Controls)
            {
                control.Enabled = true;
            }
        }


        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string port = lstPorts.SelectedItem as string;
                int speed = Int32.Parse(lstBaudrate.SelectedItem as string);
                Calibrator.ClosePort();
                Calibrator.BaudRate = speed;
                Calibrator.Initialize(port);
                string info = Calibrator.GetInfoDevice();
                voltageInputCalibration = new VoltageInputCalibration(HttpClientCalibration, Calibrator);
                voltageInputCalibration.LabelInfo = this.lbInfoVoltage;
                currentInputCalibration = new CurrentInputCalibration(HttpClientCalibration, Calibrator);
                currentInputCalibration.LabelInfo = this.lbInfoCurrent;
                calibrationAnalogOutputs = new CalibrationAnalogOutputs(HttpClientCalibration, Calibrator);
                calibrationAnalogOutputs.LabelInfo = this.lbInfoOutput;
                calibrationAnalogOutputs.ViewArray = this.viewArray;
                enableControlsPage(1);
                enableControlsPage(3);

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
                int ch = 1;
                bool repeat = false;
                await calibrationAnalogOutputs.prepareCalibration();

                do
                {
                    DialogResult result = MessageBox.Show("Подключи аналоговый выход " + ch.ToString() + " к входу калибратора", "Переключение входов", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        bool test = calibrationAnalogOutputs.switchingTest();
                        if (test == true)
                        {
                            double error = await calibrationAnalogOutputs.calibrations(ch);
                            viewArray[ch - 1].Rows.Add("Погрешность мкА", error);
                            if (error <= 20.0)
                            {
                                viewArray[ch - 1].Rows[4].Cells[1].Style.BackColor = Color.Green;
                                repeat = false;
                            }
                            else
                            {
                                viewArray[ch - 1].Rows[4].Cells[1].Style.BackColor = Color.Red;
                                repeat = true; 
                            }

                            if (repeat)
                            {
                                result = MessageBox.Show("Повторить калибровку выхода " + ch.ToString() + " ?", "Повторная калибровка", MessageBoxButtons.OKCancel);
                                if (result == DialogResult.OK)
                                {
                                   await calibrationAnalogOutputs.zeroCurrentSetting(ch);
                                }
                                else if (result == DialogResult.Cancel)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                ch++;
                            }
 
                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                } while(ch <= numberChannels);

                lbInfoOutput.Text = "Калибровка всех аналоговых выходов завершена";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btVoltageRepeat_Click(object sender, EventArgs e)
        {
            dataGridViewResultVoltage.Rows.Clear();
            dataGridViewResultVoltage.RowCount = 4;
            await voltageCalibration();
        }

        private async void btRepeatCurrent_Click(object sender, EventArgs e)
        {
            dataGridViewResultCurrent.Rows.Clear();
            dataGridViewResultCurrent.RowCount = 4;
            await currentCalibration();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            btRepeatVoltage.Enabled = false;
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            btRepeatCurrent.Enabled = false;
        }
    }
}

