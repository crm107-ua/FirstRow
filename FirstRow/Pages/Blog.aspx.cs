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
            Route myRoute = RouteData.Route as Route;
            ENBlog blog = new ENBlog();
            ENCategorias categoria = new ENCategorias();

            categoria.slug = RouteData.Values["categoria"].ToString();
            blog.Slug = RouteData.Values["slug"].ToString();

            if (!categoria.readCategoria(false) || !blog.mostrarBlog())
            {
                Response.Redirect("/404");
                return;
            }

        
            blog.Slug = RouteData.Values["slug"].ToString();
            blog.Categoria = categoria;
            titulo.Text = blog.Titulo;


            DataSet categorias = categoria.readCategorias();
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
        protected void crearBlog(object sender, EventArgs e)
        {


        }

        protected void modificarPaginaBlogs(object sender, EventArgs e)
        {


        }
    }
}