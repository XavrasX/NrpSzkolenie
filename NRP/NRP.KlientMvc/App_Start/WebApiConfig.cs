using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NRP.WebApiDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //config.EnableCors();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "CalculatorApi",
                routeTemplate: "c/{left}/{action}/{right}",
                defaults: new { controller = "Calculator" }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
