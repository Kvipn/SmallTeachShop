using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTeachShop
{
    abstract internal class Goods
    {
        abstract public string Titel { get; }
        abstract public string Manufacturer { get; }
        abstract public decimal Price { get; }
    }
}
