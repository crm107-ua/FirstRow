using System;
using library;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace FirstRow.Pages
{
    public partial class Stories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            mostrarTarjetasPaises();
            if (!Page.IsPostBack)
            {
                llenarDropDownList();
                ENUsuario user = (ENUsuario)Session["usuario"];
                if (user != null && user.nickname == "admin")
                {
                    btn_modificar_pagina.Visible = true;
                }
                else { btn_modificar_pagina.Visible = false; }

                //Este texto debería provenir de una tabla en la BD
                Application["stories_title"] = "Stories interesantes";
                Application["stories_subtitle"] = "Muestra tus experiencias al mundo " +
                    "y explora las de otras personas.";
                
                
                stories_title.InnerText = (string)Application["stories_title"];
                stories_subtitle.InnerText = (string)Application["stories_subtitle"];
                background_image_header.Style.Add("background-image", "url(https://media.cntraveler.com/photos/5cc32b6031a2ae65b96fb4ff/16:9/w_2560%2Cc_limit/MAG19_May_TR050419_Zihuatanejo02.jpg)");

                stories_description_title.Text = "Descripción de la categoría";
                stories_description.Text = "Pero debo explicarles cómo nació toda esta idea equivocada de denunciar el placer y ensalzar el dolor y les daré cuenta completa del sistema y expondré las enseñanzas reales del gran explorador de la verdad, el maestro constructor de la felicidad del ser humano. Nadie rechaza, disgusta o evita el placer mismo, porque es placer, sino porque quien no sabe perseguir racionalmente el placer encuentra consecuencias sumamente dolorosas.";

            }

        }

        /// <summary>
        /// Habilita la edición de la página. 
        /// Solamente puede usarlo el admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void modificarPaginaStories(object sender, EventArgs e)
        {
            stories_title_edit.Visible = true;
            stories_subtitle_edit.Visible = true;
            stories_description_title_edit.Visible = true;
            stories_description_edit.Visible = true;
            //background_image_header.Style.Add("background-image", "url(../../assets/img/demo-bg-5.jpg)");
            //Response.Redirect("/stories");

            btn_aceptar_cambios.Visible = true;
            btn_cancelar_cambios.Visible = true;
            btn_modificar_pagina.Visible = false;
        }

        /// <summary>
        /// Redirige a las páginas de story
        /// con los valores del dropDownList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void seleccionarPais(object sender, EventArgs e)
        {
            if (country_list.SelectedValue != "-1")
            {
                Response.Redirect("/story/" + Home.slug(country_list.SelectedItem.Text));

            }
        }

        /// <summary>
        /// Muestra las trajetas de los paises
        /// al iniciar la página
        /// </summary>
        private void mostrarTarjetasPaises()
        {
            ENPais pais = new ENPais();
            List<ENPais> paises = new List<ENPais>();
            if (pais.getListPaisesDesconectado(paises))
            {
                paises.Sort(ENPais.CompareCountriesByName);
                foreach (ENPais p in paises)
                {
                    HyperLink h = CreateCountryLink(p.id);
                    if (h != null) { stories_list.Controls.Add(h); }
                }
            }

        }

        /// <summary>
        /// Llena el dropDownList con los países en la BD
        /// </summary>
        private void llenarDropDownList()
        {
            DataSet ds = new DataSet();
            if (ENPais.ReadPaisesDataSet(ds))
            {
                //country_list.Attributes.Add("style", "font-size: 18px");
                country_list.DataSource = ds;
                country_list.DataTextField = "name";
                country_list.DataValueField = "id";
                country_list.DataBind();

            }
            country_list.Items.Insert(0, new ListItem("-- Destination --", "-1"));
            
        }

        /// <summary>
        /// Crea la tarjeta de un país
        /// </summary>
        /// <param name="countryId">Id del país</param>
        /// <returns>Un objeto HyperLink con la información
        /// del país necesaria</returns>
        private HyperLink CreateCountryLink(int countryId)
        {

            ENPais pais = new ENPais();
            pais.id = countryId;
            string slug;
            if (pais.ReadPais())
            {
                //Añadimos el enlace a la página de stories del país
                slug = Home.slug(pais.name); 
                HyperLink h = new HyperLink();
                h.NavigateUrl = $"/story/{slug}";//?id=" + countryId
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

                //El país al que hace referencia
                Label country = new Label();
                country.CssClass = "country";
                country.Text = pais.name;
                Label text = new Label();
                text.CssClass = "text";
                //el subtítulo de la tarjeta
                text.Text = $"Explora las Stories de {pais.name}";
                content.Controls.Add(country);
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

        /// <summary>
        /// Equivalente al anterior método
        /// pero obtiene el país con el nombre
        /// </summary>
        /// <param name="countryName">El nombre del país</param>
        /// <returns></returns>
        private HyperLink CreateCountryLink(string countryName)
        {
            ENPais pais = new ENPais();
            pais.name = countryName;
            if (pais.ReadPais())
            {
                HyperLink h = CreateCountryLink(pais.id);
                return h;
            }
            else { return null; }
        }

        /// <summary>
        /// Confirma los cambios en la edición de la página
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_aceptar_cambios_Click(object sender, EventArgs e)
        {
            if (stories_title_edit.Text != "")
            {
                Application["stories_title"] = stories_title_edit.Text;
            }
            if (stories_subtitle_edit.Text != "")
            {
                Application["stories_subtitle"] = stories_subtitle_edit.Text;
            }
            if (stories_description_title_edit.Text != "")
            {
                stories_description_title.Text = stories_description_title_edit.Text;
            }
            if (stories_description_edit.Text != "")
            {
                stories_description.Text = stories_description_edit.Text;
            }

            Response.Redirect("/stories");

        }

        /// <summary>
        /// Cancela los cambios en la edición de la página
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_cancelar_cambios_Click(object sender, EventArgs e)
        {
            Response.Redirect("/stories");
        }
    }
}