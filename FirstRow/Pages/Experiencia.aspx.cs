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
                slug.Text = RouteData.Values["slug"].ToString();
            }

        }

        protected void comentar(object sender, EventArgs e)
        {


        }


        protected void reserva(object sender, EventArgs e)
        {


        }

        protected void modificarExperiencia(object sender, EventArgs e)
        {


        }

        protected void eliminarComentario(object sender, EventArgs e)
        {


        }

        protected void eliminarExperiencia(object sender, EventArgs e)
        {


        }
    }
}