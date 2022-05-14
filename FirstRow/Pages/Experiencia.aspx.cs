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

                    display_dias.InnerHtml = experiencia.Dias.ToString() + " dias |";
                    display_precio.InnerHtml = experiencia.Precio.ToString() + "€";
                    display_comentarios.InnerHtml = experiencia.Comentarios.Count().ToString() + " Comentarios";
                    display_description.InnerHtml = experiencia.Descripcion;


                    foreach (ENDia etapas in experiencia.Etapas)
                    {
                        string cadena = "<div class='day_item'> " +
                        "<div class='day_item-head active'>" +
                        "<div class='preview'>" +
                        "<div class='image'><img src = '" + "/Media/Etapas/" + etapas.Imagen + "' alt=''>" +
                        "</div><div class='p'>" + etapas.Titulo + "</div>" +
                        "</div><div class='_title'>" + etapas.Nombre + "</div>" +
                        "<div class='element'>" +
                        "</div>" +
                        "</div>" +
                        "<div class='day_item-body' style='display: block;'>" +
                        "<div class='text'>" + etapas.Descripcion + "</div></div></div>";
                        generadorEtapas.Controls.Add(new LiteralControl(cadena));
                    }


                    foreach (ENIncluido incluido in experiencia.Incluidos)
                    {
                        string cadena = "<li>" +
                                            "<span class='li_title'>" + incluido.Titulo + "</span>" +
                                            "<span class='li_subtitle'>" + incluido.Descripcion + "</span>" +
                                        "</li>";
                        generadorIncluidos.Controls.Add(new LiteralControl(cadena));
                    }



                    List<ENStories> storiesPais = new List<ENStories>();
                    ENStories.ReadAllStories(storiesPais, experiencia.Pais.id);


                    foreach (ENStories story in storiesPais)
                    {
                        string cadena =
                                    "<a href = '/story/" + experiencia.Pais.name.ToLower() + "' class='story_item' style='background-image: url(/Media/Stories/" + story.Imagen + ")'>" +
                                        "<div class='item_wrap'>" +
                                            "<div class='_content'>" +
                                                "<p class='text'>" +
                                                    story.Titulo +
                                                "</p>" +
                                            "</div>" +
                                        "</div>" +
                                        "<div class='shadow js-shadow'></div>" +
                                    "</a>";
                        generadorStories.Controls.Add(new LiteralControl(cadena));
                    }

                    contadorComentarios.InnerText = experiencia.Comentarios.Count.ToString();

                    foreach (ENComentarios comentario in experiencia.Comentarios)
                    {
                        string cadena =
                            "<div class='comment_item'>" +
                                "<div class='comment_item_top'>" +
                                    "<p>" +
                                    comentario.Texto +
                                    "</p>" +
                                "</div>" +
                                "<div class='comment_item_bottom'>" +
                                    "<div class='author'>" +
                                        "<div class='userpic'>" +
                                            "<img src = '" + comentario.Usuario.image + "' alt =" + comentario.Usuario.name + " />" +
                                         "</div>" +
                                    "<a href=/user/" + comentario.Usuario.nickname + "><div class='name'>" + comentario.Usuario.name + "</div></a>" +
                                "</div>" +
                                "</div>" +
                            "</div>";

                        generadorComentarios.Controls.Add(new LiteralControl(cadena));
                    }

                    if (Session["usuario"] == null)
                    {
                        seccion_escribir_comentario.Visible = false;
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