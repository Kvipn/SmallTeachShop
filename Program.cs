using System;
using System.Collections.Generic;
using SmallTeachShop;

namespace main
{
    class Program
    {
        public static void Main()
        {
            Dictionary<Goods,int> goods = new Dictionary<Goods,int>();
            Snack snack = new Snack("Pringls", "ASd", 2);
            goods.Add(snack, 10);
            goods[snack] += 1;
            foreach (var item in goods)
            {
                Console.WriteLine($"{item.Key.ToString()}, {item.Value}");
            }
        }
    }
}