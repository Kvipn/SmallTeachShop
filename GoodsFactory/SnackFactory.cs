using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTeachShop
{
    internal class SnackFactory : IGoodsFactory
    {
        public Goods Create()
        {
            Console.WriteLine("Введите название: ");
            string titel = Console.ReadLine();
            Console.WriteLine("Введите стоимость: ");
            double price = double.Parse(Console.ReadLine());
            return new Snack(titel, price);
        }
    }
}
