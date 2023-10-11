using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using BarCodeReader;

namespace BarCodeTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            SerialPort port = new SerialPort("COM9", 9600, Parity.None, 8, StopBits.One);
            port.Open();
            BarCodeReaderClass reader = new BarCodeReaderClass(port);
            await reader.StartReadAsync();
            Console.WriteLine(reader.BarCode);
            port.Close();   
            //port.DataReceived += reader.DataReceive;
           Console.ReadLine();

        }
    }
}
