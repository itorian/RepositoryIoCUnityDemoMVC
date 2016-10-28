using RepositoryDemo.Web.App_Start;
using System.Web.Mvc;
using System.Web.Routing;

namespace RepositoryDemo.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // start unity
            UnityWebActivator.Start();
        }
    }
}
