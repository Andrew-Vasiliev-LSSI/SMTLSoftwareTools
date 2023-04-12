using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SMTLSoftwareTools.TCP
{
    internal class TcpClientClass
    {
        public string Ip { get; set; }
        public int Port { get; set; }
        private static TcpClient tcpClient;

        public TcpClientClass()
        {
            
        }

         public async Task<string> softwareVersion()
        {
            string result = "";
            byte[] request = { 09,00,00,00 };
            await sendTcpRequest(request);
            byte[] temp = await readTcpData();
            byte[] segment = new ArraySegment<byte>(temp, 14, 17).ToArray();
            result = Encoding.UTF8.GetString(segment);

            return result;
        }
        public async Task tcpConnect()
        {
            tcpClient = new TcpClient();
            try
            {
                await tcpClient.ConnectAsync(Ip, Port);
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void tcpDisconnect()
        {
            tcpClient.Close();
        }

        private async Task sendTcpRequest(byte[] req)
        {
            NetworkStream stream = tcpClient.GetStream();
            await stream.WriteAsync(req, 0, req.Length);
        }

        private async Task<byte[]> readTcpData()
        {
            byte[] responseData = new byte[32];
            NetworkStream stream = tcpClient.GetStream();

            do
            {
                await stream.ReadAsync(responseData, 0, responseData.Length);
            }
            while (tcpClient.Available > 0);

            return responseData;
        }
    }
}
