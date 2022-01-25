using System;
using System.Collections.Generic;
using SmallTeachShop;

namespace main
{
    class Program
    {
        public static void Main()
        {
            Storage.addGoods(new Beverage("Test","Test",10));
            Storage.addGoods(new ChocolatBar("Test","Test",10));
            Storage.addGoods(new Beverage("Test","Test",10));
            List<Goods> list = new List<Goods>()
            {
                new ChocolatBar("Snikers","Pepsico",20),
                new ChocolatBar("Snikers","Pepsico",20),
                new ChocolatBar("Snikers","Pepsico",20)
            };

            

            Storage.addListGoods(list);
            Storage.Show();
        }
    }
}