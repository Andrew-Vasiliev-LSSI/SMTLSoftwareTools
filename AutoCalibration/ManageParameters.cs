using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTLSoftwareTools.AutoCalibration
{
    internal class ManageParameters
    {
        // Конструктор
        public ManageParameters() 
        {
        }
 
        // Сохранение параметра
        public void SaveParameter(string parameter, string value)
        {
            if (parameter.Equals("lstPortsChoice"))
                Properties.Settings.Default.lstPortsChoiсe = value;
            else if (parameter.Equals("lstBaudrateChoice"))
                Properties.Settings.Default.lstBaudrateChoice = value;

            Properties.Settings.Default.Save();
        }
        // Чтение параметра
        public string LoadParameter(string parameter)
        {
            string choice = (string)Properties.Settings.Default?[parameter];
            return choice;
        }

    }
}
