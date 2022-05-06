using library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstRow.Pages
{
    public partial class Galeria : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
                llenarDropDownList();
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
    }
}