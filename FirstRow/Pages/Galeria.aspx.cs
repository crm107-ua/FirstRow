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


/*
 * Galeria se encarga de mostrar todas las galerias
 * Para ello usa el slug para el filtrado /galeia/{slug}
 */
namespace FirstRow.Pages
{
    public partial class Galeria : System.Web.UI.Page
    {

        /**
         * Llenado de lista paises más carga dinamica de galerias
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                llenarDropDownList();
                Title_gal.Text= ENAdmin.read("titulo-gal");
                Description_gal.Text = ENAdmin.read("des-gal"); 
                

                if (Session["usuario"] != null)
                {
                    add.Visible = true;
                }
                else
                {
                    add.Visible = false;
                }

                Route myRoute = RouteData.Route as Route;
                ENPais pais = new ENPais();

                if (myRoute != null && myRoute.Url == "galeria/{pais}") 
                {
                    pais.name = char.ToUpper(RouteData.Values["pais"].ToString()[0]) + RouteData.Values["pais"].ToString().Substring(1);
                }

                if (pais.ReadPais())
                {
                    //Carga la listaen el elemento que seelijo
                    Direccion.SelectedIndex = Direccion.Items.IndexOf(Direccion.Items.FindByText(pais.name));
                    rellenarGalerias(pais);
                }
                else
                {
                    rellenarGalerias(new ENPais());
                }
            }
        }
        
        /**
         * Rellena la lista de paises segun la DBD
         */
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

        //Lista de filtrado
        protected void Direccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Direccion.SelectedValue != "-1")
            {
                Page.Response.Redirect("/galeria/"+Direccion.SelectedItem.Text);
            }
            else 
            {
                Page.Response.Redirect("/galeria");
            }
            //Cambio en el filtrado
        }

        //Carga dinamica de las galerias con objetos control
        private void rellenarGalerias(ENPais pais) 
        {
            List<ENGaleria> galerias=new List<ENGaleria>();
            CADGaleria cadGaleria=new CADGaleria();

            if (pais.name == "")
                cadGaleria.readAllGaleri(galerias);
            else
                cadGaleria.readAllCountyGaleri(galerias,pais);


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

                //<p class="title">Las preciosas aves de Australia</p>
                HtmlGenericControl title = new HtmlGenericControl("p");
                title.Attributes.Add("class","title");

                HtmlGenericControl title_text = new HtmlGenericControl("span");
                title_text.InnerText = galeria.Titulo;

                HtmlGenericControl imagenes = new HtmlGenericControl("div");
                imagenes.Attributes.Add("class", "images");

                HtmlGenericControl scrol_imagenes = new HtmlGenericControl("div");
                scrol_imagenes.Attributes.Add("class", "scroll");

                foreach (ENImagenes imagenGaleria in galeria.Imagenes) 
                {
                    HtmlGenericControl imagenes_galeria = new HtmlGenericControl("div");
                    imagenes_galeria.Attributes.Add("class", "img");

                    HtmlGenericControl imagen = new HtmlGenericControl("img");
                    imagen.Attributes.Add("src", "/Media/Galery/"+imagenGaleria.Name);

                    imagenes_galeria.Controls.Add(imagen);
                    scrol_imagenes.Controls.Add(imagenes_galeria);
                }

                country.Controls.Add(texto_pais);
                title.Controls.Add(title_text);
                galeria_item_top.Controls.Add(country);
                galeria_item_top.Controls.Add(title);
                imagenes.Controls.Add(scrol_imagenes);

                a_tag_general.Controls.Add(galeria_item_top);
                a_tag_general.Controls.Add(imagenes);

                mostrar_galerias.Controls.Add(a_tag_general);
            }
        }
    }
}