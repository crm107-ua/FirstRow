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
            if (myRoute != null && myRoute.Url == "blog/{slug}")
            {
                string cadena = char.ToUpper(RouteData.Values["slug"].ToString()[0]) + RouteData.Values["slug"].ToString().Substring(1);
                titulo.Text = slug.Text = cadena.Replace("-", " ");
            }


            ENCategorias categoria = new ENCategorias();
            DataSet categorias = categoria.readCategorias();
            foreach (DataRow row in categorias.Tables["Categorias"].Rows)
            {
                HtmlGenericControl li = new HtmlGenericControl("li");
                HtmlGenericControl a = new HtmlGenericControl("a");
                a.InnerText = row["nombre"].ToString();
                a.Attributes.Add("href", "/categorias/" + row["slug"].ToString());
                li.Controls.Add(a);
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