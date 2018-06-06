using Southworks_TC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using Unity.Mvc5;

namespace Southworks_TC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            UnityMvc5.Start(); // <----- Add this line 

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public class UnityMvc5
        {
            public static void Start()
            {
                var container = BuildUnityContainer();
                DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            }

            private static IUnityContainer BuildUnityContainer()
            {
                var container = new UnityContainer();

                //register dependency injection.
                container.RegisterType<IEventService, EventService>();

                return container;
            }
        }
    }
}
