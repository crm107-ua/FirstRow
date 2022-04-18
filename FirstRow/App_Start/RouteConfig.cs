using System.Web.Routing;

namespace FirstRow.App_Start
{
    public class RouteConfig
   {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("default", "", "~/Pages/Inicio.aspx");
            routes.MapPageRoute("experiencias", "experiencias", "~/Pages/Experiencias.aspx");
            routes.MapPageRoute("experiencia", "experiencias/{slug}", "~/Pages/Experiencias.aspx");
        }
    }
}