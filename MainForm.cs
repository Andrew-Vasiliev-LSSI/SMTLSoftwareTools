using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using SMTLSoftwareTools.SensorConfig;
using SMTLSoftwareTools.SetpointsConfig;
using SMTLSoftwareTools.ConfigManagment;
using System.Text.Json;
using System.Runtime.CompilerServices;
using System.Collections;
using SMTLSoftwareTools.TCP;
using SMTLSoftwareTools.AutoCalibration;

namespace SMTLSoftwareTools
{

    public partial class MainForm : Form
    {

        private static HttpClientClass client = new HttpClientClass();
        public MainForm()
        {
            InitializeComponent();
            client.LabelConnect = lbConnect;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btExecute_Click(object sender, EventArgs e)
        {
            if (rbtDeviceConfig.Checked == true)
            {
                string path = Path.Combine(Environment.CurrentDirectory, "Communicator");
                Process proc = new Process();
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.FileName = path + @"\Aean.Communicator.exe";
                proc.StartInfo.Arguments = "";
                proc.Start();
            }
            else if (rbtSensorConfig.Checked == true)
            {
                Form sencorConfig = new SensorConfigForm(client);
                sencorConfig.Show();
            }
            else if (rbtSetpoint.Checked == true)
            {
                Form setpointsConfig = new SetpointsConfigForms(client);
                setpointsConfig.Show();
            }
            else if (rbtConfigManagement.Checked == true)
            {
                Form configManagement = new ConfigManagmentForm(client);
                configManagement.Show();
            }
            else if (rbtAutoCalibration.Checked == true)
            {
                Form autoCalibration = new Calibration(client);
                autoCalibration.Show();
            }
        }


        private void btFmdConfig_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "FMD2");
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.FileName = path + @"\FMD02_Interface.exe";
            proc.StartInfo.Arguments = "";
            proc.Start();
        }

        private void btRtConfig_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "MidasTools");
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.FileName = path + @"\Aean.MidasTools.exe";
            proc.StartInfo.Arguments = "RT24";
            proc.Start();
        }

  
        private async void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Ip = textBoxIP.Text;
                client.authorization();
                string serNum = await serialNumber();
                textBoxSerNum.Text = serNum;
                panel1.Enabled = true;
                string ver = await softwareVersion();
                textBoxVersion.Text = ver;
            }
            catch (Exception ex)
            {
                lbConnect.Text = "Отключен";
                MessageBox.Show(ex.Message);
            }

        }

        private async Task<string> softwareVersion()
        {
            TcpClientClass client = new TcpClientClass();
            client.Ip = textBoxIP.Text;
            client.Port = 6000;
            await client.tcpConnect();
            string result = await client.softwareVersion();
            client.tcpDisconnect();
            return result;
        }
        private async Task<string> serialNumber()
        {
            byte[] temp = await client.serialNumberExecuteRequest();
            string serialNumber = Encoding.UTF8.GetString(temp);
            return serialNumber;
        }

        private void btAs01Calibr_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "As01Calibr");
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.FileName = path + @"\As01-phase-calibr.exe";
            proc.StartInfo.Arguments = "";
            proc.Start();
        }

        private void btAs01Show_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "AS01Show");
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.FileName = path + @"\ShowAs01-phase.exe";
            proc.StartInfo.Arguments = "";
            proc.Start();
        }

        private void btAiConfig_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "MidasTools");
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.FileName = path + @"\Aean.MidasTools.exe";
            proc.StartInfo.Arguments = "AI24";
            proc.Start();

        }
    }
 
}
