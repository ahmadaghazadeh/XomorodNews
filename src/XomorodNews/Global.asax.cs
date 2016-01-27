using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace XomorodNews
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //GlobalConfiguration.Configure(WebApiConfig.Register);
            // https://msdn.microsoft.com/en-us/library/dd329551.aspx
            RegisterRoutes(RouteTable.Routes);
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            // ignore
            // The following code shows how to prevent routing from handling requests for .axd requests.
            routes.Add(new System.Web.Routing.Route("{resource}.axd/{*pathInfo}",
                new System.Web.Routing.StopRoutingHandler()));

            // localization routes e.g:  http://ZNews.Xomorod.com/en/
            routes.MapPageRoute("localRoutes",
                "{local}",
                "~/default.aspx", true,
                new RouteValueDictionary
                {
                    {"local", "en"},
                },
                new RouteValueDictionary
                {
                    {"local", "[a-z]{2}"},
                });

            // localization routes e.g:  http://ZNews.Xomorod.com/en/
            routes.MapPageRoute("IdRoute",
                "News/{title}",
                "~/pages/news.aspx", true,
                new RouteValueDictionary
                {
                    {"id", 0}
                },
                new RouteValueDictionary
                {
                    {"id", @"\d+"}
                });

            routes.MapPageRoute("ExpensesRoute",
                "{local}/News/{category}/{year}/{title}",
                "~/pages/news.aspx", true,
                new RouteValueDictionary
                {
                    {"local", "en"},
                    {"year", DateTime.Now.Year.ToString()}
                },
                new RouteValueDictionary
                {
                    {"local", "[a-z]{2}"},
                    {"year", @"\d{4}"}
                });

            routes.MapPageRoute("DateDetailedRoute",
                "{local}/News/{category}/{year}/{month}/{day}/{*extrainfo}",
                "~/pages/news.aspx", true,
                new RouteValueDictionary
                {
                    {"local", "en"},
                    {"category", "all" },
                    {"year", DateTime.Now.Year.ToString()},
                    {"month", DateTime.Now.Month.ToString()},
                    {"day", DateTime.Now.Day.ToString()}
                },
                new RouteValueDictionary
                {
                    {"local", "[a-z]{2}"},
                    {"year", @"\d{4}"},
                    {"month", @"\d{2}"},
                    {"day", @"\d{2}"}
                });

            // catch all route
            routes.MapPageRoute(
                "All Pages",
                "{*RequestedPage}",
                "~/pages/errors/404.aspx",
                true,
                new System.Web.Routing.RouteValueDictionary { { "RequestedPage", "home" } }
                );

        }
    }
}
