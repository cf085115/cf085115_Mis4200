﻿using System.Web;
using System.Web.Mvc;

namespace cf085115_Mis4200
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
