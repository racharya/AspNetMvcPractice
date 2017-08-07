using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
  public class RouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
      routes.MapRoute(
        name: "RandomMovies", 
        url: "Movies/Random",
        defaults: new {controller = "Movies", action = "Random"}
      );
      routes.MapRoute(
          // 2nd part is url pattern which calls controller.action() if no id supplied
          // controller.action(id) if id is supplied
          name: "Default",
          url: "{controller}/{action}/{id}",
          // if url does not contain any of the url pattern, Home is called
          // if url has only controller, it will call the controller.index
          // e.g if url is /movies ==> MoviesController.Index()
          defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
      );
    }
  }
}
