using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Products
{
    internal class Burger : Product
    {
        public string Ingredient { get; private set; }
        public Burger(string name, int price, string manufacturer, string ingredient)
        {   
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            Ingredient = ingredient;
        }
    }
}
