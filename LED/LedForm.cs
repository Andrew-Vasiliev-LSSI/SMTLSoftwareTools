using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMTLSoftwareTools.SensorConfig;
using SMTLSoftwareTools.Http;
using System.Threading;

namespace SMTLSoftwareTools.LED
{   
    public partial class LedForm : Form
    {
        private static HttpClientClass HttpClient;
        public LedForm(HttpClientClass client)
        {
            InitializeComponent();
            HttpClient = client;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btLedTest_Click(object sender, EventArgs e)
        {
            await HttpClient.ledTest();
            Thread.Sleep(1000);
            MessageBox.Show("Тест завершен");
        }
    }
}
