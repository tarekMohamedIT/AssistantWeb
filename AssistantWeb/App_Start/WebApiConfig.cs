using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AssistantWeb
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "MoneyApi",
                routeTemplate: "api/{type}/{controller}/{id}",
                defaults: new { type = "money", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
