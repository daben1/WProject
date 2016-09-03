using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rabbit.Web;
using Rabbit.Web.Routes;

namespace WebApplication2
{
    public class Routes : IRouteProvider
    {
        public void GetRoutes(ICollection<RouteDescriptor> routes)
        {
            routes.MapRabbitRoute("Demo1", "WebApplication2", "Home", "Index");
        }
    }
}