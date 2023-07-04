using Aean.MidasTools.Services;
using SMTLSoftwareTools.SensorConfig;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTLSoftwareTools.AutoCalibration
{
    internal class CurrentInputCalibration : VoltageInputCalibration
    {
        public new const double InpMaxValue = 12;
        public double[] compensations = new double[numberOfChannels];
        public CurrentInputCalibration(HttpClientClass client, FlukeConnect calibrator) : base(client, calibrator)
        {
            ClientCalibration = client;
            Calibrator = calibrator;
        }

        public new async Task prepareCalibration()
        {
            string request, chNum;

            for (int ch = 0; ch < numberOfChannels; ch++)
            {
                chNum = (ch + 1).ToString();

                try
                {
                    request = "SCVB" + chNum + "." + "InputMultiplier" + "&value=" + "0.004";
                    await ClientCalibration.parameterExecutedRequest(request);
                    await ClientCalibration.parameterExecutedRequest(request);
                    request = "SCVB" + chNum + "." + "CompensationCurrent" + "&value=" + "1";
                    await ClientCalibration.parameterExecutedRequest(request);
                    request = "SCVB" + chNum + "." + "ChannelType" + "&value=" + "1";
                    await ClientCalibration.parameterExecutedRequest(request);

                    await restartAs02Server();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public async Task settingCompenstaions()
        {
            CultureInfo cultureInfoOrig = System.Threading.Thread.CurrentThread.CurrentUICulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            string request, chNum, val;
            try
            {

                for (int ch = 0; ch < numberOfChannels; ch++)
                {
                    chNum = (ch + 1).ToString();

                    val = compensations[ch].ToString();
                    request = "SCVB" + chNum + "." + "CompensationCurrent" + "&value=" + val;
                    await ClientCalibration.parameterExecutedRequest(request);
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
        public async Task<double[]> calculateCompensations()
        {
            MaxValue = await valueMeasurement(InpMaxValue, FlukeUnit.mA);

            for (int i = 0; i < numberOfChannels; i++)
            {
                compensations[i] = (InpMaxValue * 1000) / MaxValue[i]; 
            }
             return compensations;
        }

        public new async Task<double[]> errorCalculation()
        {
            double[] errors = new double[numberOfChannels];
            string request, chNum;

            try
            {
                for (int ch = 0; ch <= numberOfChannels; ch++)
                {
                    chNum = (ch + 1).ToString();
                    request = "SCVB" + chNum + "." + "InputMultiplier" + "&value=" + "0.004";
                    await ClientCalibration.parameterExecutedRequest(request);
                    request = "SCVB" + chNum + "." + "ChannelType" + "&value=" + "1";
                    await ClientCalibration.parameterExecutedRequest(request);
                }
                await restartAs02Server();

                MaxValue = await valueMeasurement(InpMaxValue, FlukeUnit.mA);

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

        /*
                    string request, chNum;
                    double[] errors = new double[numberOfChannels];
                    try
                    {

                        for (int ch = 0; ch <= numberOfChannels; ch++)
                        {
                            chNum = (ch + 1).ToString();
                            request = "SCVB" + chNum + "." + "InputMultiplier" + "&value=" + "0.001";
                            await ClientCalibration.parameterExecutedRequest(request);
                            request = "SCVB" + chNum + "." + "ChannelType" + "&value=" + "0";
                            await ClientCalibration.parameterExecutedRequest(request);
                        }

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
        */



    }
}
