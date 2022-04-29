using System.Web.Routing;

namespace FirstRow.App_Start
{
    public class RouteConfig
   {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("default", "", "~/Pages/Inicio.aspx");

            routes.MapPageRoute("experiencias", "experiencias", "~/Pages/Experiencias.aspx");
            routes.MapPageRoute("experiencia", "experiencia/{slug}", "~/Pages/Experiencia.aspx");
            
            routes.MapPageRoute("sorteos", "sorteos", "~/Pages/Sorteos.aspx");
            routes.MapPageRoute("sorteo", "sorteo/{slug}", "~/Pages/Sorteo.aspx");
             
            routes.MapPageRoute("stories", "stories", "~/Pages/Stories.aspx");
            routes.MapPageRoute("story", "story/{slug}", "~/Pages/Story.aspx");

            routes.MapPageRoute("wearing", "wearing/{slug}", "~/Pages/Wearing.aspx");

            routes.MapPageRoute("galeria", "galeria", "~/Pages/Galeria.aspx");
            routes.MapPageRoute("seccion_galeria", "galeria/{slug}", "~/Pages/Seccion_Galeria.aspx");

            routes.MapPageRoute("blogs", "blogs", "~/Pages/Blogs.aspx");
            routes.MapPageRoute("blogs_categoria", "blogs/{categoria}", "~/Pages/Blogs.aspx");
            routes.MapPageRoute("blog", "blog/{slug}", "~/Pages/Blog.aspx");

            routes.MapPageRoute("propuestas", "propuestas", "~/Pages/Propuestas.aspx");
            routes.MapPageRoute("propuesta", "propuesta/{slug}", "~/Pages/Propuesta.aspx");

            routes.MapPageRoute("equipo", "equipo", "~/Pages/Equipo.aspx");

            routes.MapPageRoute("contacto", "contacto", "~/Pages/Contacto.aspx");
        }
    }
}






