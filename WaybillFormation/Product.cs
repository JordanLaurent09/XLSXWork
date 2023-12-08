using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaybillFormation
{
    public class Product:IComparable<Product>
    {
        [Name("Название товара")]
        public string ProductName { get; set; }

        [Name("Количество")]
        public int Amount { get; set; }
        [Name("Стоимость")]
        public decimal Price { get; set; }
        [Name("ФИО поставщика")]
        public string DealerName { get; set; }
        [Name("ФИО получателя")]
        public string ReceiverName { get; set; }
        [Name("Дата поставки")]
        public DateTime DateOfReceive { get; set; }


        public Product()
        {

        }

        public Product(string name, int amount, decimal price, string dealer, string receiver, DateTime dateOfReceive)
        {
            ProductName = name;
            Amount = amount;
            Price = price;
            DealerName = dealer;
            ReceiverName = receiver;
            DateOfReceive = dateOfReceive;
        }

        public  int CompareTo(Product product)
        {
            return DateOfReceive.CompareTo(product.DateOfReceive);
        }
    }
}
