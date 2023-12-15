using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace BarCodeReader
{
    public class BarCodeReaderClass
    {
        public SerialPort Port { get; set; }

        public string BarCode { get; set; }

        public BarCodeReaderClass()
        {

        }

        public BarCodeReaderClass(SerialPort port)
        {
            Port = port;
        }

        public async Task StartReadAsync()
        {
            BarCode = "";
            Port.DiscardInBuffer();
            Port.DataReceived += DataReceivedHandler;
            await CyclePortRead();
        }
        private async Task CyclePortRead()
        {
            while (BarCode.Length == 0)
            {
                await Task.Delay(500);
            };
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            int totalBytes = Port.BytesToRead;

            if (totalBytes < 12)
            {
                BarCode = "Ошибка сканирования";
            }
            else
            {
                byte[] buffer = new byte[totalBytes];
                Port.Read(buffer, 0, totalBytes);

                Encoding encoding = Encoding.GetEncoding("iso-8859-1");
                string barcodeText = encoding.GetString(buffer);

                // Удалить символы перевода строки, если они есть
                BarCode = barcodeText.Trim('\r', '\n');
                BarCode = "0" + BarCode;
            }
        }


    }
}
