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
                    HyperLink h = createCountryLink(s.Id);
                    if (h != null) { sorteos_list.Controls.Add(h); }
                }
            }
            /*
            ENPais pais = new ENPais();
            List<ENPais> paises = new List<ENPais>();
            if (pais.getListPaisesDesconectado(paises))
            {
                paises.Sort(ENPais.CompareCountriesByName);
                foreach (ENPais p in paises)
                {
                    HyperLink h = createCountryLink(p.id);
                    if (h != null) { sorteos_list.Controls.Add(h); }
                }
            }*/

        }
        private HyperLink createCountryLink(int countryId)
        {

            ENPais pais = new ENPais();
            ENSorteos sorteo = new ENSorteos();

            sorteo.Id= countryId;
            string slug;
            if (sorteo.readsorteo())
            {
                slug = Home.slug(sorteo.Nombre);

                HyperLink h = new HyperLink();
                h.NavigateUrl = $"/sorteo/{slug}?id=" + countryId;
                h.CssClass = "story_item";
                //h.Style.Add("background-image", $"url(../Media/Paises/{slug}.jpg)");
                if (File.Exists(Server.MapPath($"~/Media/Paises/{slug}.jpg")))
                {
                    h.Style.Add("background-image", $"url(../Media/Paises/{slug}.jpg)");

                }
                else
                {
                    h.Style.Add("background-image", $"url(../assets/img/default.jpg)");
                }

                Panel wrap = new Panel();
                wrap.CssClass = "item_wrap";
                Panel content = new Panel();
                content.CssClass = "_content";
                /*
                Panel flag_wrap = new Panel();
                flag_wrap.CssClass = "flag_wrap";
                Panel flag = new Panel();
                flag.CssClass = "flag";
                Image imagen = new Image();
                imagen.ImageUrl = "";
                flag_wrap.Controls.Add(flag);
                content.Controls.Add(flag_wrap);
                */
                Label country = new Label();
                country.CssClass = "country";
                country.Text = pais.name;
                Label text = new Label();
                text.CssClass = "text";
                text.Text = $"Explora las Stories de {pais.name}";
                content.Controls.Add(country);
                content.Controls.Add(text);
                wrap.Controls.Add(content);
                h.Controls.Add(wrap);

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

    

