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
        // Кто выполнил калибровку
        public string Executor { get; set; }
        private ExcelPackage package = null;
        private ExcelWorksheet worksheet;
        //Начальные координаты таблиц
        public List<List<int>> StartCoordinates { get; set; } = new List<List<int>>
        {
        new List<int> { 5, 1 }, // Начальные координаты для DataGridViewVoltage
        new List<int> { 5, 5 }, // Начальные координаты для DataGridViewCurrent
        new List<int> { 5, 9 },  // Начальные координаты для DataGridViewAnalogOutput1
        };

         public ReportGeneration(string serialNumber, string executor)
        {
            Environment.SetEnvironmentVariable("EPPlusLicenseContext", "NonCommercial");
            package = new ExcelPackage();           
            SerialNumber = serialNumber;
            Executor = executor;
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
            FillBorders("E5:G9");
            FillBorders("I5:K9");
            FillBorders("M5:O9");
            FillBorders("Q5:S9");
            FillBorders("U5:W9");
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

        public void CreateWorksheet()
        {
            worksheet = package.Workbook.Worksheets.Add("Результат калибровки");
            worksheet.Cells[1, 1].Value = "Прибор DMC-AS02 серийный номер " + SerialNumber;
            worksheet.Cells[2, 1].Value = $"Дата и время проведения калибровки:  {DateTime.Now.ToString("dd MMMM yyyy HH:mm")}";
            worksheet.Cells[12, 1].Value = "Калибровку выполнил " + Executor;
            worksheet.Cells[4, 1].Value = "Калибровка по напряжению";
            worksheet.Cells[4, 5].Value = "Калибровка по току";
            worksheet.Cells[4, 9].Value = "Аналоговый выход 1";
            worksheet.Cells[4, 13].Value = "Аналоговый выход 2";
            worksheet.Cells[4, 17].Value = "Аналоговый выход 3";
            worksheet.Cells[4, 21].Value = "Аналоговый выход 4";
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
            worksheet.Cells.AutoFitColumns();
        }
    }
}


//public void ExportToExcel(params DataGridView[] dataGridViews)
//{
//    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("CombinedData");
//    int startRow = 1;

//    // Перебор всех DataGridView и добавление их данных на один лист Excel
//    foreach (DataGridView dataGridView in dataGridViews)
//    {
//        // Запись заголовков столбцов из DataGridView
//        for (int i = 0; i < dataGridView.ColumnCount; i++)
//        {
//            worksheet.Cells[startRow, i + 1].Value = dataGridView.Columns[i].HeaderText;
//        }

//        // Запись данных из DataGridView
//        for (int i = 0; i < dataGridView.RowCount; i++)
//        {
//            for (int j = 0; j < dataGridView.ColumnCount; j++)
//            {
//                worksheet.Cells[i + startRow + 1, j + 1].Value = dataGridView.Rows[i].Cells[j].Value;
//            }
//        }

//        // Добавить пустую строку между данными из разных DataGridView
//        startRow += dataGridView.RowCount + 1;
//    }

//    worksheet.Cells.AutoFitColumns();
//}