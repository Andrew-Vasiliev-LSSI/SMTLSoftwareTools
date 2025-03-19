using SMTLSoftwareTools.AutoCalibration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTLSoftwareTools.AutoCalibration
{
    internal class SummaryCalibrationResults
    {
        // Приватные поля для хранения данных
        private bool[] _calibrationResultsVoltage = { false, false, false, false };
        private bool[] _calibrationResultsCurrent = { false, false, false, false };
        private bool[] _calibrationResultsAnalog = { false, false, false, false };

        // Публичные свойства с геттерами и сеттерами
        public bool[] CalibrationResultsVoltage
        {
            get => _calibrationResultsVoltage;
            set => _calibrationResultsVoltage = value;
        }

        public bool[] CalibrationResultsCurrent
        {
            get => _calibrationResultsCurrent;
            set => _calibrationResultsCurrent = value;
        }

        public bool[] CalibrationResultsAnalog
        {
            get => _calibrationResultsAnalog;
            set => _calibrationResultsAnalog = value;
        }
        
        // Метод, возвращающий true при наличии хотя бы одной ошибки при калибровке
        public bool PresenceOfError()
        {
            bool hasFalseVoltage = Array.Exists(_calibrationResultsVoltage, x => !x);
            bool hasFalseCurrent = Array.Exists(_calibrationResultsCurrent, x => !x);
            bool hasFalseAnalog = Array.Exists(_calibrationResultsAnalog, x => !x);

            if (hasFalseVoltage || hasFalseCurrent || hasFalseAnalog)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

