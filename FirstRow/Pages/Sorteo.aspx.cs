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

        public event EventHandler<modificarSorteoArgs> modificarSorteo;
        public event EventHandler<participarSorteoArgs> participarSorteo;
        public event EventHandler<salirSorteoArgs> salirSorteo;
        public event EventHandler<eliminarSorteoArgs> eliminarSorteo;
    }

    public class modificarSorteoArgs : EventArgs
    {
        public ENSorteos modificarsorteo { get; set; }
        public modificarSorteoArgs()
        {

        }

    }
    public class participarSorteoArgs : EventArgs
    {
        public ENSorteos participarsorteo { get; set; }
        public participarSorteoArgs()
        {

        }
    }
    public class salirSorteoArgs : EventArgs
    {
        public ENSorteos salirsorteo { get; set; }
        public salirSorteoArgs()
        {

        }
    }
    public class eliminarSorteoArgs : EventArgs
    {
        public ENSorteos eliminarsorteo { get; set; }
        public eliminarSorteoArgs()
        {

        }

    }
    
}