﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTeachShop.GoodsFactory
{
    internal interface IGoodsFactory
    {
        Goods Create();
    }
}
