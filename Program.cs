using System;
using System.Collections.Generic;
using SmallTeachShop;

namespace main
{
    class Program
    {
        public static void Main()
        {
            List<Goods> goodsList = new List<Goods>();
            goodsList.Add(new Snack("1","1",1));
            goodsList.Add(new Snack("1","1",1));
            Snack snack = new Snack("1", "1", 1);
            goodsList.Add(snack);
            goodsList.Remove(snack);
            goodsList.Remove(snack);
            goodsList.Remove(snack);

            foreach (var item in goodsList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}