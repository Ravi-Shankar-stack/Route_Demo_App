using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routr_Demo_App
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    name: "Index",
            //    url: "{Employees}/{Index}/{EmpLocation}",
            //    defaults: new { controller = "Employees", action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index"}
            );

            Route rp2 = new Route("{controller}/{action}/{EmpLocation}", new MvcRouteHandler());
            routes.Add("route2", rp2);
        }
    }
}
