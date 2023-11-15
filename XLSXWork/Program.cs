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
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage newBook = new ExcelPackage("newTable.xlsx");
            ExcelWorksheet newWorkSheet = newBook.Workbook.Worksheets["Мой лист"];//newBook.Workbook.Worksheets.Add("Мой лист"); // добавление нового листа в книгу

            string[] arr = {"Ячейка1", "Ячейка2", "Ячейка3", "Ячейка4" };

            for(int i = 0; i < arr.Length; i++)
            {
                newWorkSheet.Cells[i + 1, 1].Value = arr[i];
            }

            string findingValue = "СкубиДу";

            int row = 0;
            int column = 0;

            foreach(var cell in newWorkSheet.Cells)
            {
                if(cell.Text == findingValue)
                {
                    Console.WriteLine("Совпадение найдено");

                    row = cell.Start.Row;
                    column = cell.Start.Column;
                }
            }

            Console.WriteLine($"Значение {findingValue} найдено в ячейке с координатами {row}:{column}");

            // заполнение ячеек
            //newWorkSheet.Cells["B5"].Value = "Эта девушка";
            //newWorkSheet.Cells["A7"].Value = "СкубиДу";
            //newWorkSheet.Cells["C3"].Value = "Ячейка да";
            //newWorkSheet.Cells["D2"].Value = "Ячейка нет";

            newBook.Save(); // Сохранение книги

            

            //ExcelWorksheet existingWorksheet = newBook.Workbook.Worksheets["Мой лист"]; // добавление к существующему листу

            //if(existingWorksheet != null )
            //{
            //    newBook.Workbook.Worksheets.Delete(existingWorksheet);
            //}

            //newBook.Workbook.Worksheets.Delete(newBook.Workbook.Worksheets["Мой лист"]); // удаление существующего листа

        }
    }
}