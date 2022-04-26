using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
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
                string slug = RouteData.Values["slug"].ToString();
                Response.Write("Blog con slug: " + slug);
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