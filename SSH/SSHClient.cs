using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Renci.SshNet;

namespace SMTLSoftwareTools.SSH

{
    public class SSHClient
    {

        public SshClient Client { get; set; }
        string IP { get; set; }
        string Username { get; set; }
        string Password { get; set; }

        public SSHClient(string ip, string username, string password)
        {
            IP = ip;
            Username = username;
            Password = password;

            Client = new SshClient(IP, Username, Password);
        }

        public void Connect()
        {           
            if(!Client.IsConnected)
             Client.Connect();
        }
        public void Disconnect()
        {
            Client.Disconnect();
        }

        public string GetSerialNumber(string deviceType)
        {
            string rez = "";
            string commandValue = "";
            if (deviceType == "AEAN")
                commandValue = "cat /opt/share/sernum";
            else if (deviceType == "OpenSCADA")
                commandValue = "cat /home/as02server/sernum";
            var Command = Client.CreateCommand(commandValue);
            rez = Command.Execute();
            return rez;
        }
    }
}
