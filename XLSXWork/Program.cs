using OfficeOpenXml;
namespace XLSXWork
{
    // 1.Открыть Эксэль
    // 2. Сформировать книгу - лист
    // 3. Обращение к таблицам
    // Interop
    // EPPLUS Library устанавливается в проект


    // Работа: запустить приложение - сформировать книгу - сформировать лист - работаем с ячейками
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcelPackage newBook = new ExcelPackage("newTable.xlsx");
            ExcelWorksheet newWorkSheet = newBook.Workbook.Worksheets.Add("Мой лист"); // добавление нового листа в книгу

            newWorkSheet.Cells["B5"].Value = "Эта девушка";
            newWorkSheet.Cells["A7"].Value = "СкубиДу";
            newWorkSheet.Cells["C3"].Value = "Ячейка да";
            newWorkSheet.Cells["D2"].Value = "Ячейка нет";

            newBook.Save();

            //ExcelWorksheet existingWorksheet = newBook.Workbook.Worksheets["Мой лист"]; // добавление к существующему листу

            //if(existingWorksheet != null )
            //{
            //    newBook.Workbook.Worksheets.Delete(existingWorksheet);
            //}

            //newBook.Workbook.Worksheets.Delete(newBook.Workbook.Worksheets["Мой лист"]); // удаление существующего листа

        }
    }
}