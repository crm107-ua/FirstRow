using System.Web.Routing;

namespace FirstRow.App_Start
{
    public class RouteConfig
   {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("default", "", "~/Pages/Inicio.aspx");
            routes.MapPageRoute("403", "403", "~/Pages/403.aspx");

            routes.MapPageRoute("perfil", "perfil", "~/Pages/Perfil.aspx");
            //routes.MapPageRoute("user", "user/{nickname}", "~/Pages/Perfil.aspx");

            routes.MapPageRoute("reservas", "reservas/{nickname}", "~/Pages/Reservas.aspx");

            routes.MapPageRoute("experiencias", "experiencias", "~/Pages/Experiencias.aspx");
            routes.MapPageRoute("experiencia", "experiencia/{slug}", "~/Pages/Experiencia.aspx");
            routes.MapPageRoute("agregar_experiencias", "agregar-experiencia", "~/Pages/Forms/FormExperiencia.aspx");

            routes.MapPageRoute("sorteos", "sorteos", "~/Pages/Sorteos.aspx");
            routes.MapPageRoute("sorteo", "sorteo/{slug}", "~/Pages/Sorteo.aspx");
             
            routes.MapPageRoute("stories", "stories", "~/Pages/Stories.aspx");
            routes.MapPageRoute("story", "story/{slug}", "~/Pages/Story.aspx");
            routes.MapPageRoute("agregar_story", "agregar-story", "~/Pages/Forms/FormStory.aspx");
            routes.MapPageRoute("user-stories", "user-stories/{nickname}", "~/Pages/StoryUsuario.aspx");

            routes.MapPageRoute("firstrow", "firstrow", "~/Pages/FirstRow.aspx");

            routes.MapPageRoute("galeria", "galeria", "~/Pages/Galeria.aspx");
            routes.MapPageRoute("filtrado_galeria", "galeria/{pais}", "~/Pages/Galeria.aspx");
            routes.MapPageRoute("seccion_galeria", "galeria/{pais}/{slug}", "~/Pages/Seccion_Galeria.aspx");
            routes.MapPageRoute("agregar_seccion_galeria", "agregar-seccion-galeria", "~/Pages/Forms/FormGaleria.aspx");

            routes.MapPageRoute("blogs", "blogs", "~/Pages/Blogs.aspx");
            routes.MapPageRoute("blogs_categoria", "blogs/{categoria}", "~/Pages/Blogs.aspx");
            routes.MapPageRoute("blog_categoria", "blog/{categoria}/{slug}", "~/Pages/Blog.aspx");
            routes.MapPageRoute("agregar_blog", "agregar-blog", "~/Pages/Forms/FormBlog.aspx");

            routes.MapPageRoute("propuestas", "propuestas", "~/Pages/Propuestas.aspx");
            routes.MapPageRoute("propuesta", "propuesta/{slug}", "~/Pages/Propuesta.aspx");

            routes.MapPageRoute("equipo", "equipo", "~/Pages/Equipo.aspx");

            routes.MapPageRoute("contacto", "contacto", "~/Pages/Contacto.aspx");
        }
    }
}






