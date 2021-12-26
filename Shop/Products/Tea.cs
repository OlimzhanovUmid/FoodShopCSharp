using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Products
{
    internal class Tea: Product
    {
        public string Type { get; private set; }
        public Tea(string name, int price, string manufacturer, string type)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            Type = type;
        }
    }
}
