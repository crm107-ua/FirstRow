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
                    string slug = RouteData.Values["categoria"].ToString();
                    ListItem itemGeneral = new ListItem("Blogs de " +
                                                        char.ToUpper(slug[0]) +
                                                        slug.Substring(1),
                                                        slug);
                    lista_categorias_blogs.Items.Insert(0, itemGeneral);
                    pais_blog.Text = pais_blog_titulo.Text = " de " + slug;
                }
                else
                {
                    ListItem itemGeneral = new ListItem(" - Selección de categoría");
                    lista_categorias_blogs.Items.Insert(0, itemGeneral);
                }

            }
        }

        protected void seleccionDeCategoria(object sender, EventArgs e)
        {
            Response.Redirect("/blogs/"+ lista_categorias_blogs.SelectedValue);
        }

        protected void modificarBlog(object sender, EventArgs e) { }
        protected void addStorieBlog(object sender, EventArgs e) { }
        protected void delStorieBlog(object sender, EventArgs e) { }
        protected void addExperienciaRecomendadaBlog(object sender, EventArgs e) { }
        protected void delExperienciaRecomendadaBlog(object sender, EventArgs e) { }
        protected void addCarruselImageBlog(object sender, EventArgs e) { }
        protected void delCarruselImageBlog(object sender, EventArgs e) { }
        protected void addComentarioBlog(object sender, EventArgs e) { }
        protected void delComentarioBlog(object sender, EventArgs e) { }
        protected void eliminarBlog(object sender, EventArgs e) { }

    }
}