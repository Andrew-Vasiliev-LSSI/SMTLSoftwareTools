using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMTLSoftwareTools.SSH;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using System.Reflection;
using System.Globalization;
using SMTLSoftwareTools.Http;

namespace SMTLSoftwareTools.SensorConfig
{

    public partial class SensorConfigForm : Form
    {
        private static HttpClientClass ClientSensors;
        private List<Sensor> sensors;
        private Sensor currentSensor = new Sensor();
        private PropertyInfo[] sensorPropertyInfo;
        private string channelNumber;
        private RadioButton[] channelsArray = new RadioButton[4];

        public SensorConfigForm(HttpClientClass client)
        {
            InitializeComponent();
            ClientSensors = client;
        }

        #region Интерфейс
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private async void connected()
        {
            try
            {
                channelNumber = "1.";
                await sensorWriteRead("read");
                btWrite.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void SensorConfigForm_Load(object sender, EventArgs e)
        {
            fillCannelsArray();
            readJson();
            connected();
        }

        private void fillCannelsArray()
        {
            channelsArray[0] = rbCh1;
            channelsArray[1] = rbCh2;
            channelsArray[2] = rbCh3;
            channelsArray[3] = rbCh4;
        }

        private void readJson()
        {
            if (File.Exists("sensors.json"))
            {
                string data = File.ReadAllText("sensors.json");
                sensors = JsonSerializer.Deserialize<List<Sensor>>(data);

                foreach (var item in sensors)
                {
                    dataGridViewSensors.Rows.Add(item.SensorName, item.MeasurementType);
                }
                Type sensorType = typeof(Sensor);
                sensorPropertyInfo = sensorType.GetProperties();
            }
            else
            {
                MessageBox.Show("Нет файла конфигурации датчиков sensors.json");
                this.Close();
            }

        }

        private void btSelectSensor_Click(object sender, EventArgs e)
        {
            int index = dataGridViewSensors.CurrentRow.Index;
            if (index != -1)
            {
                lbSelected.Text = "Выбраный датчик";
                sensorSelection(index);
                displaySelectedSensor();
            }
            else
                MessageBox.Show("Выбери датчик", "Не выбран датчик", MessageBoxButtons.OK);
        }
        private async void btWrite_Click(object sender, EventArgs e)
        {
            await sensorWriteRead("write");
            await ClientSensors.restartingMeasuringServer();
            MessageBox.Show("Параметры датчика для канала N" + channelNumber + " записаны в прибор");
        }
        #endregion
        #region Выбор датчика
        private void dataGridViewSensors_KeyDown(object sender, KeyEventArgs e)
        {
            int index = dataGridViewSensors.CurrentRow.Index;
            if (e.KeyCode == Keys.Enter)
            {
                lbSelected.Text = "Выбраный датчик";
                sensorSelection(index);
                displaySelectedSensor();
            }
        }

        private void sensorSelection(int index)
        {
            string param, paramValue;
            Sensor selectedSensor = sensors[index];
            if (selectedSensor != null)
            {
                for (int i = 0; i < sensorPropertyInfo.Length; i++)
                {
                    param = sensorPropertyInfo[i].Name;
                    paramValue = selectedSensor.GetType().GetProperty(param).GetValue(selectedSensor, null).ToString();
                    currentSensor.GetType().GetProperty(param).SetValue(currentSensor, paramValue);
                }
            }
        }
        private void displaySelectedSensor()
        {
            string param, paramName, paramValue;
            dataGridViewSelected.Rows.Clear();
            dataGridViewSelected.Refresh();
            for (int i = 0; i < sensorPropertyInfo.Length; i++)
            {
                param = sensorPropertyInfo[i].Name;
                paramName = currentSensor.propertyDescription[i];
                paramValue = currentSensor.GetType().GetProperty(param).GetValue(currentSensor, null).ToString();
                dataGridViewSelected.Rows.Add(param, paramName, paramValue);
            }
        }
        #endregion
        #region Запись/Чтение параметров датчикв
        private async Task sensorWriteRead(string mode)
        {
            string request, name, value;

            for (int i = 2; i < sensorPropertyInfo.Length; i++)
            {
                name = sensorPropertyInfo[i].Name;
                if (mode == "write")
                {
                    try
                    {
                        value = currentSensor.GetType().GetProperty(sensorPropertyInfo[i].Name).GetValue(currentSensor, null).ToString();
                        request = "SCVB" + channelNumber + name + "&value=" + value;
                        await ClientSensors.parameterExecutedRequest(request);
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
                        request = "SCVB" + channelNumber + name;
                        string result = await ClientSensors.parameterExecutedRequest(request);
                        currentSensor.GetType().GetProperty(sensorPropertyInfo[i].Name).SetValue(currentSensor, result);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }

            if (mode == "read")
                readNameType();

            displaySelectedSensor();
        }
        private void readNameType()
        {
            int i, j;
            bool result = false;

            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";

            for (i = 0; i < sensors.Count; i++)
            {
                for (j = 2; j < sensorPropertyInfo.Length; j++)
                {
                    double valueCurrent = Convert.ToDouble(currentSensor.GetType().GetProperty(sensorPropertyInfo[j].Name).GetValue(currentSensor, null).ToString(), nfi);
                    double valueSensor = Convert.ToDouble(sensors[i].GetType().GetProperty(sensorPropertyInfo[j].Name).GetValue(sensors[i], null).ToString(), nfi);
                    valueCurrent = Math.Round(valueCurrent, 4);
                    valueSensor = Math.Round(valueSensor, 4);
                    if (valueCurrent == valueSensor)
                        result = true;
                    else
                    {
                        result = false;
                        break;
                    }
                }
                if (result == true)
                {
                    string name, type;
                    name = sensors[i].GetType().GetProperty(sensorPropertyInfo[0].Name).GetValue(sensors[i], null).ToString();
                    type = sensors[i].GetType().GetProperty(sensorPropertyInfo[1].Name).GetValue(sensors[i], null).ToString();
                    currentSensor.GetType().GetProperty(sensorPropertyInfo[0].Name).SetValue(currentSensor, type);
                    currentSensor.GetType().GetProperty(sensorPropertyInfo[1].Name).SetValue(currentSensor, name);
                    break;
                }
            }
            if (result == false)
            {
                currentSensor.GetType().GetProperty(sensorPropertyInfo[0].Name).SetValue(currentSensor, "");
                currentSensor.GetType().GetProperty(sensorPropertyInfo[1].Name).SetValue(currentSensor, "");
            }
        }

 
        // Обработка радиокнопок
        private async void rbCh1_Click(object sender, EventArgs e)
        {
            await readSelectedChannel();
        }

        private async void rbCh2_Click(object sender, EventArgs e)
        {
            await readSelectedChannel();
        }

        private async void rbCh3_Click(object sender, EventArgs e)
        {
            await readSelectedChannel();
        }

        private async void rbCh4_Click(object sender, EventArgs e)
        {
            await readSelectedChannel();
        }

        private async Task readSelectedChannel()
        {
            definitionSelectedChannel();
            await sensorWriteRead("read");
        }

        private void definitionSelectedChannel()
        {
            for (int i = 0; i < channelsArray.Length; ++i)
            {
                if (channelsArray[i].Checked == true)
                    channelNumber = (i + 1).ToString() + ".";
            }
        }
    }
    #endregion

}

/* Пример сериализации класса
 Sensor sensor = new Sensor()
 {
     SensorName = "ДВЗ 50",
     MeasurementType = "Воздушный зазор",
     ChannelType = "1",
     InputMultiplier = "0.01",
     Sensitivity = "0",
     FailStMin = "0.9",
     FailStMax = "5.1"
 };

 JsonSerializerOptions options = new JsonSerializerOptions()
 {
     WriteIndented = true, //добавляем пробелы для красоты
     Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping //не экранируем символы в строках
 };

 string sensorJson = JsonSerializer.Serialize(sensor, options);
 MessageBox.Show(sensorJson);
 StreamWriter file = File.CreateText("sensors.json");
 file.WriteLine(sensorJson);
 file.Close();
 */