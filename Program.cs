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

            Storage.AddElementAssortment(new Snack("Pringls", 5.5), 12);
            Storage.DeleteElementAssortment(new Snack(" ", 1));
            Storage.Show();
        }

        public static void AddElementGoodList()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "Beverage": break;
                case "Snack": break;
                case "ChocolatBar": break;
                default: break;
            }

        }
    }
}