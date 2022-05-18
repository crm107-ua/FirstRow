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
            mostrarTarjetasPaises();
            Application["sorteos_title"] = "Sorteos";
            Application["sorteos_subtitle"] = "Para nuestros clientes. " +
                "Que la suerte este siempre de vuestra parte.";
            sorteos_title.InnerText = (string)Application["sorteos_title"];
            sorteos_subtitle.InnerText = (string)Application["sorteos_subtitle"];
            background_image_header.Style.Add("background-image", "url(https://static.onecms.io/wp-content/uploads/sites/28/2021/09/24/travel-gifts-lead-TRVLGG0921.jpg)");

        }
        private void mostrarTarjetasPaises()
        {
            ENSorteos sorteo = new ENSorteos();
            List<ENSorteos> sort = new List<ENSorteos>();
            if (sorteo.getlistadesconectado(sort))
            {
                foreach (ENSorteos s in sort)
                {
                    HyperLink h = CreateLink(s.Id);
                    if (h != null) { sorteos_list.Controls.Add(h); }
                }
            }
    

        }
        private HyperLink CreateLink(int sorteoid)
        {

            ENSorteos sorteo= new ENSorteos();
            sorteo.Id = sorteoid;
            string slug;
            if (sorteo.readsorteo())
            {
                //Añadimos el enlace a la página de stories del país
                slug = Home.slug(sorteo.Nombre);
                HyperLink h = new HyperLink();
                h.NavigateUrl = $"/sorteo/{slug}";//?id=" + countryId
                h.CssClass = "story_item";
                //h.Style.Add("background-image", $"url(../Media/Paises/{slug}.jpg)");

                //Añadimos la imagen almacenada en el servidor;
                //si no existe, una por defecto
                if (File.Exists(Server.MapPath($"~/Media/Paises/{slug}.jpg")))
                {
                    h.Style.Add("background-image", $"url(../Media/Paises/{slug}.jpg)");

                }
                else
                {
                    h.Style.Add("background-image", $"url(../assets/img/default.jpg)");
                }

                //Creamos un panel para el texto de la tarjeta
                Panel wrap = new Panel();
                wrap.CssClass = "item_wrap";
                Panel content = new Panel();
                content.CssClass = "_content";

       

                //El país al que hace referencia
                Label sort = new Label();
                sort.CssClass = "country";
                sort.Text = sorteo.Nombre;
                Label text = new Label();
                text.CssClass = "text";
                //el subtítulo de la tarjeta
                text.Text = $"Explora las Stories de {sorteo.Nombre}";
                content.Controls.Add(sort);
                content.Controls.Add(text);
                wrap.Controls.Add(content);
                h.Controls.Add(wrap);

                //Añadimos la sombra a la tarjeta
                Panel shadow = new Panel();
                shadow.CssClass = "shadow js-shadow";
                h.Controls.Add(shadow);

                return h;

            }
            else { return null; }

        }
        protected void crearSorteo(object sender, EventArgs e)
        {

        }
        protected void modificarPaginaSorteos(object sender, EventArgs e)
        {

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

    

