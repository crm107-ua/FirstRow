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
            int deff = categorias.Tables["Categorias"].Rows.Count;

            foreach (DataRow row in categorias.Tables["Categorias"].Rows)
            {
                ListItem item = new ListItem(row["nombre"].ToString(), row["slug"].ToString());
                lista_categorias_blogs.Items.Insert(0, item);
            }
            ListItem itemGeneral = new ListItem("General", "");
            lista_categorias_blogs.Items.Insert(0, itemGeneral);
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