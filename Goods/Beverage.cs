using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTeachShop
{
    internal class Beverage : Goods
    {
        public Beverage(string titel, string manufacturer, decimal price)
        {
            Titel = titel;
            Manufacturer = manufacturer;
            Price = price;
        }

        public override string Titel { get; }
        public override string Manufacturer { get; }
        public override decimal Price { get; }        
    }
}
