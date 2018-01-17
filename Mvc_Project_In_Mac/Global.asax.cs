using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mvc_Project_In_Mac
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
