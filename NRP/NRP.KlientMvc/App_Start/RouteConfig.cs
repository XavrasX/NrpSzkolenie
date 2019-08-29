using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NRP.KlientMvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "odp",
                url: "odp/{viewName}",
                defaults: new { controller = "Odpowiedzi", action = "Index", viewName = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "OCD",
                url: "ocd/{nr}",
                defaults: new { controller = "Home", action = "NeverDoLikeThis" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
