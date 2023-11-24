using SMTLSoftwareTools.SensorConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMTLSoftwareTools.Http;

namespace SMTLSoftwareTools.ConfigManagment
{
    public partial class ConfigManagmentForm : Form
    {
        private static HttpClientClass СlientManagement;
        public ConfigManagmentForm(HttpClientClass client)
        {
            СlientManagement = client;
            InitializeComponent();
        }

 
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btSaveConfig_Click(object sender, EventArgs e)
        {
            // var fileConfig = await client.saveConfigExecuteRequest();

            byte[] data = await СlientManagement.saveConfigExecuteRequest();
           
            try
            {

                SaveFileDialog FileDialog = new SaveFileDialog();

                FileDialog.RestoreDirectory = true;
                FileDialog.FileName = $"as02libs.db";
                FileDialog.Filter = "DataBase (*.db)|*.db";
                if (FileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var fileStream = new FileStream(Path.Combine(FileDialog.FileName), FileMode.Create, FileAccess.Write))
                    {
                        fileStream.Write(data, 0, data.Length);
                    }

                    MessageBox.Show($"Файл конфигурации успешно сохранён в каталог {FileDialog.FileName}!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось сохранить файл конфигурации");
            }
            // }

        }

        private  void btLoadConfig_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] fileBytes = File.ReadAllBytes(openFileDialog.FileName);
                СlientManagement.UploadFile(fileBytes);
            }

                
        }
    }
}
