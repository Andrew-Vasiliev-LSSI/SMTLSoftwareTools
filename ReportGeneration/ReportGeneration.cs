using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml.Style;

namespace SMTLSoftwareTools.ReportGeneration
{
    public class ReportGeneration
    {
        public string SerialNumber { get; set; }
        public string CalibrationType { get; set; }
        // Кто выполнил калибровку
        public string Executor { get; set; }
        private ExcelPackage package = null;


        public ReportGeneration()
        {
            Environment.SetEnvironmentVariable("EPPlusLicenseContext", "NonCommercial");
            package = new ExcelPackage();
        }

        public ReportGeneration(string serialNumber)
        {
            Environment.SetEnvironmentVariable("EPPlusLicenseContext", "NonCommercial");
            package = new ExcelPackage();
            SerialNumber = serialNumber;
        }

        public void ExportToExcel(params DataGridView[] dataGridViews)
        {
            int worksheetIndex = 1;

            // Перебор всех DataGridView и добавление их данных в файл Excel
            foreach (DataGridView dataGridView in dataGridViews)
            {
                ExcelWorksheet worksheet;

                if (dataGridViews.Length > 1)
                {
                    worksheet = package.Workbook.Worksheets.Add(CalibrationType + " Канал N " + worksheetIndex.ToString());
                }
                else
                {
                    worksheet = package.Workbook.Worksheets.Add(CalibrationType);
                }

                worksheet.Cells[1, 1].Value = "Прибор DMC-AS02 серийный номер " + SerialNumber;
                worksheet.Cells[10, 1].Value = "Калибровку выполнил " + Executor;

                ExcelRange range = worksheet.Cells["A3:C8"];
                range.Style.Border.Top.Style = ExcelBorderStyle.Medium;
                range.Style.Border.Top.Color.SetColor(System.Drawing.Color.Black);
                range.Style.Border.Left.Style = ExcelBorderStyle.Medium;
                range.Style.Border.Left.Color.SetColor(System.Drawing.Color.Black);
                range.Style.Border.Right.Style = ExcelBorderStyle.Medium;
                range.Style.Border.Right.Color.SetColor(System.Drawing.Color.Black);
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Medium;
                range.Style.Border.Bottom.Color.SetColor(System.Drawing.Color.Black);

                // Запись заголовков столбцов из DataGridView
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    worksheet.Cells[3, i + 1].Value = dataGridView.Columns[i].HeaderText;
                }

                // Запись данных из DataGridView
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 4, j + 1].Value = dataGridView.Rows[i].Cells[j].Value;
                    }
                }
                worksheet.Cells.AutoFitColumns();
                worksheetIndex++;
            }

        }
        public void SaveReport()
        {
            // Сохранение файла
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Save Excel File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                package.SaveAs(new FileInfo(saveFileDialog.FileName));
            }
        }
    }
}
