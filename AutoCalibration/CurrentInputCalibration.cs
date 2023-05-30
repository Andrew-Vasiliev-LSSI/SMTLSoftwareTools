using Aean.MidasTools.Services;
using SMTLSoftwareTools.SensorConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTLSoftwareTools.AutoCalibration
{
    internal class CurrentInputCalibration : VoltageInputCalibration
    {
        public new const double InpMaxValue = 12000;
        public double[] compensations = new double[numberOfChannels];
        public CurrentInputCalibration(HttpClientClass client, FlukeConnect calibrator) : base(client, calibrator)
        {
            ClientCalibration = client;
            Calibrator = calibrator;
            Calibrator.SetOperMode();
        }

        public new async Task prepareCalibration()
        {
            string request, chNum;

            for (int ch = 0; ch < numberOfChannels; ch++)
            {
                chNum = (ch + 1).ToString();

                try
                {
                    request = "SCVB" + chNum + "." + "InputMultiplier" + "&value=" + "4";
                    await ClientCalibration.parameterExecutedRequest(request);
                    await ClientCalibration.parameterExecutedRequest(request);
                    request = "SCVB" + chNum + "." + "CompensationCurrent" + "&value=" + "1";
                    await ClientCalibration.parameterExecutedRequest(request);
                    request = "SCVB" + chNum + "." + "ChannelType" + "&value=" + "1";
                    await ClientCalibration.parameterExecutedRequest(request);

                    await ClientCalibration.restartingMeasuringServer();
                    System.Threading.Thread.Sleep(5000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public async Task<double[]> calculateCompensations()
        {
            calibratorSettings(InpMaxValue);
            System.Threading.Thread.Sleep(5000);

            await measureValue();

            for (int i = 0; i < numberOfChannels; i++)
            {
                compensations[i] = MaxValue[i] / InpMaxValue;
            }
 
            return compensations;
        }

        private async Task measureValue()
        {
            double[] upper = new double[numberOfChannels];
            double[] ImaxTemp = new double[numberOfChannels];

            try
            {
                calibratorSettings(InpMaxValue);
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
                for (int i = 0; i < cycleCount; i++)
                {
                    ImaxTemp[i] += upper[i];
                }

                for (int i = 0; i < numberOfChannels; i++)
                {
                    ImaxTemp[i] /= cycleCount;
                    MaxValue[i] = ImaxTemp[i];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async Task settingCompensations()
        {
            string request, chNum, val;

            for (int ch = 0; ch < numberOfChannels; ch++)
            {
                chNum = (ch + 1).ToString();

                try
                {
                    val = compensations[ch].ToString();
                    request = "SCVB" + chNum + "." + "CompensationCurrent" + "&value=" + val;
                    await ClientCalibration.parameterExecutedRequest(request);

                    await ClientCalibration.restartingMeasuringServer();
                    System.Threading.Thread.Sleep(5000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public new void calibratorSettings(double value)
        {
            Calibrator.SetOutput(value, FlukeUnit.μA);
        }


    }
}
