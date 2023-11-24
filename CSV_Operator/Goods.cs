using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Operator
{
    public class Goods:IComparable<Goods>
    {
        public string? Name { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public string? Description { get; set; }


        public int CompareTo(Goods goods)
        {
            return Price.CompareTo(goods.Price);
        }

    }
}
