using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMTLSoftwareTools.ReportGeneration;
using Renci.SshNet;
using System.IO;
using System.Diagnostics;

namespace SMTLSoftwareTools.AutoCalibration
{
    internal class CreatingReport
    {
        public DataGridView[] DataGridViews { get; set; }
        public string SerialNumber { get; set; }
        public string PathReport { get; set; }
        public string Executor { get; set; }

        public CreatingReport()
        {
            
        }

        public void Create()
        {
            PathReport = PathReport + @"\as02_" + SerialNumber;
            if (!Directory.Exists(PathReport))
            {
                Directory.CreateDirectory(PathReport);
                ReportGen reportgen = new ReportGen(SerialNumber, Executor, PathReport);

                DataGridView[] dataGridViewsVoltage = new DataGridView[] { DataGridViews[0] };
                reportgen.ExportToExcel(CalibrationType.Voltage, dataGridViewsVoltage);
                DataGridView[] dataGridViewsCurrent = new DataGridView[] { DataGridViews[1] };
                reportgen.ExportToExcel(CalibrationType.Current, dataGridViewsCurrent);
                DataGridView[] dataGridViewsOutput = new DataGridView[] { DataGridViews[2], DataGridViews[3], DataGridViews[4], DataGridViews[5] };
                reportgen.ExportToExcel(CalibrationType.AnalogOutput, dataGridViewsOutput);
                reportgen.SaveReport();
                CopyFilesFromPscp();

            }
            else
            {
                MessageBox.Show("Директория " + PathReport + " уже существует");
            }
        }
        public void CopyFilesFromPscp()
        {
            string arg = @"-pw perseus -P 22  smtl@192.168.0.1:/opt/aean/assets/config/*.json " + PathReport;
            string path = Path.Combine(Environment.CurrentDirectory, "Pscp");
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.FileName = path + @"\pscp.exe";
            proc.StartInfo.Arguments = arg;
            proc.Start();
        }
    }
}
