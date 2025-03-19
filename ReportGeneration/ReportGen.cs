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
    public class ReportGen
    {
        public string SerialNumber { get; set; }
        // Кто выполнил калибровку
        public string Executor { get; set; }
        public string PathReport { get; set; }
        private ExcelPackage package = null;
        private ExcelWorksheet worksheet;
        //Начальные координаты таблиц
        public List<List<int>> StartCoordinates { get; set; } = new List<List<int>>
        {
        new List<int> { 5, 1 }, // Начальные координаты для DataGridViewVoltage
        new List<int> { 5, 5 }, // Начальные координаты для DataGridViewCurrent
        new List<int> { 5, 8 }  // Начальные координаты для DataGridViewAnalogOutput1
        };

         public ReportGen(string serialNumber, string executor, string patch)
        {
            Environment.SetEnvironmentVariable("EPPlusLicenseContext", "NonCommercial");
            package = new ExcelPackage();           
            SerialNumber = serialNumber;
            Executor = executor;
            PathReport = patch;
            CreateWorksheet();
        }

        public void ExportToExcel(string calibrationType, params DataGridView[] dataGridViews)
        {
            List<int> coordinates;
            switch (calibrationType)
            {
                case "Voltage":
                    coordinates = StartCoordinates[0];
                    FillInTables(coordinates, dataGridViews);
                    break;
                case "Current":
                    coordinates = StartCoordinates[1];
                    FillInTables(coordinates, dataGridViews);
                    break;
                case "AnalogOutput":
                    coordinates = StartCoordinates[2];
                    FillInTables(coordinates, dataGridViews);
                    break;
            }
        }

        private void FillInTables(List<int> coordinates, params DataGridView[] dataGridViews)
        {
            // Перебор всех DataGridView и добавление их данных на один лист Excel
            foreach (DataGridView dataGridView in dataGridViews)
            {
                // Запись заголовков столбцов из DataGridView
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    worksheet.Cells[coordinates[0], i + coordinates[1]].Value = dataGridView.Columns[i].HeaderText;
                }

                // Запись данных из DataGridView
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        worksheet.Cells[i + coordinates[0] + 1, j + coordinates[1]].Value = dataGridView.Rows[i].Cells[j].Value;
                    }
                }

                // Добавить пустую строку между данными из разных DataGridView
                coordinates[1] += dataGridView.ColumnCount + 1;
            }          
            FillBorders("A5:C9");
            FillBorders("E5:F9");
            FillBorders("H5:I10");
            FillBorders("K5:L10");
            FillBorders("N5:O10");
            FillBorders("Q5:R10");
        }

        public void SaveReport()
        {
            // Сохранение файла
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Сохранение отчета",
                InitialDirectory = PathReport,
                FileName = "as02_отчет_по_калибровке_серийный_номер_" + SerialNumber
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                package.SaveAs(new FileInfo(saveFileDialog.FileName));
            }
        }

        public void CreateWorksheet()
        {
            worksheet = package.Workbook.Worksheets.Add("Результат калибровки");
            worksheet.Cells["A1"].Value = "Прибор DMC-AS02 серийный номер " + SerialNumber;
            worksheet.Cells["A2"].Value = $"Дата и время проведения калибровки:  {DateTime.Now.ToString("dd MMMM yyyy HH:mm")}";
            worksheet.Cells["A12"].Value = "Калибровку выполнил: " + Executor;
            worksheet.Cells["A4"].Value = "Калибровка по напряжению";
            worksheet.Cells["E4"].Value = "Калибровка по току";
            worksheet.Cells["H4"].Value = "Аналоговый выход 1";
            worksheet.Cells["K4"].Value = "Аналоговый выход 2";
            worksheet.Cells["N4"].Value = "Аналоговый выход 3";
            worksheet.Cells["Q4"].Value = "Аналоговый выход 4";
        }

        public void FillBorders(string rangeOfCells)
        {
            ExcelRange range = worksheet.Cells[rangeOfCells];
            range.Style.Border.Top.Style = ExcelBorderStyle.Medium;
            range.Style.Border.Top.Color.SetColor(System.Drawing.Color.Black);
            range.Style.Border.Left.Style = ExcelBorderStyle.Medium;
            range.Style.Border.Left.Color.SetColor(System.Drawing.Color.Black);
            range.Style.Border.Right.Style = ExcelBorderStyle.Medium;
            range.Style.Border.Right.Color.SetColor(System.Drawing.Color.Black);
            range.Style.Border.Bottom.Style = ExcelBorderStyle.Medium;
            range.Style.Border.Bottom.Color.SetColor(System.Drawing.Color.Black);
            range.AutoFitColumns();
        }
    }
}

