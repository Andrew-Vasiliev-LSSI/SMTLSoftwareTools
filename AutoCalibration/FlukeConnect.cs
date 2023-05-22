using System;
using System.Globalization;
using System.IO.Ports;
using System.Threading;

namespace Aean.MidasTools.Services
{
    public class FlukeConnect
    {
        private SerialPort Port { get; set; }

        public int BaudRate { get; set; } = 9600;
        public Parity Parity { get; set; } = Parity.None;
        public StopBits StopBits { get; set; } = StopBits.One;
        public int DataBits { get; set; } = 8;
        public Handshake Handshake { get; set; } = Handshake.XOnXOff;
        public int ReadTimeout { get; set; } = 2000;
        public int WriteTimeout { get; set; } = 2000;
        private string PortName { get; set; } = "";
        public bool Run { get; set; }

        /// <summary>
        /// Конструктор соединения с Fluke по умолчанию
        /// </summary>
        public FlukeConnect()
        {
            Run = false;
        }

        /// <summary>
        /// Конструктор соединения с Fluke пользовательский
        /// </summary>
        public FlukeConnect(string com, int baudRate, Parity parity, StopBits stopBits, int dataBits, int readTimeout, int writeTimeout)
        {
            Port.PortName = com;
            Port.BaudRate = baudRate;
            Port.Parity = parity;
            Port.StopBits = stopBits;
            Port.DataBits = dataBits;
            Port.Handshake = Handshake.XOnXOff;
            Port.ReadTimeout = readTimeout;
            Port.WriteTimeout = writeTimeout;
        }

        public void Initialize(string portName)
        {
            PortName = portName;
            ClosePort();
            OpenPort();
        }

        public bool IsOpen()
        {
            if (Port == null)
            {
                throw new Exception("Ошибка работы с калибратором.");
            }

            return Port.IsOpen;
        }

        /// <summary>
        /// Открыть порт
        /// </summary>
        private void OpenPort()
        {
            try
            {
                Port = new SerialPort(PortName);
                Port.BaudRate = BaudRate;
                Port.Parity = Parity;
                Port.StopBits = StopBits;
                Port.DataBits = DataBits;
                Port.Handshake = Handshake;
                Port.ReadTimeout = ReadTimeout;
                Port.WriteTimeout = WriteTimeout;
                Port.Open();
            }
            catch
            {
                throw new Exception("Ошибка открытия порта.");
            }
        }

        /// <summary>
        /// Закрыть порт
        /// </summary>
        public void ClosePort()
        {
            if (Port == null)
            {
                return;
            }

            try
            {
                Port.Close();
            }
            catch
            {
                throw new Exception("Ошибка закрытия порта.");
            }
        }

        /// <summary>
        /// Состояние прибора
        /// </summary>
        public string GetInfoDevice()
        {
            if (Port == null)
            {
                throw new Exception("Ошибка работы с калибратором.");
            }

            string rez = "";
            try
            {
                Port.Write("*IDN?\r\n");
                rez = Port.ReadTo("\r");
            }
            catch
            {
                throw new Exception("Ошибка получения идентификатора калибратора.");
            }

            return rez;
        }

        /// <summary>
        /// Установка значения токового выхода
        /// </summary>
        /// <param name="value">Значение выхода</param>
        /// <param name="unit">Единица измерения</param>
        public void SetOutput(double value, FlukeUnit unit)
        {
            if (Port == null)
            {
                throw new Exception("Ошибка работы с калибратором.");
            }

            try
            {
                Port.Write("OUT " + value.ToString() + " " + unit.ToString() + "\r\n");
            }
            catch
            {
                throw new Exception("Ошибка записи значения.");
            }
        }

        public bool GetStandbyMode()
        {
            if (Port == null)
            {
                throw new Exception("Ошибка работы с калибратором.");
            }

            bool standbyMode = false;
            string rez = "";

            try
            {
                Port.Write("OPER?\r\n");
                rez = Port.ReadTo("\r");
                if (rez.Contains("1"))
                {
                    standbyMode = false;
                }
                else if (rez.Contains("0"))
                {
                    standbyMode = true;
                }
            }
            catch
            {
                throw new Exception("Ошибка записи значения.");
            }

            return standbyMode;
        }

        public void SetOperMode()
        {
            if (Port == null)
            {
                throw new Exception("Ошибка работы с калибратором.");
            }

            string rez = "";
            try
            {
                Port.Write("OPER\r\n");
            }
            catch
            {
                throw new Exception("Ошибка установки OPER");
            }
        }

        public void SetStandbyMode()
        {
            if (Port == null)
            {
                throw new Exception("Ошибка работы с калибратором.");
            }

            if (GetStandbyMode() == true)
            {
                return;
            }

            try
            {
                Port.Write("STBY\r\n");
            }
            catch
            {
                throw new Exception("Ошибка установки STBY");
            }
        }

        /// <summary>
        /// Чтение значения аналового выхода
        /// </summary>
        public string GetOutput()
        {
            if (Port == null)
            {
                throw new Exception("Ошибка работы с калибратором.");
            }

            string rez = "";
            try
            {
                Port.Write("OUT?\r\n");
                rez = Port.ReadByte().ToString();
            }
            catch
            {
                throw new Exception("Ошибка чтения значения.");
            }
            return rez;
        }

        public string ActiveLoopPower(bool Active)
        {
            if (Port == null)
            {
                throw new Exception("Ошибка работы с калибратором.");
            }

            string rez = "";
            try
            {
                if (Active)
                    Port.Write("LOOP_POWER_ON\r\n");
                else
                    Port.Write("LOOP_POWER_OFF\r\n");
            }
            catch (Exception e)
            {
                throw new Exception("Ошибка изменения состояния.");
            }
            return rez;
        }

        public double GetInputValue(int mult)
        {
            if (Port == null)
            {
                throw new Exception("Ошибка работы с калибратором.");
            }

            double rez = 0;
            string valCalibrator = "";
            try
            {
                Port.Write("VAL?\r\n");
                valCalibrator = Port.ReadTo(",");

                string valToDouble = valCalibrator;

                //С прибора идут данные в универсальном формате,
                //поэтому для правильной работы нужно использовать американскую локализацию
                CultureInfo cultureInfoOrig = System.Threading.Thread.CurrentThread.CurrentUICulture;
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

                bool result = double.TryParse(valToDouble, out rez);
                if (result)
                {
                    rez = Convert.ToDouble(valToDouble) * mult;
                }
                else
                {
                    Console.WriteLine("Unable to parse '{0}'.", valCalibrator);
                    rez = 0;
                }

                //Возвращаем локализацию, чтобы ничего не сломать
                System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfoOrig;

                Port.ReadTo("\r");
            }
            catch (Exception e)
            {
                throw new Exception("Ошибка чтения входного значения.");
            }
            return rez;
        }

        public void ApplyСurrent()
        {
            if (Port == null)
            {
                throw new Exception("Ошибка работы с калибратором.");
            }

            try
            {
                Port.Write("OPER\r\n");
            }
            catch
            {
                throw new Exception("Ошибка выполнения операции OPER.");
            }
        }
    }
    /// <summary>
    /// Единицы измерения
    /// </summary>
    public enum FlukeUnit
    {
        μV,
        mV,
        V,
        kV,
        μA,
        mA,
        A,
        Ohm,
        kOhm,
        MOhm,
        cel,
        far
    }
}
