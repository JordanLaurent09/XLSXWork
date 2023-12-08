namespace WaybillFormation
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = CSVWork.GetFromFile();
            
            List<Product> temp = new List<Product>();

            // Фильтрация одинаковых

            foreach(Product product in products)
            {
                bool isDataExists = false;

                for(int i = 0; i < temp.Count; i++)
                {
                    if (temp[i].ProductName == product.ProductName && temp[i].ReceiverName == product.ReceiverName && temp[i].DateOfReceive == product.DateOfReceive)
                    {
                        temp[i].Amount += product.Amount;
                        isDataExists = true;
                    }
                }
                if (!isDataExists)
                {
                    temp.Add(product);
                }
            }

            temp.Sort();
            //foreach (var item in temp)
            //{
            //    Console.WriteLine($"{item.ProductName} {item.DateOfReceive}");
            //}

            // ExcelWork.WriteToExcel(temp); Этот метод уже отработал

            List<Product> fromExcel = ExcelWork.GetData("Warehouse.xlsx");
            foreach(Product item in fromExcel)
            {
                Console.WriteLine($"{item.ProductName} {item.Amount} {item.Price} {item.DealerName} {item.ReceiverName} {item.DateOfReceive}");
            }
        }
    }
}