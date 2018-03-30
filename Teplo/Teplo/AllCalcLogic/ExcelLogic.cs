using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace Teplo.AllCalcLogic
{
    public class ExcelLogic
    {
        private Application application = null;
        private Workbook workbook = null;
        private Worksheet worksheet = null;        
        string template = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "template.xlsx");

        public void Save(ObservableCollection<ResClass> resClasses)
        {
            Open();            
            CreateHeader(worksheet);
            InsertData(resClasses, worksheet);
            Close();
        }

        private void Open()
        {
            application = new Application { DisplayAlerts = false };
            workbook = application.Workbooks.Open(template);
            worksheet = workbook.Sheets["Sheet"];
        }

        private void CreateHeader(Worksheet worksheet)
        {
            worksheet.Cells[1, 1] = "q паропровода";
            worksheet.Cells[1, 2] = "D паропровода";
            worksheet.Cells[1, 3] = "Длина участка";
            worksheet.Cells[1, 4] = "Q пара";
            worksheet.Cells[1, 5] = "q конденсатопровода";
            worksheet.Cells[1, 6] = "D конденсатопровода";
            worksheet.Cells[1, 7] = "Q конденсатопровода";
            worksheet.Cells[1, 8] = "Часовые среднегодовые Q паропровода";
            worksheet.Cells[1, 9] = "Часовые среднегодовые Q конденсатопровода";
            worksheet.Cells[1, 10] = "Примечание";
        }

        private void InsertData(ObservableCollection<ResClass> resClasses, Worksheet worksheet)
        {            
            foreach (var item in resClasses)
            {
                for (int i = 0; i < resClasses.Count; i++)
                {
                    worksheet.Cells[i + 2, 1] = item.Ql_S;
                    worksheet.Cells[i + 2, 2] = item.D_S;
                    worksheet.Cells[i + 2, 3] = item.L;
                    worksheet.Cells[i + 2, 4] = item.Qres_S;
                    worksheet.Cells[i + 2, 5] = item.Q_C;
                    worksheet.Cells[i + 2, 6] = item.D_C;
                    worksheet.Cells[i + 2, 7] = item.Qres_C;
                    worksheet.Cells[i + 2, 8] = item.Qh_y_S;
                    worksheet.Cells[i + 2, 9] = item.Qh_y_C;
                    worksheet.Cells[i + 2, 10] = item.Note;
                }
            }
        }

        private void Close()
        {            
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Отчет.xlsx");            
            workbook.SaveAs(path);
            application.Quit();
        }
    }
}
