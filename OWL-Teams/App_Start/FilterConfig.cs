﻿using System.Web;
using System.Web.Mvc;

namespace OWL_Teams
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
