using library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstRow.Pages
{
    public partial class Blogs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Route myRoute = RouteData.Route as Route;
            ENCategorias categoria = new ENCategorias();
            DataSet categorias = categoria.readCategorias();
            ENBlog blog = new ENBlog();
            List<ENBlog> blogs = new List<ENBlog>();
            loadSesionTags();
            blog_title.Text = ENAdmin.read("titulo-blogs");

            if (!IsPostBack)
            {
                ListItem itemBlogs = new ListItem("Todas las categorías", "/");
                lista_categorias_blogs.Items.Insert(0, itemBlogs);


                foreach (DataRow row in categorias.Tables["Categorias"].Rows)
                {
                    ListItem item = new ListItem(row["nombre"].ToString(), row["slug"].ToString());
                    lista_categorias_blogs.Items.Insert(0, item);
                }

                if (myRoute != null && myRoute.Url == "blogs/{categoria}")
                {

                    categoria.slug = RouteData.Values["categoria"].ToString();

                    if (!categoria.readCategoria(false))
                    {
                        Response.Redirect("/404");
                        return;
                    }

                    lista_categorias_blogs.Items.Insert(0, new ListItem("Blogs de " + categoria.nombre));
                    pais_blog.Text = pais_blog_titulo.Text = " de " + categoria.slug;
                    blog.blogsPorCategoria(blogs, categoria.id);

                }
                else
                {
                    ListItem itemGeneral = new ListItem(" - Selección de categoría");
                    lista_categorias_blogs.Items.Insert(0, itemGeneral);
                    blog.blogsPorCategoria(blogs, 0);
                }

                if(blogs.Count() != 0)
                {
                    resultado_busqueda.InnerText = ENAdmin.read("des-blogs");
                }
                else
                {
                    resultado_busqueda.InnerText = "No existen blogs de categoría " + categoria.nombre;
                }

                generadorTextos(blogs);
            }
        }

        protected void seleccionDeCategoria(object sender, EventArgs e)
        {
            Response.Redirect("/blogs/"+ lista_categorias_blogs.SelectedValue);
        }

        private void loadSesionTags()
        {
            ENUsuario user = (ENUsuario)Session["usuario"];
            if (user != null)
            {
                add_form.Visible = true;
                add_form.InnerHtml = "Agregar blog";
            }
            else { add_form.Visible = false; }
        }

        private void generadorTextos(List<ENBlog> blogs)
        {
            foreach (ENBlog blogIterativo in blogs)
            {
                string cadena =
                        "<a class='blog_item' href='/blog/" + blogIterativo.Categoria.slug + "/" + blogIterativo.Slug + "'>" +
                            "<div class='blog_item_top' style ='background-image: url(/Media/Blogs/" + blogIterativo.Imagen_principal + ")'> " +
                               " <div class='sq_parent'> " +
                                    "<div class='sq_wrap'> " +
                                        "<div class='sq_content'> " +
                                            "<div class='tags'> " +
                                                "<div class='tag blue'>"
                                                    + blogIterativo.Categoria.nombre +
                                                "</div>" +
                                            "</div>" +
                                                "<h3 class='_title'>"
                                                    + blogIterativo.Titulo +
                                                "</h3>" +
                                        "</div>" +
                                    "</div>" +
                                "</div>" +
                                "<div class='shadow js - shadow'></div>" +
                            "</div>" +
                            "<div class='blog_item_bottom'>" +
                                "<div class='author'>" +
                                    "<div class='userpic'>" +
                                        "<img src = " + blogIterativo.Usuario.image + " alt =" + blogIterativo.Usuario.name + " />" +
                                    "</div>" +
                                    "<p class='date'>" +
                                        "Escrito por " + blogIterativo.Usuario.name + ", el día " + blogIterativo.Fecha.ToString("dd/MM/yyyy") +
                                    "</p>" +
                                "</div>" +
                             "</div>" +
                          "</a>";
                cargaBlogs.Controls.Add(new LiteralControl(cadena));
            }
        }
    }
}