using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

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
            foreach(var item in temp)
            {
                Console.WriteLine($"{item.ProductName} {item.ReceiverName} {item.DateOfReceive}");
            }
        }
    }
}
