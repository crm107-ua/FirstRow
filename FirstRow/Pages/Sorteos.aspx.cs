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
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void crearSorteo(object sender, EventArgs e)
        {

        }
        protected void modificarPaginaSorteos(object sender, EventArgs e)
        {

        }

        private void mostrarTarjetasPaises()
        {
            ENPais pais = new ENPais();
            List<ENPais> paises = new List<ENPais>();
            if (pais.readPaises(paises))
            {
                paises.Sort(ENPais.CompareCountriesByName);
                foreach (ENPais p in paises)
                {
                    HyperLink h = createCountryLink(p.id);
                    if (h != null) { stories_list.Controls.Add(h); }
                }
            }

            /*
            HyperLink h = createCountryLink(3); //codigo 3 corresponde a Italia
            stories_list.Controls.Add(h);

            HyperLink h2 = createCountryLink("España");
            stories_list.Controls.Add(h2);
            */
            //russia_btn.HRef = "/story/ejemplo";
        }

    }

    

}