using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Products
{
    internal class Hot_Dog: Product
    {
        public Hot_Dog(string name, int price, string manufacturer)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
        }
    }
}
