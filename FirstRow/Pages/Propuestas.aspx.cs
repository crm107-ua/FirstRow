using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstRow.Pages
{
    public partial class Propuestas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null) { add_form.Visible = true; } else { add_form.Visible = false; }

            Application["propuestas_title"] = ENAdmin.read("titulo-propuestas");
            Application["propuestas_subtitle"] = ENAdmin.read("des-propuestas");
            propuestas_title2.Text = (string)Application["propuestas_title"];
            propuestas_subtitle.InnerText = (string)Application["propuestas_subtitle"];
            /*
             "url(https://static.onecms.io/wp-content/uploads/sites/28/2021/09/24/travel-gifts-lead-TRVLGG0921.jpg)"
             */
            background_image_header.Style.Add("background-image", "url(https://static.onecms.io/wp-content/uploads/sites/28/2021/09/24/travel-gifts-lead-TRVLGG0921.jpg)");

            ENPropuestas propuesta = new ENPropuestas();
            List<ENPropuestas> lista = new List<ENPropuestas>();
            propuesta.readpropuestasconectado(lista);
        }
        }
}