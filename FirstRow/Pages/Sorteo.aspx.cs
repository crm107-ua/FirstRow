using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace FirstRow.Pages
{
    public partial class Sorteo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Route myRoute = RouteData.Route as Route;
            if (myRoute != null && myRoute.Url == "sorteo/{slug}")
            {
                string cadena = char.ToUpper(RouteData.Values["slug"].ToString()[0]) + RouteData.Values["slug"].ToString().Substring(1);
                titulo.Text = slug.Text = cadena.Replace("-", " ");
            }

        }
        protected void modificarSorteo(object sender, EventArgs e)
        {

        }
        protected void participarSorteo(object sender, EventArgs e)
        {

        }
        protected void salirSorteo(object sender, EventArgs e)
        {

        }
        protected void eliminarSorteo(object sender, EventArgs e)
        {

        }

    }

   

}