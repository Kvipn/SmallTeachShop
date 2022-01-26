using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTeachShop
{
    internal class Snack : Goods
    {
        public Snack(string titel, double price)
        {
            Titel = titel;
            Price = price;
        }

        public override string Titel { get; }
        public override double Price { get; }
    }
}
