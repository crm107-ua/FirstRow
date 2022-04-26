using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
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
                string slug = RouteData.Values["slug"].ToString();
                Response.Write("Exeperiencia con slug: " + slug);
            }

        }
    }
}