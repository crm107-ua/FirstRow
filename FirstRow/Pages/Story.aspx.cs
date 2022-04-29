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
        const string example_img = "https://img5.goodfon.com/wallpaper/nbig/5/d9/italiia-gorod-poberezhe-riomadzhore-doma-zdaniia-vecher-more.jpg";

        string pais_name = "";
        int pais_id = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            Route myRoute = RouteData.Route as Route;
            if (myRoute != null && myRoute.Url == "story/{slug}")
            {
                string cadena = char.ToUpper(RouteData.Values["slug"].ToString()[0]) + RouteData.Values["slug"].ToString().Substring(1);
                Session["story_pais"] = cadena.Replace("-", " ");
                pais_name = (string)Session["story_pais"];
                ENPais pais = new ENPais();
                if (pais.ReadPais(pais))
                {
                    pais_id = pais.id; //¿?
                }
                country_span.InnerText = pais_name;
            }

            story_panel.BackImageUrl = example_img;
            story_panel.Attributes["data-blur-bg"] = example_img;
            firstStory(sender, e); //¿?
        }

        protected void crearStorie(object sender, EventArgs e)
        {
            //COMPLETAR -- redirigir a formulario??
        }

        protected void modificarStorie(object sender, EventArgs e)
        {
            //COMPLETAR -- redirigir a formulario??
        }

        protected void verUsuario(object sender, EventArgs e)
        {
            //COMPLETAR
        }

        protected void eliminarStorie(object sender, EventArgs e)
        {
            //COMPLETAR
        }

        protected void nextStory(object sender, EventArgs e)
        {
            //ENStories story = new ENStories();
            //authorLabel.Text = "";
            //COMPLETAR
        }

        protected void prevStory(object sender, EventArgs e)
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
        protected void firstStory(object sender, EventArgs e) 
        {
            ENStories story = new ENStories();
            ENPais pais = new ENPais();
            pais.name = pais_name;
            story.Pais = pais_id;

            if (story.ReadFirstStory())
            {
                //mostrar la story en la página
                Panel p = createStoryPanel(story.Titulo, story.Descripcion);
                stories_items.Controls.Add(p);
                showStory(story);

            }
            else { showDefaultStory(); }
            
            //COMPLETAR
        }

        private void showStory(ENStories story)
        {
            
            //COMPLETAR
        }

        private void showDefaultStory()
        {
            Panel p = createStoryPanel("titulo de story", "descripcion de story");
            p.BackImageUrl = example_img;
            p.Attributes["data-blur-bg"] = example_img;
            stories_items.Controls.Add(p);
            //COMPLETAR
        }
    }
}