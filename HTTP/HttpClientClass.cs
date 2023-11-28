using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Net;
using System.Windows.Forms;
using System.Net.Mime;
using System.IO;

namespace SMTLSoftwareTools.Http
{
    public class HttpClientClass
    {
        private static HttpClient Client { get; set; }
        public string Ip { get; set; }
        public string Result { get; set; }
        public Label LabelConnect { get; set; }



        // Конструктор
        public HttpClientClass()
        {
            Client = new HttpClient();
            Client.Timeout = TimeSpan.FromSeconds(5);
        }

        // Выполнение Http запроса для чтения параметра
        public async Task<string> parameterExecutedRequest(string param)
        {
            string address = "http://" + Ip + "/api/attributedata?path=Vibro/" + param;
            byte[] temp = await executingGetRequest(address);
            string res = Encoding.UTF8.GetString(temp);
            return res;
        }

        // Выполнение Http запроса для сохранения конфигурации
        public async Task<byte[]> saveConfigExecuteRequest()
        {
            string address = "http://" + Ip + "/api/config/download";
            byte[] res = await executingGetRequest(address);
            return res;
        }

        // Выполнение Http запроса для чтения серийного номера
        public async Task<byte[]> serialNumberExecuteRequest()
        {
            string address = "http://" + Ip + "/api/attributedata?path=Application/LPHD1.PhyNam:serNum";
            byte[] res = await executingGetRequest(address);
            return res;
        }

        // Выполнение Http запроса для перезапуска измерительного сервера
        public async Task restartingMeasuringServer()
        {
            string address = "http://" + Ip + "/api/attributedata?path=Application/LPHD1.ResetSrv:Oper_ctlVal&value=true";
            await executingGetRequest(address);
        }

        // Выполнение Http запроса для перезапуска коммуникационного шлюза
        public async Task restartingCommunicationGateway()
        {
            string address = "http://" + Ip + "/api/attributedata?path=Application/LPHD1.ResetGw:Oper_ctlVal&value=true";
            await executingGetRequest(address);
        }

        public async Task ledTest()
        {
            string address = "http://" + Ip + "/api/attributedata?path=Application/LPHD1.LEDTest:Oper_ctlVal&value=true";
            await executingGetRequest(address);
        }


        // Подключение и авторизация
        public void authorization()
        {
            try
            {
                var username = "rakurs";
                var password = "20_Com_05";
                var blobCreds = ASCIIEncoding.ASCII.GetBytes($"{username}:{password}");
                string b64Creds = Convert.ToBase64String(blobCreds);
                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", b64Creds);
                LabelConnect.Text = "Подключен";
            }
            catch (Exception ex)
            {
                LabelConnect.Text = "Отключен";
                MessageBox.Show(ex.Message);
            }
        }

        // Асинхронное выполнение Post запроса для загрузки конфигурации
        public void UploadFile(byte[] fileBytes)
        {
            try
            {

                HttpContent content = new ByteArrayContent(fileBytes, 0, fileBytes.Length);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                HttpResponseMessage response = Client.PostAsync("http://" + Ip + "/api/config/upload", content).Result;
                response.EnsureSuccessStatusCode();
                string sd = response.Content.ReadAsStringAsync().Result;
                MessageBox.Show($"Ответ сервера: {sd}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить файл конфигурации: " + ex.Message);
            }
        }

        // Асинхронное выполение Get запроса
        private async Task<byte[]> executingGetRequest(string address)
        {
            try
            {
                Client.CancelPendingRequests();

                HttpResponseMessage response = await Client.GetAsync(address);
                response.EnsureSuccessStatusCode();
                byte[] responseBody = await response.Content.ReadAsByteArrayAsync();
                return responseBody;

            }
            catch (Exception ex)
            {
                byte[] err = { 0 };
                LabelConnect.Text = "Отключен";
                MessageBox.Show(ex.Message, "Не удалось подключиться");
                return err;
            }
        }
    }
}
// Перезапуск измерительного сервера
// http://192.168.0.1/api/attributedata?path=Application/LPHD1.ResetSrv:Oper_ctlVal&value=true
// Тест светодиодов и выходных реле
// http://192.168.0.1/api/attributedata?path=Application/LPHD1.LEDTest:Oper_ctlVal&value=true