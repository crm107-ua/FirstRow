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
    public partial class Sorteo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cadena="";
            Route myRoute = RouteData.Route as Route;
            if (myRoute != null && myRoute.Url == "sorteo/{slug}")
            {
              cadena = char.ToUpper(RouteData.Values["slug"].ToString()[0]) + RouteData.Values["slug"].ToString().Substring(1);
                titulo.Text = slug.Text = cadena.Replace("-", " ");
               
            }
            /*
                        ENSorteos sorteo = new ENSorteos();

                       //no se como conseguir aqui los datos del sorteo
                        //el metodo readsorteo me deberia de devolver los datos pero no se como hacerlo        

                        titulo.Text = p.Titulo.ToString();
            */
            ENSorteos so = new ENSorteos();
            so.readsorteo(cadena);

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