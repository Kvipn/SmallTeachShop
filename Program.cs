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

            goodsList.Add(AddElementGoodList());

            Storage.AddElementAssortment(goodsList[0],10);

            Storage.Show();
        }

        public static Goods AddElementGoodList()
        {
            IGoodsFactory[] goodsFactory = new IGoodsFactory[]
            {
                new BeverageFactory(),
                new ChocolatBarFactory(),
                new SnackFactory()
            };

            Console.WriteLine("1 - для добавления напитка\r\n2 - для добавления батончика\r\n3 - для добавления закуски");
            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1: return goodsFactory[choise-1].Create();
                case 2: return goodsFactory[choise - 2].Create();
                case 3: return goodsFactory[choise - 3].Create();
                default: return null;
            }

        }
    }
}