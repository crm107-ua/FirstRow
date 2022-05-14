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
    public partial class Seccion_Galeria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Route myRoute = RouteData.Route as Route;
            if (myRoute != null && myRoute.Url == "galeria/{pais}/{slug}")
            {
                ENGaleria galeria = new ENGaleria();
                pais.Text = char.ToUpper(RouteData.Values["pais"].ToString()[0])+ RouteData.Values["pais"].ToString().Substring(1);
                galeria.Slug = RouteData.Values["pais"].ToString()+"/"+RouteData.Values["slug"].ToString();

                if (galeria.readGaleria())
                {
                    title.Text = galeria.Titulo;
                    Descripcion.Text = galeria.Descripcion;
                    loadImg(galeria.Imagenes);
                }
                else 
                {
                    //No deberia pasar
                    Response.Redirect("/galeria");
                }
            }
        }
        private void loadImg(List<ENImagenes> imagenes) 
        {
            foreach (ENImagenes imagen in imagenes) 
            {
                HyperLink imagen_refence = new HyperLink();
                imagen_refence.CssClass = "image-item";
                imagen_refence.NavigateUrl = "../Media/Galery/" + imagen.Name;

                HtmlGenericControl imagen_muestra = new HtmlGenericControl("img");
                imagen_muestra.Attributes.Add("src", "/Media/Galery/" + imagen.Name);

                imagen_refence.Controls.Add(imagen_muestra);
                addImg.Controls.Add(imagen_refence);
            }
        }
    }
}