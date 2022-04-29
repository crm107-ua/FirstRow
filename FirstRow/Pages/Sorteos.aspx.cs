using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace FirstRow.Pages
{
    public partial class Sorteos : System.Web.UI.Page
    {
        ENSorteos sorteo;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public event EventHandler<CrearSorteoArgs> crearSorteos;
        public event EventHandler<modificarPaginaSorteos> modificarSorteos;
    }

    public class modificarPaginaSorteos
    {
        public ENSorteos paginasorteo { get; set; }
        public modificarPaginaSorteos(ENSorteos sorteo)
        {
           ///
        }
    }

     public class CrearSorteoArgs : EventArgs
    {
        public ENSorteos sorteo { get; set; }
        public CrearSorteoArgs (ENSorteos sorteo)
        {
            this.sorteo = sorteo;
        }
    }

}