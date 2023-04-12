using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTLSoftwareTools.SensorConfig
{
    public class Sensor
    {
        public string[] propertyDescription = { "Название", "Тип канала", "Тип сигнала", "Тип датчика", "Множитель ко входу", "Чувствительность", "Vmin", "Vmax" };
        public string SensorName { get; set; }
        public string MeasurementType { get; set; }
        public string ChannelType { get; set; }
        public string SensorType { get; set; }
        public string InputMultiplier { get; set; }
        public string Sensitivity { get; set; }
        public string FailStMin { get; set; }
        public string FailStMax { get; set; }
    }
}
