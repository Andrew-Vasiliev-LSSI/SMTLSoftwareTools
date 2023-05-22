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

namespace SMTLSoftwareTools.AutoCalibration
{
    internal class VoltageInputCalibration
    {
        private static HttpClientClass ClientCalibration;
        private static FlukeConnect Calibrator;
        private const int numberOfChannels = 4;
        public VoltageInputCalibration(HttpClientClass client, FlukeConnect calibrator)
        {
            ClientCalibration = client;
            Calibrator = calibrator;
        }
        public async Task prepareCalibration()
        {
            //item.Multiplier.UserValue = 0.001;
            //item.SettingCalibrFactor.UserValue = 1000;
            //item.SettingOffset.UserValue = 0;
            //item.SettingCompensation.UserValue = 1;
            //item.TypeChannel.setVal = ChannelMode.Voltage;

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
            int[] coefficients = new int[numberOfChannels];
            float[] measureLow = new float[numberOfChannels];
            float[] measureHigh = new float[numberOfChannels];
            measureLow = await lowerMeasurement();
            measureHigh = await upperMeasurement();

            return coefficients;
        }

        private async Task<float[]> lowerMeasurement()
        {
            float[] lower = new float[numberOfChannels];

            return lower;
        }

        private async Task<float[]> upperMeasurement()
        {
            float[] upper = new float[numberOfChannels];

            return upper;
        }

    }
}
