using library;
using System;
using System.Collections.Generic;
using System.IO;
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
            if (!Page.IsPostBack)
            {
                delete_galeria.Visible = false;

                Route myRoute = RouteData.Route as Route;
                if (myRoute != null && myRoute.Url == "galeria/{pais}/{slug}")
                {
                    ENGaleria galeria = new ENGaleria();
                    pais.Text = char.ToUpper(RouteData.Values["pais"].ToString()[0]) + RouteData.Values["pais"].ToString().Substring(1);
                    galeria.Slug = RouteData.Values["pais"].ToString() + "/" + RouteData.Values["slug"].ToString();

                    if (galeria.readGaleria())
                    {
                        if (Session["usuario"] != null)
                        {
                            ENUsuario usuario = (ENUsuario)Session["usuario"];
                            if(usuario.nickname==galeria.Usuario.nickname)
                                delete_galeria.Visible = true;
                        }
                        title.Text = galeria.Titulo;
                        Descripcion.Text = galeria.Descripcion;
                        loadImg(galeria.Imagenes);
                        loadExtra();
                    }
                    else
                    {
                        //No deberia pasar
                        Response.Redirect("/galeria");
                    }

                    loadExpeciencia();
                }
            }
        }
        private void loadImg(List<ENImagenes> imagenes) 
        {
            foreach (ENImagenes imagen in imagenes) 
            {
                HyperLink imagen_refence = new HyperLink();
                imagen_refence.NavigateUrl ="/Media/Galery/" + imagen.Name;
                imagen_refence.Attributes.Add("class", "image-item");
                imagen_refence.Attributes.Add("style", "pointer-events: none;");

                HtmlGenericControl imagen_muestra = new HtmlGenericControl("img");
                imagen_muestra.Attributes.Add("src", "/Media/Galery/" + imagen.Name);

                imagen_refence.Controls.Add(imagen_muestra);
                addImg.Controls.Add(imagen_refence);
            }
        }

        private void loadExtra() 
        {
            List<ENGaleria> galerias = new List<ENGaleria>();
            CADGaleria cadGaleria = new CADGaleria();

            cadGaleria.readAllGaleri(galerias);
            ENGaleria galeria;
            Random random = new Random();

            if (galerias.Count >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    galeria = galerias[random.Next() % galerias.Count()];
                    HyperLink a_tag_general = new HyperLink();
                    a_tag_general.CssClass = "gallery-item";
                    a_tag_general.NavigateUrl = "/galeria/" + galeria.Slug;

                    HtmlGenericControl galeria_item_top = new HtmlGenericControl("div");
                    galeria_item_top.Attributes.Add("class", "top");

                    HtmlGenericControl country = new HtmlGenericControl("p");
                    country.Attributes.Add("class", "country");

                    HtmlGenericControl texto_pais = new HtmlGenericControl("span");
                    texto_pais.InnerText = galeria.Pais.name;

                    //<p class="title">Las preciosas aves de Australia</p>
                    HtmlGenericControl title = new HtmlGenericControl("p");
                    title.Attributes.Add("class", "title");

                    HtmlGenericControl title_text = new HtmlGenericControl("span");
                    title_text.InnerText = galeria.Titulo;

                    HtmlGenericControl imagenes = new HtmlGenericControl("div");
                    imagenes.Attributes.Add("class", "images");

                    HtmlGenericControl scrol_imagenes = new HtmlGenericControl("div");
                    scrol_imagenes.Attributes.Add("class", "scroll");

                    foreach (ENImagenes imagenGaleria in galeria.Imagenes)
                    {
                        HtmlGenericControl imagenes_galeria = new HtmlGenericControl("div");
                        imagenes_galeria.Attributes.Add("class", "img");

                        HtmlGenericControl imagen = new HtmlGenericControl("img");
                        imagen.Attributes.Add("src", "/Media/Galery/" + imagenGaleria.Name);

                        imagenes_galeria.Controls.Add(imagen);
                        scrol_imagenes.Controls.Add(imagenes_galeria);
                    }

                    country.Controls.Add(texto_pais);
                    title.Controls.Add(title_text);
                    galeria_item_top.Controls.Add(country);
                    galeria_item_top.Controls.Add(title);
                    imagenes.Controls.Add(scrol_imagenes);

                    a_tag_general.Controls.Add(galeria_item_top);
                    a_tag_general.Controls.Add(imagenes);

                    masGaleri.Controls.Add(a_tag_general);
                }
            }
        }

        protected void borradoGaleria(object sender, EventArgs e)
        {
            ENGaleria galeria = new ENGaleria();
            galeria.Slug = RouteData.Values["pais"].ToString() + "/" + RouteData.Values["slug"].ToString();
            
            if(galeria.readGaleria())
                if (galeria.deleteGaleria()) 
                {
                    foreach(ENImagenes imagen in galeria.Imagenes)
                        File.Delete(Server.MapPath("~/Media/Galery/" + Path.GetFileName(imagen.Name)));
                    Response.Redirect("/galeria");
                }
        }

        private void loadExpeciencia()
        {
            Random random = new Random();
            ENViajes ENexperiencia = new ENViajes();
            List<ENViajes> experiencias = new List<ENViajes>();
            ENexperiencia.mostrarExperiencias(experiencias);

            ENViajes experiencia = experiencias[random.Next() % experiencias.Count];
            

            HyperLink a_tag_general = new HyperLink();
            a_tag_general.CssClass = "tour_item";
            a_tag_general.NavigateUrl = "/experiencia/" + experiencia.Slug;
            a_tag_general.Attributes.Add("style", "background-image: url(/Media/Experiencias/" + experiencia.Background + ")");

            HtmlGenericControl tour_item_top = new HtmlGenericControl("div");
            tour_item_top.Attributes.Add("class", "tour_item_top");

            HtmlGenericControl country = new HtmlGenericControl("p");
            country.Attributes.Add("class", "country");

            HtmlGenericControl texto_pais = new HtmlGenericControl("span");
            texto_pais.InnerText = experiencia.Pais.name;

            HtmlGenericControl tour_item_bottom = new HtmlGenericControl("div");
            tour_item_bottom.Attributes.Add("class", "tour_item_bottom");

            HtmlGenericControl _title = new HtmlGenericControl("h3");
            _title.Attributes.Add("class", "_title");
            _title.InnerText = experiencia.Titulo;

            HtmlGenericControl _info = new HtmlGenericControl("div");
            _info.Attributes.Add("class", "_info");

            HtmlGenericControl _info_left = new HtmlGenericControl("div");
            _info_left.Attributes.Add("class", "_info_left");

            HtmlGenericControl days = new HtmlGenericControl("div");
            days.Attributes.Add("class", "days");
            days.InnerText = experiencia.Dias + "dias |";

            HtmlGenericControl cost = new HtmlGenericControl("div");
            cost.Attributes.Add("class", "cost");
            cost.InnerText = experiencia.Precio + "€";

            HtmlGenericControl _info_right = new HtmlGenericControl("div");
            _info_right.Attributes.Add("class", "_info_right");

            HtmlGenericControl rating_text = new HtmlGenericControl("p");
            rating_text.Attributes.Add("class", "rating-text");
            rating_text.InnerText = experiencia.Comentarios.Count.ToString() + " Comentarios";

            HtmlGenericControl shadow = new HtmlGenericControl("div");
            shadow.Attributes.Add("class", "shadow js-shadow");

            _info_left.Controls.Add(days);
            _info_left.Controls.Add(cost);
            _info.Controls.Add(_info_left);
            _info_right.Controls.Add(rating_text);
            _info.Controls.Add(_info_right);
            _info.Controls.Add(_info_right);

            tour_item_bottom.Controls.Add(_title);
            tour_item_bottom.Controls.Add(_info);

            country.Controls.Add(texto_pais);
            tour_item_top.Controls.Add(country);

            a_tag_general.Controls.Add(tour_item_top);
            a_tag_general.Controls.Add(tour_item_bottom);
            mostrar_experiencias.Controls.Add(a_tag_general);
        }
    }
}