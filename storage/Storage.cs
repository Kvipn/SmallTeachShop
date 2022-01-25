using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTeachShop
{
    internal static class Storage
    {
        static List<Goods> goodsList = new List<Goods>();        
        
        static public void addGoods(Goods goods)
        {
            goodsList.Add(goods);
        }
        static public void addListGoods(List<Goods> goods)
        {
            goodsList.AddRange(goods);
        }
        static public void deleteGoods(Goods goods)
        {
            Console.WriteLine( goodsList.Remove(goods));
        }

        static public void Show()
        {
            foreach (var item in goodsList)
            {
                item.show();
            }
        }
    }
}
