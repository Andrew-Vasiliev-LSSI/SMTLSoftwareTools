using SMTLSoftwareTools.SensorConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace SMTLSoftwareTools.SetpointsConfig
{
    public partial class SetpointsConfigForms : Form
    {
        private readonly int numberOfChannels = 4;
        private List<Setpoints> setpoints = new List<Setpoints>();
        private static HttpClientClass ClientSetpoints;
        private PropertyInfo[] setpointsPropertyInfo;
        private DataGridView[] dataGridViews = null;
        public SetpointsConfigForms(HttpClientClass client)
        {
            ClientSetpoints = client;
            InitializeComponent();
            for (int i = 0; i < numberOfChannels; i++)
            {
                setpoints.Add(new Setpoints());                
            }

            dataGridViews = new DataGridView[numberOfChannels];
            dataGridViews[0] = dataGridViewSetpoints1;
            dataGridViews[1] = dataGridViewSetpoints2;
            dataGridViews[2] = dataGridViewSetpoints3;
            dataGridViews[3] = dataGridViewSetpoints4;

            Type setpointsType = typeof(Setpoints);
            setpointsPropertyInfo = setpointsType.GetProperties();
        }

        private async void connected()
        {
            try
            {
                await setpointsWriteRead("read");
                displaySetpoints();
                btWrite.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void displaySetpoints()
        {
            string param, hl, hh;
            int ch;
            for (ch = 0; ch < numberOfChannels; ch++)
            {
                dataGridViews[ch].Rows.Clear();
                for (int i = 0; i < setpointsPropertyInfo.Length; i++)
                {
                    string[] data = (string[])setpoints[ch].GetType().GetProperty(setpointsPropertyInfo[i].Name).GetValue(setpoints[ch], null);
                    param = data[0];
                    hl = data[1];
                    hh = data[2];
                    dataGridViews[ch].Rows.Add(param, hl, hh);
                }
            }
        }

        private async void readingChangedSettings()
        {           
            int ch;
            for (ch = 0; ch < numberOfChannels; ch++)
            {
                for (int i = 0; i < setpointsPropertyInfo.Length; i++)
                {
                    string param, hl, hh;
                    string[] result = new string[3];
                    param = dataGridViews[ch][0, i].Value.ToString();
                    hl = dataGridViews[ch][1, i].Value.ToString();
                    hh = dataGridViews[ch][2, i].Value.ToString();
                    result[0] = param;
                    result[1] = hl;
                    result[2] = hh;
                    setpoints[ch].GetType().GetProperty(setpointsPropertyInfo[i].Name).SetValue(setpoints[ch], result);
                }
            }
            await setpointsWriteRead("write");
            MessageBox.Show("Уставки записаны в прибор.");
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private async Task setpointsWriteRead(string mode)
        {
            string request, name, chNum;
            string[] result = new string[3];
            string[] value = new string[3];


            for (int ch = 0; ch < numberOfChannels; ch++)
            {
                chNum = (ch + 1).ToString();

                for (int i = 0; i < setpointsPropertyInfo.Length; i++)
                {
                    name = setpointsPropertyInfo[i].Name;

                    if (mode == "write")
                    {
                        try
                        {
                            value = (string[])setpoints[ch].GetType().GetProperty(setpointsPropertyInfo[i].Name).GetValue(setpoints[ch], null);
                            request = "SCVB" + chNum + "." + name + ":rangeC_hLim_f" + "&value=" + value[1]; // ПУ
                            await ClientSetpoints.parameterExecutedRequest(request);
                            request = "SCVB" + chNum + "." + name + ":rangeC_hhLim_f" + "&value=" + value[2]; // АУ
                            await ClientSetpoints.parameterExecutedRequest(request);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            result = (string[])setpoints[ch].GetType().GetProperty(setpointsPropertyInfo[i].Name).GetValue(setpoints[ch], null);

                            request = "SCVB" + chNum + "." + name + ":rangeC_hLim_f";  // ПУ
                            result[1] = await ClientSetpoints.parameterExecutedRequest(request); 
                            request = "SCVB" + chNum + "." + name + ":rangeC_hhLim_f"; // АУ
                            result[2] = await ClientSetpoints.parameterExecutedRequest(request);
                            setpoints[ch].GetType().GetProperty(setpointsPropertyInfo[i].Name).SetValue(setpoints[ch], result);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
            }

        }

        private void btWrite_Click(object sender, EventArgs e)
        {
            readingChangedSettings();
        }

        private void SetpointsConfigForms_Load(object sender, EventArgs e)
        {
            connected();
        }
    }
}


/*
http://192.168.0.1/api/attributedata?path=Vibro/SCVB1.Vbr2Amax:rangeC_hLim_f - предупредительная
http://192.168.0.1/api/attributedata?path=Vibro/SCVB1.Vbr2Amax:rangeC_hhLim_f - аварийная
*/