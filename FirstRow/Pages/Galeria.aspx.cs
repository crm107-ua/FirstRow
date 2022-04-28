using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstRow.Pages
{
    public partial class Galeria : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Direccion.Items.Clear();
            ENPais pais = new ENPais();
            List<ENPais> paises = new List<ENPais>();
            pais.readPaises(paises);

            foreach (ENPais p in paises)
            {
                Direccion.Items.Insert(0, new ListItem(p.name, p.id.ToString()));
            }
            //Hacer un bucle para cargar todas las galerias.
        }

        protected void VerMas_Click(object sender, EventArgs e)
        {
            //Cargar mas elementos de la galeria
        }

        protected void Direccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
            //Cambio en el filtrado
        }
    }
}