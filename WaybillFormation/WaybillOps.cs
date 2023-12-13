using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using Word = Microsoft.Office.Interop.Word;


namespace WaybillFormation
{
    public static class WaybillOps
    {
        public static void FormWaybill(List<Product> data)
        {
            Dictionary<string, List<Product>> compliances = new Dictionary<string, List<Product>>();
            HashSet<DateTime> dates = new HashSet<DateTime>();

            foreach (Product item in data)
            {
                dates.Add(item.DateOfReceive);
                if (compliances.ContainsKey(item.ReceiverName))
                {
                    compliances[item.ReceiverName].Add(item);
                }
                else
                {
                    compliances.Add(item.ReceiverName, new List<Product>());
                }
            }

            List<Product> _unique = new List<Product>();

            foreach (var item in compliances)
            {
                foreach (var date in dates)
                {
                    foreach (var product in data)
                    {
                        if (product.ReceiverName == item.Key && product.DateOfReceive == date)
                        {
                            _unique.Add(product);
                        }
                    }
                    WriteWaybill(_unique);
                    _unique.Clear();
                }
            }
        }

        public static void WriteWaybill(List<Product> temp)
        {
            Random random = new Random();

            Word.Application wordApp = new Word.Application();

            Word.Document wordDoc = wordApp.Documents.Open($"{Directory.GetCurrentDirectory()}\\Товарная накладная.docx");

            try 
            {
                string fileName = $"{Directory.GetCurrentDirectory()}\\Накладная от {temp[0].DateOfReceive.Year}.{temp[0].DateOfReceive.Month}.{temp[0].DateOfReceive.Day}. Покупатель - {temp[0].ReceiverName}.docx";

                wordDoc.SaveAs(fileName);
                wordDoc.Close();

                wordDoc = wordApp.Documents.Open(fileName);

                wordDoc.Content.Find.Execute("номер", ReplaceWith: $"{random.Next(100000, 120000)}");
                wordDoc.Content.Find.Execute("дата", ReplaceWith: $"{temp[0].DateOfReceive.ToShortDateString()}");
                wordDoc.Content.Find.Execute("ФИО поставщика", ReplaceWith: $"{temp[0].DealerName}");
                wordDoc.Content.Find.Execute("ФИО покупателя", ReplaceWith: $"{temp[0].ReceiverName}");
                wordDoc.Content.Find.Execute("<адрес доставки>", ReplaceWith: $"{temp[0].ReceiverName}");

                Word.Table table = wordDoc.Tables[1];

                int totalMoney = 0;

                // Заполнение ячеек таблицы
                for (int i = 1; i <= temp.Count; i++)
                {
                    table.Rows.Add();
                    table.Cell(i + 1, 1).Range.Text = i.ToString();
                    table.Cell(i + 1, 2).Range.Text = temp[i - 1].ProductName;
                    table.Cell(i + 1, 3).Range.Text = temp[i - 1].Amount.ToString();
                    table.Cell(i + 1, 4).Range.Text = temp[i - 1].Price.ToString();

                    int total = (int) temp[i - 1].Price * temp[i - 1].Amount;

                    table.Cell(i + 1, 5).Range.Text = total.ToString();

                    totalMoney += total;
                }

                wordDoc.Content.Find.Execute("Сумма итого", ReplaceWith: $"{totalMoney}");
                wordDoc.Content.Find.Execute("сумма итого", ReplaceWith: $"{totalMoney}");
                wordDoc.Content.Find.Execute("кол-во", ReplaceWith: $"{temp.Count}");

                wordDoc.SaveAs(fileName);
                Console.WriteLine($"Документ: {fileName} успешно создан");

            }
            catch(Exception e)
            {

            }
            finally
            {
                wordDoc.Close();
                wordApp.Quit();
            }
        }
    }
}
