using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FirstRow.Pages
{
    public partial class Experiencia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Route myRoute = RouteData.Route as Route;
            if (myRoute != null && myRoute.Url == "experiencia/{slug}")
            {
                ENViajes experiencia = new ENViajes();
                experiencia.Slug = RouteData.Values["slug"].ToString();
                if (experiencia.mostrarExperiencia())
                {
                    slug.Text = experiencia.Titulo;
                    bg_experiencia.Attributes.Add("style", "background-image: url(/Media/Experiencias/" + experiencia.Background + ")");
                    texto_pais.InnerText = experiencia.Pais.name;
                    texto_titulo.InnerText = experiencia.Titulo;

                    foreach (ENImagenes imagen in experiencia.Imagenes)
                    {
                        HyperLink a_tag_general = new HyperLink();
                        a_tag_general.NavigateUrl = "/Media/Experiencias/" + imagen.Name;
                        a_tag_general.Attributes.Add("class", "slide");

                        Image foto = new Image();
                        foto.ImageUrl = "/Media/Experiencias/" + imagen.Name;
                        foto.AlternateText = " ";
                        foto.Attributes.Add("data-src", foto.ImageUrl);
                        a_tag_general.Controls.Add(foto);
                        carga.Controls.Add(a_tag_general);
                    }
                }
                else
                {
                    Response.Redirect("/404");
                }
            }

        }

        protected void comentar(object sender, EventArgs e)
        {


        }


        protected void reserva(object sender, EventArgs e)
        {


        }

        protected void modificarExperiencia(object sender, EventArgs e)
        {


        }

        protected void eliminarComentario(object sender, EventArgs e)
        {


        }

        protected void eliminarExperiencia(object sender, EventArgs e)
        {


        }
    }
}