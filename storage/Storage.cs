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
        //static List<Beverage> beverageList = new List<Beverage>();
        //static List<ChocolatBar> chocolatList = new List<ChocolatBar>();
        //static List<Snack> snackList = new List<Snack>();        
        
        static public void addGoods(Goods goods)
        {
            goodsList.Add(goods);
        }
        static public void addListGoods(List<Goods> goods)
        {
            goodsList.AddRange(goods);
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
