using System;
using library;
using System.Web.Routing;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstRow.Pages
{
    public partial class Storie : System.Web.UI.Page
    {
        const string default_img = "https://img5.goodfon.com/wallpaper/nbig/5/d9/italiia-gorod-poberezhe-riomadzhore-doma-zdaniia-vecher-more.jpg";

        string pais_name = "";
        int pais_id = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Route myRoute = RouteData.Route as Route;
                if (myRoute != null && myRoute.Url == "story/{slug}")
                {
                    string cadena = char.ToUpper(RouteData.Values["slug"].ToString()[0]) + RouteData.Values["slug"].ToString().Substring(1);
                    Session["story_pais"] = cadena.Replace("-", " ");
                    pais_name = (string)Session["story_pais"];
                    ENPais pais = new ENPais();
                    pais.name = pais_name;
                    if (pais.ReadPais())
                    {
                        pais_id = pais.id; //¿?
                    }
                    country_span.InnerText = pais_name;
                }

                loadStories();

                //default_story_panel.BackImageUrl = example_img;
                //default_story_panel.Attributes["data-blur-bg"] = example_img;

                //addDefaultStory();
                //firstStory(sender, e); //¿?

                //imagen por defecto (fondo plateado): https://img.freepik.com/vector-gratis/resumen-fondo-plateado-claro_67845-796.jpg

            }
        }

        protected void crearStory(object sender, EventArgs e)
        {
            //COMPLETAR -- redirigir a formulario??
        }

        protected void modificarStory(object sender, EventArgs e)
        {
            //COMPLETAR -- redirigir a formulario??
        }

        protected void eliminarStory(object sender, EventArgs e)
        {
            //COMPLETAR
        }

        protected void verUsuario(object sender, EventArgs e)
        {
            //COMPLETAR
        }

        private Panel createStoryPanel(string title, string text)
        {
            Panel p = new Panel();
            p.CssClass = "item";

            
            Panel info = new Panel();
            info.CssClass = "_info";
            Panel country = new Panel();
            country.CssClass = "country";
            Label country_span = new Label();
            country_span.Text = pais_name;
            country.Controls.Add(country_span);
            info.Controls.Add(country);            
            p.Controls.Add(info);

            Label titulo = new Label();
            titulo.CssClass = "_title";
            titulo.Text = title;
            p.Controls.Add(titulo);

            Label texto = new Label();
            texto.CssClass = "_text";
            texto.Text = text;
            p.Controls.Add(texto);

            return p;
        }

        /**
         * probablemente no lo use
         * se me ocurre otra forma mejor de hacerlo
         * :)
         */
        /*
        protected void firstStory(object sender, EventArgs e) 
        {
            ENStories story = new ENStories();
            //ENPais pais = new ENPais();
            //pais.name = pais_name;
            story.Pais = pais_id;

            if (story.ReadFirstStory())
            {
                //mostrar la story en la página
                Panel p = createStoryPanel(story.Titulo, story.Descripcion);
                stories_items.Controls.Add(p);
                //showStory(story);

            }
            else { addDefaultStory(); }
            
            //COMPLETAR
        }*/

        private void loadStories()
        {

            List<ENStories> listStories = new List<ENStories>();
            if (ENStories.ReadAllStories(listStories, pais_id)) //, pais_id
            {
                if (listStories.Count == 0)
                {
                    addDefaultStory();
                }
                else
                {
                    foreach (ENStories story in listStories)
                    {
                        addStory(story.Titulo, story.Descripcion, story.Imagen);
                    }

                }

            }
            else { addDefaultStory(); }
            

        }

        private void addDefaultStory()
        {
            addStory("titulo default", "descripcion default", default_img);
        }

        private void addStory(string title, string desc, string img)
        {
            Panel p = createStoryPanel(title, desc);
            if (img == "")
            {
                p.BackImageUrl = default_img;
                p.Attributes["data-blur-bg"] = default_img;
            }
            else
            {
                p.BackImageUrl = img;
                p.Attributes["data-blur-bg"] = img;
            }
            stories_items.Controls.Add(p);
        }
    }
}