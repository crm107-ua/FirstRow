using System;
using library;
using System.Web.Routing;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace FirstRow.Pages
{
    public partial class Story : System.Web.UI.Page
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
                    pais_name = cadena.Replace("-", " ");
                    ENPais pais = new ENPais
                    {
                        name = pais_name
                    };
                    if (pais.ReadPais())
                    {
                        pais_id = pais.id;
                        if (Session["usuario"] != null)
                        {
                            crear_story.Visible = true;
                        }
                        else
                        {
                            crear_story.Visible = false;

                        }
                    }
                    country_span.InnerText = pais_name;
                    left_bottom_title.InnerText = pais_name;

                }

                loadStories();

                //default_story_panel.BackImageUrl = example_img;
                //default_story_panel.Attributes["data-blur-bg"] = example_img;

                //addDefaultStory();
                //firstStory(sender, e); //¿?

                //imagen por defecto (fondo plateado): https://img.freepik.com/vector-gratis/resumen-fondo-plateado-claro_67845-796.jpg

            }
        }

        /*
        protected void crearStory(object sender, EventArgs e)
        {
            //Response.Redirect("/agregar-story");
        }
        */
        /*
        protected void modificarStory(object sender, EventArgs e)
        {
            //COMPLETAR -- redirigir a formulario??
        }
        */

        protected void eliminarStory(object sender, EventArgs e)
        {
            //COMPLETAR
        }

        private Panel createStoryPanel(string title, string text, string user, string date)
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

            HyperLink autor = new HyperLink();
            autor.NavigateUrl = $"/user/{user}";
            autor.CssClass = "_text";
            autor.Style.Add("font-size", "15px");
            autor.Style.Add("color", "rgba(255, 255, 255, 0.61)");
            autor.Text = date + " by " + user;
            p.Controls.Add(autor);

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
                        addStory(story);
                    }

                }

            }
            else { addDefaultStory(); }
            

        }

        private void addDefaultStory()
        {
            ENStories story = new ENStories();
            story.Titulo = "titulo default";
            story.Descripcion = "descripcion default";
            ENUsuario user = new ENUsuario();
            user.nickname = "usuario default";
            story.Usuario = user;
            story.Imagen = default_img;
            addStory(story);
        }

        private void addStory(ENStories story)
        {
            Panel p = createStoryPanel(story.Titulo, story.Descripcion, story.Usuario.nickname, story.Fecha.ToString("dd.MM.yyyy"));
            if (story.Imagen == "")
            {
                p.BackImageUrl = default_img;
                p.Attributes["data-blur-bg"] = default_img;
                //h.Style.Add("background-image", $"url(../assets/img/default.jpg)");
            }
            else
            {
                try
                {
                    if (File.Exists(Server.MapPath($"~/Media/Stories/{story.Imagen}")))
                    {
                        //string img = Server.MapPath($"~/Media/Stories/{story.Imagen}");
                        string img = $"../Media/Stories/{story.Imagen}";
                        p.BackImageUrl = img;
                        p.Attributes["data-blur-bg"] = img;
                    
                    }
                    else
                    {
                        p.BackImageUrl = default_img;
                        p.Attributes["data-blur-bg"] = default_img;
                    }

                }catch(Exception)
                {
                    p.BackImageUrl = default_img;
                    p.Attributes["data-blur-bg"] = default_img;
                }
            }
            stories_items.Controls.Add(p);
        }

    }
}