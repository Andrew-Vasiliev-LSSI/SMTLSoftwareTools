using Aean.MidasTools.Services;
using Renci.SshNet.Messages;
using SMTLSoftwareTools.SensorConfig;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace SMTLSoftwareTools.AutoCalibration
{
    internal class CalibrationAnalogOutputs
    {
        public Label LabelInfo { get; set; }
        public DataGridView[] ViewArray { get; set; }

        private static HttpClientClass ClientCalibration;
        private static FlukeConnect Calibrator;

        //private int numberOfChannels = VoltageInputCalibration.numberOfChannels;
        private const int minCode = 11000;
        private const int maxCode = 58000;
        private const int currentTestValue = 15;
        private const int initValue = 0;
        private const int delay = 500;
        private const int numberMeasures = 10;
        public CalibrationAnalogOutputs(HttpClientClass client, FlukeConnect calibrator)
        {
            ClientCalibration = client;
            Calibrator = calibrator;
        }

        public async Task prepareCalibration()
        {
            string request;

          
            try
            {
                Calibrator.ActiveLoopPower(true);
                for (int ch = 1; ch <= 4; ++ch)
                {
                    await zeroCurrentSetting(ch);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public async Task zeroCurrentSetting(int ch)
        {
            string request;

            LabelInfo.Text = "Подготовка к калибровке. Канал " + ch.ToString();
            request = "GGIO1.CalibrationMode&value=true";
            await executeRequest(request);

            request = "GGIO1." + "AnMinOut" + ch.ToString() + ":setMag_f&value=0";
            await executeRequest(request);

            request = "GGIO1." + "AnMaxOut" + ch.ToString() + ":setMag_f&value=0";
            await executeRequest(request);


            request = "GGIO1." + "AnSetOut" + ch + ":" + "Oper_ctlVal_f&value=" + initValue.ToString();
            await executeRequest(request);
        }
        public bool switchingTest(int ch)
        {
            bool check = true;
            double value;
            int mult = 1000;

            value = Calibrator.GetInputValue(mult);
            if (value > 4)
            {
                check = false;
                MessageBox.Show("Аналоговый выход не переключен.");
                check = false;
            }
            return check;
        }

        public async Task<double> calibrations(int ch)
        {
            try
            {
                ViewArray[ch - 1].Rows.Clear();
                //С прибора идут данные в универсальном формате,
                //поэтому для правильной работы нужно использовать американскую локализацию
                CultureInfo cultureInfoOrig = System.Threading.Thread.CurrentThread.CurrentUICulture;
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

                string chNum = ch.ToString();
                string message;
                double minOutput, maxOutput;

                string request = "GGIO1." + "AnSetCode" + chNum + ":" + "Oper_ctlVal&value=" + minCode.ToString();
                await executeRequest(request);
                ViewArray[ch - 1].Rows.Add("Min Code", minCode.ToString());

                message = "Измерение выходного тока при минимальном коде." + " Выход " + chNum.ToString() + " измерение: ";
                minOutput = await measureValue(message);
                request = "GGIO1." + "AnMinOut" + chNum + ":setMag_f&value=" + minOutput.ToString();
                await executeRequest(request);
                ViewArray[ch - 1].Rows.Add("Imin", minOutput.ToString());

                request = "GGIO1." + "AnSetCode" + chNum + ":Oper_ctlVal&value=" + maxCode.ToString();
                await executeRequest(request);
                ViewArray[ch - 1].Rows.Add("Max Code", maxCode.ToString());

                message = "Измерение выходного тока при максимальном коде." + " Выход " + chNum.ToString() + " измерение: ";
                maxOutput = await measureValue(message);
                request = "GGIO1." + "AnMaxOut" + chNum + ":setMag_f&value=" + maxOutput.ToString();
                await executeRequest(request);
                ViewArray[ch - 1].Rows.Add("Imax", maxOutput.ToString());

                double error = await errorCalculation(ch);
                //Возвращаем локализацию, чтобы ничего не сломать
                System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfoOrig;
                return error;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }



        public async Task<double> errorCalculation(int ch)
        {
            double result, value;
            string chNum = ch.ToString();
            string request = "GGIO1." + "AnSetOut" + chNum + ":" + "Oper_ctlVal_f&value=" + currentTestValue.ToString();
            await executeRequest(request);
            string message = "Измерение выходного тока при установленом токе" + currentTestValue.ToString() + " мА." + " Выход " + chNum.ToString() + " измерение: ";
            value = await measureValue(message);
            result = Math.Abs(currentTestValue - value) * 1000;
            LabelInfo.Text = "Калибровка выхода " + chNum.ToString() + " закончена";
            return result;
        }

        private static async Task<string> executeRequest(string request)
        {
            string result = await ClientCalibration.parameterExecutedRequest(request);
            await Task.Delay(delay * 2);
            return result;
        }
        private async Task<double> measureValue(string message )
        {
            double value = 0;
            int mult = 1000;

            for (int i = 0; i < numberMeasures; i++)
            {
                LabelInfo.Text = message + (i + 1).ToString();
                value += Calibrator.GetInputValue(mult);
                await Task.Delay(delay);
            }
            value /= numberMeasures;

            return value;
        }
    }
}

/*
 * http://192.168.0.1/api/attributedata?path=Vibro%2FGGIO1.CalibrationMode&value=true
 * http://192.168.0.1/api/attributedata?path=Vibro%2FGGIO1.AnSetOut1%3AOper_ctlVal_f&value=15
 * http://192.168.0.1/api/attributedata?path=Vibro%2FGGIO1.AnSetCode1%3AOper_ctlVal&value=111111
 * http://192.168.0.1/api/attributedata?path=Vibro%2FGGIO1.AnSetOut1%3AOper_ctlVal_f&value=222222
 * http://192.168.0.1/api/attributedata?path=Vibro%2FGGIO1.AnMinOut1%3AsetMag_f&value=3.9690001010894775
 * http://192.168.0.1/api/attributedata?path=Vibro%2FGGIO1.AnMaxOut1%3AsetMag_f&value=20.3799991607666
 * http://192.168.0.1/api/attributedata?path=Vibro/GGIO1.AnMaxOut1:setMag_f
 *  Измерение выходного тока при установленом токе 15мА. Канал 1 измерение: 10
 */