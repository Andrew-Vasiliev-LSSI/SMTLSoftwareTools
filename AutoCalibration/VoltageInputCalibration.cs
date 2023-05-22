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
        private static HttpClientClass ClientCalibration;
        private static FlukeConnect Calibrator;
        private const int numberOfChannels = 4;
        private const int cycleDelay = 500;
        private const int cycleCount = 5;
        private const double UinpMin = 1000;
        private const double UinpMax = 12000;

        private  double[] Umin = new double[numberOfChannels];
        private double[] Umax = new double[numberOfChannels];

        int[] coefficients = new int[numberOfChannels];
        double[] offsets = new double[numberOfChannels];
        double[] measureLow = new double[numberOfChannels];
        double[] measureHigh = new double[numberOfChannels];
        public VoltageInputCalibration(HttpClientClass client, FlukeConnect calibrator)
        {
            ClientCalibration = client;
            Calibrator = calibrator;
            Calibrator.SetOperMode();
        }
        public async Task prepareCalibration()
        {
            string request, chNum;

            for (int ch = 0; ch < numberOfChannels; ch++)
            {
                chNum = (ch + 1).ToString();

                try
                {
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public async Task<int[]> calculateCoefficients()
        {
            double[] UminTemp[] = new double[numberOfChannels];
            double[] UmaxTemp[] = new double[numberOfChannels];
            measureLow = await lowerMeasurement();
            measureHigh = await upperMeasurement();
            for (int i = 0; i < cycleCount; i++)
            {
                UminTemp[i] += measureLow[i];
                UmaxTemp[i] += measureHigh[i];
            }

            for (int i = 0; i < numberOfChannels; i++)
            {
                UminTemp[i] /= cycleCount;
                UmaxTemp[i] /= cycleCount;
                Umin[i] = UminTemp[i];
                Umax[i] = UmaxTemp[i];
                coefficients[i] = (int)(((UinpMax - UinpMin) / (Umax[i] - Umin[i])) * 1000);
            }
            return coefficients;
        }

        public double[] calculateOffsets()
        {
            for (int i =0; i < numberOfChannels; i++)
            {
                offsets[i] =UinpMax -((coefficients[i] * Umax[i]) / 1000);  
            }
            return offsets;
        }
        private async Task<double[]> lowerMeasurement()
        {
            double[] lower = new double[numberOfChannels];
            try
            {
                Calibrator.SetOutput(UinpMin, FlukeUnit.mV);
                System.Threading.Thread.Sleep(5000);
                for (int i = 0; i < numberOfChannels; i++)
                {
                    for (int j = 0; j < cycleCount; j++)
                    {
                        string param = "SCVB" + (i + 1).ToString() + ".VbrRawVal";
                        lower[j] = await getResponse(param);
                        System.Threading.Thread.Sleep(cycleDelay);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            return lower;
        }

        private async Task<double[]> upperMeasurement()
        {
            double[] upper = new double[numberOfChannels];
            try
            {
                Calibrator.SetOutput(UinpMax, FlukeUnit.mV);
                System.Threading.Thread.Sleep(5000);
                for (int i = 0; i < numberOfChannels; i++)
                {
                    for (int j = 0; j < cycleCount; j++)
                    {
                        string param = "SCVB" + (i + 1).ToString() + ".VbrRawVal";
                        upper[j] = await getResponse(param);
                        System.Threading.Thread.Sleep(cycleDelay);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            return upper;
        }

        private async Task<double> getResponse(string param)
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
