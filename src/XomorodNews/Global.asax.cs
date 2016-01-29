using System;
using System.IO;
using System.Web.Http;
using System.Web.Routing;
using AdoManager;

namespace XomorodNews
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register); // Register WebAPI Routes
            RouteConfig.RegisterRoutes(RouteTable.Routes); // Register Pages Routes

            // Set Database Connetion from [Web.config]
            var data = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Web.config");
            ConnectionManager.LoadFromXml(data);
            ConnectionManager.SetToDefaultConnection("Xomorod");
        }
    }
}
