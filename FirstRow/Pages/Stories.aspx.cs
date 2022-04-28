using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstRow.Pages
{
    public partial class Stories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            stories_title.InnerText = "Interesting Stories";
            stories_subtitle.InnerText = "Latin literature from 45 BC, making it over 2000 years old";
            background_image_header.Style.Add("background-image", "url(https://media.cntraveler.com/photos/5cc32b6031a2ae65b96fb4ff/16:9/w_2560%2Cc_limit/MAG19_May_TR050419_Zihuatanejo02.jpg)");

            /*
            if (country_list.Items.Count <= 1)
            {
                //country_list.DataSource = MyDataSource;
                country_list.DataBind();
            }*/

            stories_description_title.Text = "Descripción de la categoría";
            stories_description.Text = "Pero debo explicarles cómo nació toda esta idea equivocada de denunciar el placer y ensalzar el dolor y les daré cuenta completa del sistema y expondré las enseñanzas reales del gran explorador de la verdad, el maestro constructor de la felicidad del ser humano. Nadie rechaza, disgusta o evita el placer mismo, porque es placer, sino porque quien no sabe perseguir racionalmente el placer encuentra consecuencias sumamente dolorosas.";
            /**
             * foreach (DataRow dr in dt.Rows) {
                    DropDownList1.Items.Add(new ListItem(dr["country"], dr["id"]));
               }
             * quiza con datasource? o datavaluefield
             */
        }

        protected void modificarPaginaStories(object sender, EventArgs e)
        {
            //COMPLETAR -- redirigir a formulario ¿?
        }
    }
}