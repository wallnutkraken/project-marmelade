﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    static class G3Controller
    {
        /// <summary>
        /// Static productList which is to be loaded at the beginning of the program, to fill it with information from the database.
        /// </summary>
        public static List<Product> ProductList = new List<Product>();

        /// <summary>
        /// Static weeklyProductlist which is to be loaded at the beginning of the program, to fill it with information from the database.
        /// </summary>
        public static List<WeeklyProduct> WeeklyProductlist = new List<WeeklyProduct>();

        /// <summary>
        /// Static OrderList which is to be loaded at the beginning of the program, to fill it with information from the database.
        /// </summary>
        public static List<Order> OrdersList = new List<Order>();


        //#################################################################
        //Lists that will be loaded from database whenever the program runs.
        //etc. etc.
    }
}
