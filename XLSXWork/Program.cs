using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;
namespace XLSXWork
{
    // 1.Открыть Эксэль
    // 2. Сформировать книгу - лист
    // 3. Обращение к таблицам
    // Interop
    // EPPLUS Library устанавливается в проект


    // Работа: запустить приложение - сформировать книгу - сформировать лист - работаем с ячейками
    // Cell.Value - для записи
    // Cell.Text - для чтения
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; //  Позволяет использовать отладку
            ExcelPackage newBook = new ExcelPackage("newTable.xlsx");
            ExcelWorksheet newWorkSheet = newBook.Workbook.Worksheets["Мой лист"];//newBook.Workbook.Worksheets.Add("Мой лист"); // добавление нового листа в книгу

            string[] arr = {"Ячейка1", "Ячейка2", "Ячейка3", "Ячейка4" };

            for(int i = 0; i < arr.Length; i++)
            {
                newWorkSheet.Cells[i + 1, 1].Value = arr[i];
            }

            string findingValue = "СкубиДу";


            // Первый способ поиска координат ячейки
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

            // Второй способ поиска

            for(int i = 1; i < newWorkSheet.Rows.EndRow; i++)
            {
                for(int j = 1; j < newWorkSheet.Columns.EndColumn; j++)
                {
                    if (newWorkSheet.Cells[i, j].Text == findingValue)
                    {
                        Console.WriteLine($"Значение {findingValue} найдено в ячейке с координатами {i}-{j}");
                    }
                }
            }

            // заполнение ячеек
            //newWorkSheet.Cells["B5"].Value = "Эта девушка";
            //newWorkSheet.Cells["A7"].Value = "СкубиДу";
            //newWorkSheet.Cells["C3"].Value = "Ячейка да";
            //newWorkSheet.Cells["D2"].Value = "Ячейка нет";

            



            //ExcelWorksheet existingWorksheet = newBook.Workbook.Worksheets["Мой лист"]; // добавление к существующему листу

            //if(existingWorksheet != null )
            //{
            //    newBook.Workbook.Worksheets.Delete(existingWorksheet);
            //}

            //newBook.Workbook.Worksheets.Delete(newBook.Workbook.Worksheets["Мой лист"]); // удаление существующего листа



            // new List

            ExcelWorksheet currentSheet = newBook.Workbook.Worksheets["Стилизованный лист"];

            // Изменение параметров ячеек по диапазону

            currentSheet.Cells["A1:C10"].AutoFitColumns(); // Автовыравнивание столбцов

            currentSheet.Cells["A1:C1"].Merge = true; // Объединение ячеек

            currentSheet.Cells["A1"].Style.WrapText = true; // Перенос текста

            currentSheet.Cells["A1"].Value = "Какой-то текст"; // Запись текста в ячейку

            currentSheet.Cells["A1:C10"].Value = "Какой-то текст"; // Запись текста в диапазон

            currentSheet.Cells["A1:C10"].Style.Font.Size = 20; // Размер шрифта

            currentSheet.Cells["A1:C10"].Style.Font.Bold = true; // Жирный шрифт

            currentSheet.Cells["A1:C10"].Style.Font.Italic = true; // Курсивный шрифт 

            currentSheet.Cells["A1:C10"].Style.Font.Color.SetColor(Color.Red); // Цвет шрифта

            // Настройки заливки непосредственно ячеек

            currentSheet.Cells["A1:C10"].Style.Fill.PatternType = ExcelFillStyle.DarkGrid;
            currentSheet.Cells["A1:C10"].Style.Fill.BackgroundColor.SetColor(Color.Green);

            // Настройки границ ячеек
            currentSheet.Cells["A1:C10"].Style.Border.Top.Style = ExcelBorderStyle.Double;
            currentSheet.Cells["A1:C10"].Style.Border.Top.Color.SetColor(Color.Red);
            

            //currentSheet.Columns[1].Width = 50; // У конкретного столбцв
            //currentSheet.Columns.Width = 50; // У всех столбцов
            //currentSheet.Rows[1].Height = 50; // У конкретной строки



            

            //ExcelPackage calendarBook = new ExcelPackage("Calendar.xlsx");
            ExcelWorksheet calendarSheet = newBook.Workbook.Worksheets["Календарь"];

            for(int i = 1; i <= 12; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 1; j <= 30; j++)
                    {
                        calendarSheet.Cells[j, i].Value = j;
                    }
                }
                else
                {
                    for (int j = 1; j <= 31; j++)
                    {
                        calendarSheet.Cells[j, i].Value = j;
                    }
                }
            }

            newBook.Save(); // Сохранение книги

        }
    }
}