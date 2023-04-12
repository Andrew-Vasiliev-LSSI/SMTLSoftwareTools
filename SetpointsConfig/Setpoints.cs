using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTLSoftwareTools.SetpointsConfig
{
    internal class Setpoints
    {
        public string[] Vbr2Amax { get; set; } = { "Размах вибрации", "0", "0" };
        public string[] Vbr2Amean { get; set; } = { "Средний размах вибрации", "0", "0" };
        public string[] VbrRMS { get; set; } = {"СКЗ", "0", "0" };
        public string[] VbrMaxInp { get; set; } = { "Максимум за период", "0", "0" };
        public string[] VbrMinInp { get; set; } = { "Минимум за период", "0", "0" };
        public string[] VbrConstComp { get; set; } = { "Амплитуда постоянной составляющей", "0", "0" };
        public string[] VbrRawVal { get; set; } = { "Смещение", "0", "0" };
    }
}
