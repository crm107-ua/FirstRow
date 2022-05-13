using library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FirstRow.Pages
{
    public partial class Galeria : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                llenarDropDownList();
                rellenarGalerias();

                if (Session["usuario"] != null)
                {
                    add_galeria.Visible = true;
                }
                else
                {
                    add_galeria.Visible = false;
                }
            }
        }

        private void llenarDropDownList()
        {
            DataSet ds = new DataSet();
            if (ENPais.ReadPaisesDataSet(ds))
            {
                //country_list.Attributes.Add("style", "font-size: 18px");
                Direccion.DataSource = ds;
                Direccion.DataTextField = "name";
                Direccion.DataValueField = "id";
                Direccion.DataBind();

            }

            Direccion.Items.Insert(0, new ListItem("-- Destination --", "-1"));
        }

        protected void VerMas_Click(object sender, EventArgs e)
        {
            //Cargar mas elementos de la galeria
        }

        protected void Direccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
            //Cambio en el filtrado
        }

        private void rellenarGalerias() 
        {
            List<ENGaleria> galerias=new List<ENGaleria>();
            CADGaleria cadGaleria=new CADGaleria();
            cadGaleria.readAllGaleri(galerias);

            foreach (ENGaleria galeria in galerias) 
            {
                HyperLink a_tag_general = new HyperLink();
                a_tag_general.CssClass = "gallery-item";
                a_tag_general.NavigateUrl = "/galeria/" + galeria.Slug;

                HtmlGenericControl galeria_item_top = new HtmlGenericControl("div");
                galeria_item_top.Attributes.Add("class", "top");

                HtmlGenericControl country = new HtmlGenericControl("p");
                country.Attributes.Add("class", "country");

                HtmlGenericControl texto_pais = new HtmlGenericControl("span");
                texto_pais.InnerText = galeria.Pais.name;

                HtmlGenericControl imagenes = new HtmlGenericControl("div");
                imagenes.Attributes.Add("class", "images");

                HtmlGenericControl scrol_imagenes = new HtmlGenericControl("div");
                scrol_imagenes.Attributes.Add("class", "scroll");

                foreach (ENImagenes imagenGaleria in galeria.Imagenes) 
                {
                    HtmlGenericControl imagenes_galeria = new HtmlGenericControl("div");
                    imagenes_galeria.Attributes.Add("class", "img");

                    HtmlGenericControl imagen = new HtmlGenericControl("img");
                    imagen.Attributes.Add("src", "../Media/Galery/"+imagenGaleria.Name);

                    imagenes_galeria.Controls.Add(imagen);
                    scrol_imagenes.Controls.Add(imagenes_galeria);
                }

                country.Controls.Add(texto_pais);
                galeria_item_top.Controls.Add(country);
                imagenes.Controls.Add(scrol_imagenes);

                a_tag_general.Controls.Add(galeria_item_top);
                a_tag_general.Controls.Add(imagenes);

                mostrar_galerias.Controls.Add(a_tag_general);
            }
        }
    }
}