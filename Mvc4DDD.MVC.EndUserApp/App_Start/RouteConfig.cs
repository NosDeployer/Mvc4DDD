using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mvc4DDD.MVC.EndUserApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "WhereRoute",
                url: "Companies/Where/{location}",
                defaults: new {controller = "Companies", action = "Where", location = UrlParameter.Optional}
                );

            routes.MapRoute(
               name: "CategoryRoute",
               url: "Companies/What/{categoryId}/{categorySeo}",
               defaults: new { controller = "Companies", action = "What", categoryId = UrlParameter.Optional, categorySeo = UrlParameter.Optional }
               );

            routes.MapRoute(
                name: "NamedCompany",
                url: "{controller}/{action}/{id}/{seoName}",
                defaults:
                    new {controller = "Companies", action = "Index", id = @"^\d+$", seoName = UrlParameter.Optional}
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "Companies", action = "Index", id = UrlParameter.Optional}
                );
        }
    }
}