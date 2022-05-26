using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace FirstRow.Pages
{
    public partial class Contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            text_contacto_1.Text = ENAdmin.read("contacto-texto-1");
            text_contacto_2.Text= ENAdmin.read("contacto-texto-2");

        }
    }
}