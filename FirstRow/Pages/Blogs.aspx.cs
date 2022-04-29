using library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstRow.Pages
{
    public partial class Blogs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ENCategorias categoria = new ENCategorias();
            DataSet categorias = categoria.readCategorias();
            foreach (DataRow row in categorias.Tables["Categorias"].Rows)
            {
                ListItem item = new ListItem(row["nombre"].ToString(), row["id"].ToString());
                lista_categorias_blogs.Items.Insert(0, item);
            }

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