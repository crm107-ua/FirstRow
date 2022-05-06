using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstRow.Pages.Forms
{
    public partial class FormExperiencia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ENPais pais = new ENPais();
            List<ENPais> paises = new List<ENPais>();
            pais.readPaises(paises);

            foreach (ENPais p in paises)
            {
                listaPaises_form_experiencia.Items.Insert(0, new ListItem(p.name, p.id.ToString()));
            }

        }
    }
}