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

            /*Application["propuestas_titulo"] = ENAdmin.read("titulo-propuestas");
            Application["propuestas_texto"] = ENAdmin.read("texto-propuestas");
            propuestas_titulo.Text = (string)Application["propuestas_titulo"];
            propuestas_texto.InnerText = (string)Application["propuestas_texto"];
            /*
             "url(https://static.onecms.io/wp-content/uploads/sites/28/2021/09/24/travel-gifts-lead-TRVLGG0921.jpg)"
             */
            background_image_header.Style.Add("background-image", "url(https://static.onecms.io/wp-content/uploads/sites/28/2021/09/24/travel-gifts-lead-TRVLGG0921.jpg)");
            if (!IsPostBack)
                loadPropuestas();
        }

        private void loadPropuestas() 
        {
            ENPropuestas propuesta = new ENPropuestas();
            List<ENPropuestas> lista = new List<ENPropuestas>();
            propuesta.readpropuestasconectado(lista);
            foreach (ENPropuestas blogIterativo in lista)
            {
                string cadena =
                        "<a class='blog_item' href='/blog/" + blogIterativo.Slug + "'>" +
                            "<div class='blog_item_top' style ='background-image: url(/Media/Blogs/" + blogIterativo.Imagenes.Name + ")'> " +
                               " <div class='sq_parent'> " +
                                    "<div class='sq_wrap'> " +
                                        "<div class='sq_content'> " +
                                            "<div class='tags'> " +
                                            "</div>" +
                                                "<h3 class='_title'>"
                                                    + blogIterativo.Titulo +
                                                "</h3>" +
                                        "</div>" +
                                    "</div>" +
                                "</div>" +
                                "<div class='shadow js - shadow'></div>" +
                            "</div>" +
                            "<div class='blog_item_bottom'>" +
                                "<div class='author'>" +
                                    "<div class='userpic'>" +
                                        "<img src = " + blogIterativo.Usuario.image + " alt =" + blogIterativo.Usuario.name + " />" +
                                    "</div>" +
                                    "<p class='date'>" +
                                        "Escrito por " + blogIterativo.Usuario.name + ", para " + blogIterativo.Empresa.name +
                                    "</p>" +
                                "</div>" +
                             "</div>" +
                          "</a>";
                propuestas_list.Controls.Add(new LiteralControl(cadena));
            }
        }
        
    }
}