using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MovieApp2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "BlogById",
                url: "blog/{entryId}",
                defaults: new { controller = "Blogs", action = "GetEntryById" },
                constraints: new { entryId = @"\d+" } // \d+ looks for
            );

            routes.MapRoute(
                name: "BlogByDate",
                url: "blog/{entryDate}",
                defaults: new { controller = "Blogs", action = "GetEntryByDate" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Movies", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
