using System;
using FirstRow.App_Start;
using System.Web.Routing;

namespace FirstRow
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}