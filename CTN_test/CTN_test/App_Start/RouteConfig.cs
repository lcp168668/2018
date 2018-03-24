using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CTN_test
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "index1",
                url: "{controller}/{action}.html"
                );
            routes.MapRoute(
                name: "index2",
                url: "{controller}/{action}/{id}.html"
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "index", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
