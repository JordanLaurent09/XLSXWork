using OfficeOpenXml;

namespace SecondProject
{
    /*currentSheet.Cells["A1"].Formula = "...";
     * 1-я формула: SUM(B1:F1) - формула для поиска суммы
     * 2-я формула: AVERAGE(A1:C3) - формула для среднего арифметического
     * 3-я формула: COUNT() - подсчет чисел
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcelPackage newBook = new ExcelPackage("Formulas.xlsx");
            ExcelWorksheet currentSheet = newBook.Workbook.Worksheets.Add(Console.ReadLine());

            Random random = new Random();
            currentSheet.Columns.Width = 50;
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 5; j++)
                {                    
                    currentSheet.Cells[i + 1, j + 1].Value = $"Значение {random.Next(50)}";
                }
            }
            currentSheet.Cells["F1"].Formula = "VLOOKUP(F2, B1:E5, 2, FALSE)";

            // Некоторые полезные формулы
            //currentSheet.Cells["A1"].Value = 30;
            //currentSheet.Cells["A2"].Value = 45;
            //currentSheet.Cells["A3"].Value = 70;

            //currentSheet.Cells["B1"].Value = 15;
            //currentSheet.Cells["B2"].Value = 25;
            //currentSheet.Cells["B3"].Value = 30;

            //currentSheet.Cells["C1"].Formula = "SUM(A1:B1)";
            //currentSheet.Cells["C2"].Formula = "SUM(A2:B2)";
            //currentSheet.Cells["C3"].Formula = "SUM(A3:B3)";

            //currentSheet.Cells["A5"].Formula = "AVERAGE(A1:C3)";

            //currentSheet.Cells["B5"].Formula = "COUNT(A1:C3)";

            //currentSheet.Cells["A4"].Formula = "MAX(A1:A3)";
            //currentSheet.Cells["B4"].Formula = "MAX(B1:B3)";

            //currentSheet.Cells["A6"].Formula = "MIN(A1:A3)";
            //currentSheet.Cells["B6"].Formula = "MIN(B1:B3)";

            newBook.Save();













            // Доделаю позже
            //int[,] numbers = new int[10,10];

            //for(int y = 0; y < 10; y++)
            //{
            //    for(int x = 0; x < 10; x++)
            //    {
            //        numbers[y, x] = (y + 1) * (x + 1);
            //        Console.Write(numbers[y, x] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //ExcelPackage newBook = new ExcelPackage("Mathematics.xlsx");
            //ExcelWorksheet newWorkSheet = newBook.Workbook.Worksheets.Add("PifagorTable(Multiplication)"); // После отработки команды закомментировать






            //newBook.Save();  // Обязательная команда для создания эксэль-файла
        }
    }
}