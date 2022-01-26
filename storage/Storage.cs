using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTeachShop
{
    internal static class Storage
    {
        static Dictionary<Goods, int> assortment = new Dictionary<Goods, int>();
        static public void AddElementAssortment(Goods goods, int count)
        {
            assortment.Add(goods, count);
        }
        static public void DeleteElementAssortment(Goods goods)
        {
            
        }

        //static private bool CheckMethod(Goods goods)
        //{
        //    foreach ( var item in assortment)
        //    {
        //        if(item.Key.Titel == goods.Titel && item.Key.Price==goods.Price)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        static public void Show()
        {
            foreach (var item in assortment)
            {
                Console.WriteLine($"{item.Key.ToString()} - {item.Value}");
            }
        }
    }
}
