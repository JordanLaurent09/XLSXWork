using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.DataValidation;

namespace WaybillFormation
{
    public static class ExcelWork
    {
        private static ExcelPackage newBook;
        private static ExcelWorksheet worksheet;

        // Метод для записывания данных в документ 
        public static void WriteToExcel(List<Product> products)
        {
            newBook = new ExcelPackage("Warehouse.xlsx");
            worksheet = newBook.Workbook.Worksheets.Add("timbers");

            worksheet.Cells["F1:F19"].Style.Numberformat.Format = "yyyy-MM-dd";
            

            for (int i = 0; i < products.Count; i++)
            {
                worksheet.Cells[i + 1, 1].Value = products[i].ProductName;
                worksheet.Cells[i + 1, 2].Value = products[i].Amount;
                worksheet.Cells[i + 1, 3].Value = products[i].Price;
                worksheet.Cells[i + 1, 4].Value = products[i].DealerName;
                worksheet.Cells[i + 1, 5].Value = products[i].ReceiverName;
                worksheet.Cells[i + 1, 6].Value = products[i].DateOfReceive;
            }
            worksheet.Cells["A1:F19"].AutoFitColumns();
            newBook.Save();
                
        }
        
        // Метод для считывания данных из документа
        public static List<Product> GetData(string excelFilePath)
        {
            List<Product> products = new List<Product>();
            newBook = new ExcelPackage(excelFilePath);
            worksheet = newBook.Workbook.Worksheets["timbers"];

            for(int i = 1; i < worksheet.Dimension.Rows; i++)
            {
                string productName = worksheet.Cells[i, 1].Text;
                int amount = int.Parse(worksheet.Cells[i, 2].Text);
                decimal price = decimal.Parse(worksheet.Cells[i, 3].Text);
                string dealer = worksheet.Cells[i, 4].Text;
                string receiver = worksheet.Cells[i, 5].Text;
                DateTime dateOfReceive = DateTime.Parse(worksheet.Cells[i, 6].Text);

                products.Add(new Product(productName, amount, price, dealer, receiver, dateOfReceive));
            }

            return products;
        }
    }
}
