using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    interface Price
    {
        double Price { get; set; }
    }
    interface Name: Price
    {
        string Name { get; set; }
    }
    class Product: Name, Price
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }

    }
}
