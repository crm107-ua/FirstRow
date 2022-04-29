using System;
using library;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace FirstRow.Pages
{
    public partial class Stories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                mostrarTarjetasPaises();
                llenarDropDownList();
                btn_modificar_pagina.Visible = false;
                stories_title.InnerText = "Stories interesantes";
                stories_subtitle.InnerText = "Literatura latina del 45 a. C., por lo que tiene más de 2000 años.";
                background_image_header.Style.Add("background-image", "url(https://media.cntraveler.com/photos/5cc32b6031a2ae65b96fb4ff/16:9/w_2560%2Cc_limit/MAG19_May_TR050419_Zihuatanejo02.jpg)");

                /* lista de paises
                if (country_list.Items.Count <= 1)
                {
                    //country_list.DataSource = MyDataSource; //MyDataSource: DataTable o algo así :)
                    country_list.DataBind();
                }*/
                /*
                foreach (DataRow dr in dt.Rows) {
                    DropDownList1.Items.Add(new ListItem(dr["country"], dr["id"]));
                }
                quiza con datasource? o datavaluefield
                */

                stories_description_title.Text = "Descripción de la categoría";
                stories_description.Text = "Pero debo explicarles cómo nació toda esta idea equivocada de denunciar el placer y ensalzar el dolor y les daré cuenta completa del sistema y expondré las enseñanzas reales del gran explorador de la verdad, el maestro constructor de la felicidad del ser humano. Nadie rechaza, disgusta o evita el placer mismo, porque es placer, sino porque quien no sabe perseguir racionalmente el placer encuentra consecuencias sumamente dolorosas.";

            }
        }

        protected void modificarPaginaStories(object sender, EventArgs e)
        {
            
            //COMPLETAR -- redirigir a formulario ¿?
        }

        protected void filtrarPais(object sender, EventArgs e)
        {
            //COMPLETAR
        }

        private void mostrarTarjetasPaises()
        {
            ENPais pais = new ENPais();
            List<ENPais> paises = new List<ENPais>();
            if (pais.readPaises(paises))
            {
                paises.Sort(ENPais.CompareCountriesByName);
                foreach(ENPais p in paises)
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

        private void llenarDropDownList()
        {
            DataSet ds = new DataSet();
            if (ENPais.ReadPaisesDataSet(ds))
            {
                country_list.Attributes.Add("style", "font-size: 18px");
                country_list.DataSource = ds;
                country_list.DataTextField = "name";
                country_list.DataValueField = "id";
                country_list.DataBind();

            }
            
        }

        private HyperLink createCountryLink(int countryId)
        {

            ENPais pais = new ENPais();
            pais.id = countryId;
            string slug = "";
            if (pais.ReadPais())
            {
                slug = pais.name;

                HyperLink h = new HyperLink();
                h.NavigateUrl = $"/story/{slug}";
                h.CssClass = "story_item";
                //imagen por defecto, cambiar a imagen del país
                h.Style.Add("background-image", "url(https://img.freepik.com/vector-gratis/resumen-fondo-plateado-claro_67845-796.jpg)");

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

        private HyperLink createCountryLink(string countryName)
        {
            ENPais pais = new ENPais();
            pais.name = countryName;
            if (pais.ReadPais())
            {
                HyperLink h = createCountryLink(pais.id);
                return h;
            }
            else { return null; }
        }
    }
}