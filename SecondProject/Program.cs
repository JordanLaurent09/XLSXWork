using OfficeOpenXml;

namespace SecondProject
{
    /*currentSheet.Cells["A1"].Formula = "...";
     * 1-я формула: SUM(B1:F1) - формула для поиска суммы
     * 2-я формула: AVERAGE(A1:C3) - формула для среднего арифметического
     * 3-я формула: COUNT() - подсчет чисел
     */

    // текущийЛист.Cells[1,1].Address;
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Good> goods = new List<Good>()
            {
                new Good("Картошка", 123, "Вкусная и сладкая", 200, 5, 25, new DateTime(2023, 11, 12), "Артур Артуров", "Очень хорошие картофелины!!!", 100),
                new Good("Огурцы", 111, "Соленые, красивые, зеленые", 2000, 10, 42, new DateTime(2023, 11, 13), "Дима Димовский", "Глупец!Огурцы?!", 500),
                new Good("Блинчики", 777, "Блины с сыром и ветчиной", 400, 20, 100, new DateTime(2023, 11, 14), "Блин Блиновский", "Лучшие блинчики на всей планете", 50)

            };


            ExcelPackage newBook = new ExcelPackage("Warehouse.xlsx");
            ExcelWorksheet currentSheet = newBook.Workbook.Worksheets["Goods"];

            //newBook.Save();

            currentSheet.Cells["A1"].Value = "Название товара";
            currentSheet.Cells["B1"].Value = "Код товара";
            currentSheet.Cells["C1"].Value = "Описание товара";
            currentSheet.Cells["D1"].Value = "Количество в наличии";
            currentSheet.Cells["E1"].Value = "Себестоимость единицы товара";
            currentSheet.Cells["F1"].Value = "Общая стоимость";
            currentSheet.Cells["G1"].Value = "Цена продажи";
            currentSheet.Cells["H1"].Value = "Остаток в деньгах";
            currentSheet.Cells["I1"].Value = "Дата поступления";
            currentSheet.Cells["J1"].Value = "Поставщик";
            currentSheet.Cells["K1"].Value = "Примечания товара";
            currentSheet.Cells["L1"].Value = "Минимальный запас";

            currentSheet.Cells["A1:L1"].AutoFitColumns();

            for (int i = 0; i < goods.Count; i++)
            {
                currentSheet.Cells["A" + (i + 2)].Value = goods[i].Name;
                currentSheet.Cells["B" + (i + 2)].Value = goods[i].Code;
                currentSheet.Cells["C" + (i + 2)].Value = goods[i].Description;
                currentSheet.Cells["D" + (i + 2)].Value = goods[i].CurrentAmount;
                currentSheet.Cells["E" + (i + 2)].Value = goods[i].SelfPrice;
                string currAmAddress = currentSheet.Cells[i, i].Address;
                string selfPrAddress = currentSheet.Cells[i, i].Address;
                currentSheet.Cells["F" + (i + 2)].Formula = "SUM(currAmAddress:selfPrAddress)";
                
            }

            //Random random = new Random();
            //currentSheet.Columns.Width = 50;
            //for (int i = 0; i < 10; i++)
            //{
            //    for(int j = 0; j < 5; j++)
            //    {                    
            //        currentSheet.Cells[i + 1, j + 1].Value = $"Значение {random.Next(50)}";
            //    }
            //}
            //currentSheet.Cells["F1"].Formula = "VLOOKUP(F2, B1:E5, 2, FALSE)";

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

    class Good
    {       
        public string Name { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public int CurrentAmount { get; set; }
        public double SelfPrice { get; set; }       
        public double SellPrice { get; set; }
        
        public DateTime ReceiveDate { get; set; }
        public string TradeAgent { get; set; }
        public string Comments { get; set; }
        public int MinimalAmount { get; set; }

        public Good(string name, int code, string description, int currentAmount, double selfPrice, double sellPrice, DateTime receiveDate, string tradeAgent, string comments, int minimalAmount)
        {
            Name = name;
            Code = code;
            Description = description;
            CurrentAmount = currentAmount;
            SelfPrice = selfPrice;            
            SellPrice = sellPrice;           
            ReceiveDate = receiveDate;
            TradeAgent = tradeAgent;
            Comments = comments;
            MinimalAmount = minimalAmount;
        }
    }
}