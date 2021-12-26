using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Products
{
    internal class Lavash : Product
    {
        public string Ingredient { get; private set; }
        public Lavash(string name, int price, string manufacturer)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
        }
    }
}
