﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurant.Model
{

    /// <summary>
    /// 描述：Good 实体类
    /// </summary>
    public class Good
    {
        public int GoodID { get; set; }
        public string GoodName { get; set; }
        public decimal GoodPricesIn { get; set; }
        public string GoodSpullier { get; set; }
    }
}
