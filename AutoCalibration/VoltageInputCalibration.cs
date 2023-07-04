using Aean.MidasTools.Services;
using SMTLSoftwareTools.SensorConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Timers;
using System.Runtime.Serialization.Formatters;
using System.Globalization;

namespace SMTLSoftwareTools.AutoCalibration
{
    internal class VoltageInputCalibration
    {
        public Label LabelInfo { get; set; }

        public static HttpClientClass ClientCalibration;
        public static FlukeConnect Calibrator;

        public const double InpMinValue = 1;
        public const double InpMaxValue = 12;

        public double[] MinValue = new double[numberOfChannels];
        public double[] MaxValue = new double[numberOfChannels];

        public int[] coefficients = new int[numberOfChannels];
        public double[] offsets = new double[numberOfChannels];
        //public double[] measureLow = new double[numberOfChannels];
        //public double[] measureHigh = new double[numberOfChannels];

        public const int numberOfChannels = 4;
        public const int cycleDelay = 1000;
        public const int cycleCount = 10;

        public VoltageInputCalibration(HttpClientClass client, FlukeConnect calibrator)
        {
            ClientCalibration = client;
            Calibrator = calibrator;
        }
        public async Task prepareCalibration()
        {
            string request, chNum;
            try
            {
                for (int ch = 0; ch < numberOfChannels; ch++)
                {
                    chNum = (ch + 1).ToString();
                    request = "SCVB" + chNum + "." + "InputMultiplier" + "&value=" + "0.001";
                    await ClientCalibration.parameterExecutedRequest(request);
                    request = "SCVB" + chNum + "." + "CalibrKoef" + "&value=" + "1000";
                    await ClientCalibration.parameterExecutedRequest(request);
                    request = "SCVB" + chNum + "." + "InputOffset" + "&value=" + "0";
                    await ClientCalibration.parameterExecutedRequest(request);
                    request = "SCVB" + chNum + "." + "CompensationCurrent" + "&value=" + "1";
                    await ClientCalibration.parameterExecutedRequest(request);
                    request = "SCVB" + chNum + "." + "ChannelType" + "&value=" + "0";
                    await ClientCalibration.parameterExecutedRequest(request);

                    await restartAs02Server();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public async Task restartAs02Server()
        {
            LabelInfo.Text = "Перезапуск измерительного сервера. (5 сек.)";
            await ClientCalibration.restartingMeasuringServer();
            await Task.Delay(5000);
        }

        public async Task calibratorOutputSet(double value, FlukeUnit unit)
        {
            LabelInfo.Text = "Установка выходного значения калибратора (10 сек.)";
            Calibrator.SetOutput(value, unit);
            Calibrator.SetOperMode();
            await Task.Delay(10000);
        }
        public async Task<int[]> calculateCoefficients()
        {
            MinValue = await valueMeasurement(InpMinValue, FlukeUnit.V);
            MaxValue = await valueMeasurement(InpMaxValue, FlukeUnit.V);

            for (int i = 0; i < numberOfChannels; i++)
            {
                coefficients[i] = (int)(((InpMaxValue - InpMinValue) / (MaxValue[i] - MinValue[i])) * 1000);
            }
            return coefficients;
        }

        public double[] calculateOffsets()
        {
            for (int i = 0; i < numberOfChannels; i++)
            {
                offsets[i] = InpMaxValue - ((coefficients[i] * MaxValue[i]) / 1000);
            }
            return offsets;
        }

        public async Task settingCoefficients()
        {
            CultureInfo cultureInfoOrig = System.Threading.Thread.CurrentThread.CurrentUICulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            string requestCoeff, requestOffset, chNum, val;
            try
            {

                for (int ch = 0; ch < numberOfChannels; ch++)
                {
                    chNum = (ch + 1).ToString();

                    val = coefficients[ch].ToString();
                    requestCoeff = "SCVB" + chNum + "." + "CalibrKoef" + "&value=" + val;
                    await ClientCalibration.parameterExecutedRequest(requestCoeff);

                    val = offsets[ch].ToString();
                    requestOffset = "SCVB" + chNum + "." + "InputOffset" + "&value=" + val;
                    await ClientCalibration.parameterExecutedRequest(requestOffset);
                }
                System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfoOrig;
                await restartAs02Server();
            }
            catch (Exception ex)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfoOrig;
                MessageBox.Show(ex.Message);
            }
        }


        public async Task<double[]> errorCalculation()
        {
            string request, chNum;
            double[] errors = new double[numberOfChannels];
            try {

                for (int ch = 0; ch <= numberOfChannels; ch++)
                {
                    chNum = (ch + 1).ToString();
                    request = "SCVB" + chNum + "." + "InputMultiplier" + "&value=" + "0.001";
                    await ClientCalibration.parameterExecutedRequest(request);
                    request = "SCVB" + chNum + "." + "ChannelType" + "&value=" + "0";
                    await ClientCalibration.parameterExecutedRequest(request);
                }
                await restartAs02Server();

                MaxValue = await valueMeasurement(InpMaxValue, FlukeUnit.V);

                for (int ch = 0; ch < numberOfChannels; ch++)
                {
                    errors[ch] = Math.Abs(InpMaxValue - MaxValue[ch]) * 1000;
                }

                return errors;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return errors;
            }

        }


        public async Task<double[]> valueMeasurement(double value, FlukeUnit unit)
        {
            double[] result = new double[numberOfChannels];
            double temp = 0;
            try
            {
                await calibratorOutputSet(value, unit);

                for (int i = 0; i < numberOfChannels; i++)
                {
                    for (int j = 0; j < cycleCount; j++)
                    {
                        string param = "SCVB" + (i + 1).ToString() + ".VbrRawVal";
                        temp += await getResponse(param);
                        await Task.Delay(cycleDelay);
                        LabelInfo.Text = "Измерение заначения " + value.ToString() + ". канал " + (i + 1).ToString() + " измерение:" + (j + 1).ToString();
                    }
                    result[i] = temp / cycleCount;
                    temp = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            LabelInfo.Text = "";
            return result;
        }

        public async Task<double> getResponse(string param)
        {
            string temp = await ClientCalibration.parameterExecutedRequest(param);
            double result = responseToDouble(temp);
            return result;
        }

        private double responseToDouble(string var)
        {
            //С прибора идут данные в универсальном формате,
            //поэтому для правильной работы нужно использовать американскую локализацию
            CultureInfo cultureInfoOrig = System.Threading.Thread.CurrentThread.CurrentUICulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            double result;
            if (double.TryParse(var, out result))
            {
                //Возвращаем локализацию, чтобы ничего не сломать
                System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfoOrig;
                return result;
            }
            else
            {
                //Возвращаем локализацию, чтобы ничего не сломать
                System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfoOrig;
                MessageBox.Show("Не возможно преобразовать '{0}'.", var);
                return 0;
            }
        }
    }
}
