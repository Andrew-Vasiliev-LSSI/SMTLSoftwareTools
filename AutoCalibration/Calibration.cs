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
using SMTLSoftwareTools.Http;
using SMTLSoftwareTools.SensorConfig;
using SMTLSoftwareTools.AutoCalibration;
using System.Data.Common;
using System.Linq.Expressions;
using System.IO;
using SMTLSoftwareTools.ReportGeneration;
using SMTLSoftwareTools.SerialNumber;
using System.Threading;

namespace SMTLSoftwareTools.AutoCalibration
{
    public partial class Calibration : Form
    {
        public const int numberChannels = 4;
        private static HttpClientClass HttpClientCalibration;
        private static FlukeConnect Calibrator = new FlukeConnect();
        private VoltageInputCalibration voltageInputCalibration;
        private CurrentInputCalibration currentInputCalibration;
        private CalibrationAnalogOutputs calibrationAnalogOutputs;
        private string SerialNumber;
        private string Executor;
        private string PathReport;
        private enum Regim
        {
            Voltage,
            Current
        }
 
        DataGridView[] viewArray = new DataGridView[4];
        private SummaryCalibrationResults summaryCalibrationResults = new SummaryCalibrationResults();

        public Calibration(HttpClientClass client, string serial)
        {
            InitializeComponent();
            HttpClientCalibration = client;
            SerialNumber = serial;
            textBoxSerNum.Text = SerialNumber;
            Executor = "";
            textBoxExecutor.Text = Executor;
            LoadListboxes();
            LoadChoice();
            dataGridViewResultVoltage.RowCount = numberChannels;
            dataGridViewResultCurrent.RowCount = numberChannels;

            viewArray[0] = dataGridViewResultOutput1;
            viewArray[1] = dataGridViewResultOutput2;
            viewArray[2] = dataGridViewResultOutput3;
            viewArray[3] = dataGridViewResultOutput4;

            disableControlsPage(2);
            disableControlsPage(3);
            disableControlsPage(4);

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

                //2) Baudrates:
                string[] baudrates = { "230400", "115200", "57600", "38400", "19200", "9600" };

                foreach (string baudrate in baudrates)
                {
                    lstBaudrate.Items.Add(baudrate);
                }

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
                if (cbEnableCheckErrors.Checked == true)
                {
                    enableControlsPage(2);
                    enableControlsPage(3);
                    enableControlsPage(4);

                }
                else
                {
                    enableControlsPage(2);
                    enableControlsPage(4);
                }

                string path = Path.Combine(Environment.CurrentDirectory, "Communicator");
                string fileName = path + @"\config\1_Basic_conf_test.db";
                byte[] fileBytes = File.ReadAllBytes(fileName);
                HttpClientCalibration.UploadFile(fileBytes);

                lbInfo.Text = info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void btClose_Click(object sender, EventArgs e)
        {
            if (false)
            {
               DialogResult result = MessageBox.Show("Обнулить серийный номер?", "Неудачная калибровка", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    await ResetSerialNumber();
                    await WaitFinal(5000);
                }
                else
                {
                    MessageBox.Show("Серийный номер не обнулён");
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Сформировать отчет?", "Удачная калибровка", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Form form = new Form();
                    form.Text = "Окно ожидания";
                    Label label = new Label();
                    label.Text = "Форирование отчета...";
                    label.AutoSize = true;
                    label.Location = new System.Drawing.Point(10, 10);
                    form.Controls.Add(label);
                    // Показываем форму в отдельном потоке
                    Thread thread = new Thread(() => Application.Run(form));
                    thread.Start();

                    ReportGeneration();

                    // Закрываем форму
                    form.Invoke(new Action(() => form.Close()));
                }
                else
                {
                    MessageBox.Show("Отчет не сформирован");
                }
            }
            this.Close();
        }

        private async Task WaitFinal(int delay)
        {
            Form form = new Form();
            form.Text = "Окно ожидания";
            Label label = new Label();
            label.Text = "Ожидание окончания...";
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(10, 10);
            form.Controls.Add(label);

            // Показываем форму в отдельном потоке
            Thread thread = new Thread(() => Application.Run(form));
            thread.Start();
            await Task.Delay(delay);
            // Закрываем форму
            form.Invoke(new Action(() => form.Close()));
        }

        private async void btStartVoltageInput_Click(object sender, EventArgs e)
        {
            await voltageCalibration();
        }

        private async Task voltageCalibration()
        {
            try
            {
                await voltageInputCalibration.prepareCalibration();

                int[] coefficients = await voltageInputCalibration.calculateCoefficients();
                double[] offsets = voltageInputCalibration.calculateOffsets();
                await voltageInputCalibration.settingCoefficients();
                double[] errors = await voltageInputCalibration.errorCalculation();

                showResults(dataGridViewResultVoltage, 0, coefficients);
                showResults(dataGridViewResultVoltage, 1, offsets);
                showResults(dataGridViewResultVoltage, 2, errors);

                errorCheck(Regim.Voltage,errors, dataGridViewResultVoltage, 2, 20);
                btRepeatVoltage.Enabled = true;
                enableControlsPage(3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void errorCheck(Regim regim, double[] errors, DataGridView view, int column, double threshold)
        {
            for (int i = 0; i < errors.Length; i++)
            {
                DataGridViewCell cell = view.Rows[i].Cells[column];
                if (errors[i] > threshold)
                {
                    cell.Style.BackColor = Color.Red;

                    if (regim == Regim.Voltage)
                    {
                        summaryCalibrationResults.CalibrationResultsVoltage[i] = false;
                    }
                    else if (regim == Regim.Current)
                    {
                        summaryCalibrationResults.CalibrationResultsCurrent[i] = false;
                    }
                }
                else
                {
                    cell.Style.BackColor = Color.Green;

                    if (regim == Regim.Voltage)
                    {
                        summaryCalibrationResults.CalibrationResultsVoltage[i] = true;
                    }
                    else if (regim == Regim.Current)
                    {
                        summaryCalibrationResults.CalibrationResultsCurrent[i] = true;
                    }

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

                errorCheck(Regim.Current, errors, dataGridViewResultCurrent, 1, 80);
                btRepeatCurrent.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btStartCurrentOutput_Click(object sender, EventArgs e)
        {
            await currentOutputCalibration();
        }

        private async Task currentOutputCalibration()
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
                                summaryCalibrationResults.CalibrationResultsAnalog[ch - 1] = true;
                                repeat = false;
                            }
                            else
                            {
                                viewArray[ch - 1].Rows[4].Cells[1].Style.BackColor = Color.Red;
                                summaryCalibrationResults.CalibrationResultsAnalog[ch - 1] = false;
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
                } while (ch <= numberChannels);

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


        private async void btCheckVoltage_Click(object sender, EventArgs e)
        {
            try
            {
                double[] errors = await voltageInputCalibration.errorCalculation();
                showResults(dataGridViewResultVoltage, 2, errors);
                errorCheck(Regim.Voltage, errors, dataGridViewResultVoltage, 2, 20);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void btCheckCurrent_Click(object sender, EventArgs e)
        {
            try
            {
                double[] errors = await currentInputCalibration.errorCalculation();

                showResults(dataGridViewResultCurrent, 1, errors);

                errorCheck(Regim.Current, errors, dataGridViewResultCurrent, 1, 80);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btCheckAnalog_Click(object sender, EventArgs e)
        {
            try
            {
                int ch = 1;
                do
                {
                    DialogResult result = MessageBox.Show("Подключи аналоговый выход " + ch.ToString() + " к входу калибратора", "Переключение входов", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        double error = await calibrationAnalogOutputs.errorCalculation(ch, false);

                        viewArray[ch - 1].Rows.Add("Погрешность мкА", error);
                        if (error <= 20.0)
                        {
                            viewArray[ch - 1].Rows[0].Cells[1].Style.BackColor = Color.Green;
                            summaryCalibrationResults.CalibrationResultsAnalog[ch - 1] = true;
                        }
                        else
                        {
                            viewArray[ch - 1].Rows[0].Cells[1].Style.BackColor = Color.Red;
                            summaryCalibrationResults.CalibrationResultsAnalog[ch - 1] = false;
                        }
                        ch++;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                } while (ch <= numberChannels);

                lbInfoOutput.Text = "Проверка пргрешности всех аналоговых выходов завершена";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        // Сохранение и чтение параметров порта
        private void LoadChoice()
        {
            string choiсePort, choiceBaudrate;
            ManageParameters Loader = new ManageParameters();
            choiсePort = Loader.LoadParameter("lstPortsChoiсe");
            lstPorts.SelectedItem = choiсePort;
            choiceBaudrate = Loader.LoadParameter("lstBaudrateChoice");
            lstBaudrate.SelectedItem = choiceBaudrate;
            Executor = Loader.LoadParameter("Executor");
            textBoxExecutor.Text = Executor;
            PathReport = Loader.LoadParameter("PathReport");
            textBoxPathReport.Text = PathReport;
        }
        private void SaveChoicePort()
        {
            //ManageParameters Saver = new ManageParameters();
            //Saver.SaveParameter("lstPortsChoice", lstPorts.SelectedItem.ToString());
            Properties.Settings.Default.lstPortsChoiсe = lstPorts.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }
        private void SaveChoiceBaudrate()
        {
            //ManageParameters Saver = new ManageParameters();
            //Saver.SaveParameter("lstBaudrateChoice", lstBaudrate.SelectedItem.ToString());
            Properties.Settings.Default.lstBaudrateChoice = lstBaudrate.SelectedItem.ToString();
            Properties.Settings.Default.Save();

        }

        private void SaveExeutor()
        {
            //ManageParameters Saver = new ManageParameters();
            //Saver.SaveParameter("Executor", Executor);
            Properties.Settings.Default.Executor = Executor;
            Properties.Settings.Default.Save();
        }
        private void lstPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveChoicePort();
        }
        private void lstBaudrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveChoiceBaudrate();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Executor = textBoxExecutor.Text;
            SaveExeutor();
            MessageBox.Show("Записано");
        }

       private string FolderBrowserDialog(string initialDirectory)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Выберите папку для сохранения отчетов о калибровке",
                SelectedPath = initialDirectory
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                return folderBrowserDialog.SelectedPath;
            }

            return null;
        }

        private void btPathReport_Click(object sender, EventArgs e)
        {
            PathReport = FolderBrowserDialog(@"C:\");
            if (PathReport != null)
            {
                textBoxPathReport.Text = PathReport;
                Properties.Settings.Default.PathReport = PathReport;
                Properties.Settings.Default.Save();
            }
        }

        private void ReportGeneration()
        {
            CreatingReport report = new CreatingReport();
            report.SerialNumber = SerialNumber;
            report.PathReport = PathReport;
            report.Executor = Executor;
            report.DataGridViews = new DataGridView[] {dataGridViewResultVoltage, dataGridViewResultCurrent, dataGridViewResultOutput1,
                                                       dataGridViewResultOutput2, dataGridViewResultOutput3, dataGridViewResultOutput4};
            report.Create();

        }
        private async Task ResetSerialNumber()
        {
            Form form = new Form();
            form.Text = "Окно ожидания";
            Label label = new Label();
            label.Text = "Обнуление серийного номера...";
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(10, 10);
            form.Controls.Add(label);

            // Показываем форму в отдельном потоке
            Thread thread = new Thread(() => Application.Run(form));
            thread.Start();
            // Обнуляем серийный номер
            RecordSerialNumber record = new RecordSerialNumber(HttpClientCalibration);
            await record.EnterSerialNumber("0000000000000");
            // Закрываем форму
            form.Invoke(new Action(() => form.Close()));
        }
    }
}

//  0025681104212
