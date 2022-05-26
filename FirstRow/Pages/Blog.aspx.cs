using library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FirstRow.Pages
{
    public partial class Blog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ENBlog blog = new ENBlog();
            ENCategorias categoria = new ENCategorias();

            categoria.slug = RouteData.Values["categoria"].ToString();
            blog.Slug = RouteData.Values["slug"].ToString();

            if (!categoria.readCategoria(false) || !blog.mostrarBlog() || blog.Categoria.slug != categoria.slug)
            {
                Response.Redirect("/404");
                return;
            }

            blog.Slug = RouteData.Values["slug"].ToString();
            blog.Categoria = categoria;
            user_enlace.HRef = "/user/" + blog.Usuario.nickname;

            DataSet categorias = categoria.readCategorias();
            controlDeSesion();
            listarCategorias(categorias);
            cargarBlog(blog);

        }

        private void controlDeSesion()
        {
            if (Session["usuario"] == null)
            {
                seccion_escribir_comentario.Visible = false;
            }
        }

        private void cargarBlog(ENBlog blog)
        {
            titulo.Text = blog.Titulo;
            slug.Text = blog.Titulo;
            text_categoria.InnerText = blog.Categoria.nombre;
            text_pais.InnerText = blog.Pais.name;
            Image perfil = new Image();
            perfil.ImageUrl = blog.Usuario.image;
            perfil.AlternateText = blog.Usuario.name;
            perfil.Attributes.Add("style", "height:100%; width: 100%; object-fit: cover;");
            foto_perfil.Controls.Add(perfil);
            imagen_principal.Attributes.Add("style", "background-image: url(/Media/Blogs/" + blog.Imagen_principal + ")");
            text_description.InnerText = blog.Descripcion;
            text_1.InnerText = blog.Texto_1;
            text_2.InnerText = blog.Texto_2;
            text_3.InnerText = blog.Texto_3;
            text_cita.InnerText = blog.Citacion;
            text_fecha.InnerText = "Escrito por " + blog.Usuario.name + ", el día " + blog.Fecha.ToString("dd/MM/yyyy");
            contadorComentarios.InnerText = blog.Comentarios.Count.ToString();
            listarStories(blog);
            listarImagenes(blog);
            loadExpeciencia(blog);
            listarComentarios(blog);
        }

        private void listarComentarios(ENBlog blog)
        {

            if (blog.Comentarios.Count() == 0)
            {
                text_comentarios.InnerText = "Este blog no tiene comentarios";
                contadorComentarios.Visible = false;
            }

            foreach (ENComentarios comentario in blog.Comentarios)
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
        }
        private void loadExpeciencia(ENBlog blog)
        {
            Random random = new Random();
            ENViajes ENexperiencia = new ENViajes();
            List<ENViajes> experiencias = new List<ENViajes>();
            ENexperiencia.mostrarExperienciasPais(experiencias, blog.Pais.id);

            if (experiencias.Count() > 0)
            {
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
                recomendada.Controls.Add(a_tag_general);
            }
            else
            {
                recomendadaAviso.InnerText = "No existen recomendaciones en " + blog.Pais.name;
            }

        }

        private void listarImagenes(ENBlog blog)
        {
            foreach (ENImagenes imagen in blog.Imagenes)
            {
                HyperLink a_tag_general = new HyperLink();
                a_tag_general.NavigateUrl = "/Media/Blogs/" + imagen.Name;
                a_tag_general.Attributes.Add("class", "img");

                Image img = new Image();
                img.ImageUrl = "/Media/Blogs/" + imagen.Name;
                img.AlternateText = blog.Usuario.name;

                a_tag_general.Controls.Add(img);
                cargaImagenes.Controls.Add(a_tag_general);
            }
        }

        private void listarStories(ENBlog blog)
        {
            List<ENStories> storiesPais = new List<ENStories>();
            ENStories.ReadAllStories(storiesPais, blog.Pais.id);
            int total = 0;
            foreach (ENStories story in storiesPais)
            {
                string cadena =
                            "<a href = '/story/" + blog.Pais.name.ToLower() + "' class='story_item' style='background-image: url(/Media/Stories/" + story.Imagen + ")'>" +
                                "<div class='item_wrap'>" +
                                    "<div class='_content'>" +
                                        "<p class='text'>" +
                                            story.Titulo +
                                        "</p>" +
                                    "</div>" +
                                "</div>" +
                                "<div class='shadow js-shadow'></div>" +
                            "</a>";
                if (total < 4)
                {
                    cargaStories.Controls.Add(new LiteralControl(cadena));
                }
                total++;
            }

            if (total == 0)
            {
                text_stories.InnerText = "No existen stories en " + blog.Pais.name;
            }
        }

        private void listarCategorias(DataSet categorias)
        {
            foreach (DataRow row in categorias.Tables["Categorias"].Rows)
            {
                HtmlGenericControl li = new HtmlGenericControl("li");
                HtmlGenericControl a = new HtmlGenericControl("a");
                a.InnerText = row["nombre"].ToString();
                a.Attributes.Add("href", "/blogs/" + row["slug"].ToString());
                li.Controls.Add(a);

                string aux_1 = char.ToLower(row["nombre"].ToString()[0]) + row["nombre"].ToString().Substring(1);
                string aux_2 = RouteData.Values["categoria"].ToString();

                if (aux_1.Equals(aux_2))
                {
                    a.Attributes.Add("style", "color: #FF3B00; font-weight: bold;");
                }

                listaCategorias.Controls.Add(li);
            }
        }

        protected void experiencia_comentar_Click(object sender, EventArgs e)
        {

            ENComentarios eNComentarios = new ENComentarios();
            eNComentarios.Estrellas = comentario_raing.CurrentRating;
            eNComentarios.Texto = create_comentario.Text.Trim();
            eNComentarios.Usuario = (ENUsuario)Session["usuario"];
            ENBlog blog = new ENBlog();
            blog.Slug = RouteData.Values["slug"].ToString();
            blog.mostrarBlog();

            eNComentarios.InsertarComentario(blog.Id, true);

        }

        protected void blog_raing_Changed(object sender, AjaxControlToolkit.RatingEventArgs e) { }
    }
}