using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using library;

namespace FirstRow.Pages
{
    public partial class Sorteos : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            Application["sorteos_title"] = ENAdmin.read("titulo-sorteos");
            Application["sorteos_subtitle"] = ENAdmin.read("des-sorteos");
            sorteos_title2.Text = (string)Application["sorteos_title"];
            sorteos_subtitle.InnerText = (string)Application["sorteos_subtitle"];
            /*
             "url(https://static.onecms.io/wp-content/uploads/sites/28/2021/09/24/travel-gifts-lead-TRVLGG0921.jpg)"
             */
            background_image_header.Style.Add("background-image", "url(https://static.onecms.io/wp-content/uploads/sites/28/2021/09/24/travel-gifts-lead-TRVLGG0921.jpg)");
            ENUsuario user = (ENUsuario)Session["usuario"];
            ENEmpresa emp = (ENEmpresa)Session["empresa"];
            if (emp != null)
            {
               
                add_form.Visible = true;
                add_form.InnerHtml = "Agregar Sorteo";
            }
            else { add_form.Visible = false; }

            ENSorteos sorteo = new ENSorteos();
            List<ENSorteos> lista = new List<ENSorteos>();
            sorteo.readsorteosconectado(lista);
            
            listaSorteos(lista);
        }
        private void listaSorteos(List<ENSorteos> sorteos)
        {
            foreach (ENSorteos s in sorteos)
            {

               
                string cadena =
                        "<a class='blog_item' href='/sorteo/" + Home.slug(s.Slug.ToString()) + "'>" +
                            "<div class='blog_item_top' style ='background-image: url(/Media/Sorteos/" + s.Imagen+ ")'> " +
                               " <div class='sq_parent'> " +
                                    "<div class='sq_wrap'> " +
                                        "<div class='sq_content'> " +
                                            "<div class='tags'> " +
                                                "<div class='tag blue'>"
                                                    + s.Titular +
                                                "</div>" +
                                            "</div>" +
                                                "<h3 class='_title'>"
                                                    + s.Titulo +
                                                "</h3>" +
                                        "</div>" +
                                    "</div>" +
                                "</div>" +
                                "<div class='shadow js - shadow'></div>" +
                            "</div>" +
                            "<div class='blog_item_bottom'>" +
                                "<div class='author'>" +
                                    //añadir userpic aqui
                                    /*
                                      "<div class='userpic'>" +
                                        "<img src = " + s.Usuario.image + " alt =" + s.Usuario.name + " />" +
                                    "</div>" +
                                    */
                                    "<p class='date'>" +
                                        "Desde " + s.FechaInicio.ToString("dd/MM/yyyy") +"</br>"+ "Hasta "+s.FechaFinal.ToString("dd/MM/yyyy")+
                                    "</p>" +
                                "</div>" +
                             "</div>" +
                          "</a>";
                sorteos_list.Controls.Add(new LiteralControl(cadena));
                /* string c = "< a class=\"blog_item\" href=\"/sorteo/" + s.Slug + ">" +
                    "<div class=\"blog_item_top\" style=\"background-image: url(/Media/Stories" + s.Imagen + ")\">" +
                    "<div class=\"sq_parent\">" +
                    "<div class=\"sq_wrap\">" +
                    "<div class=\"sq_content\">" +
                    "<div class=\"tags\">" +
                    "<div class=\"tag red\">" +
                    s.Id +
                    "</div>" +
                    "</div>" +
                    "< h3 class=\"_title\">" +
                    s.Descripcion +
                    "</h3>" +
                    "</div>" +
                    "</div>" +
                    "</div>" +
                    "< div class=\"shadow js-shadow\"></div>" +
                    "</div>" +
                    "<div class=\"blog_item_bottom\">" +
                    "<div class=\"author\">" +
                    "<div class=\"userpic\">" +
                        "< img src = " + s.Imagen + " alt = " + s.Nombre + " /> " +
                        "</div>" +
                        "< p class=\"date\">" +
                        s.FechaInicio + "x participantes" +
                        "</p>" +
                        "</div>" +
                    "</div>" +
                "</a>";*/
            }

        }

        protected void crearSorteo(object sender, EventArgs e)
        {

        }
        protected void modificarPaginaSorteos(object sender, EventArgs e)
        {

        }


    }

}

    

