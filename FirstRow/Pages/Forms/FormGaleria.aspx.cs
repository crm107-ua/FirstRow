using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace FirstRow.Pages.Forms
{
    public partial class FormGaleria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillDestinos();

                if (Session["usuario"] != null)
                {
                }
                else
                {
                    Response.Redirect("/");
                }
            }

        }

        private void fillDestinos() 
        {
            ENPais pais = new ENPais();
            List<ENPais> paises = new List<ENPais>();
            pais.readPaises(paises);

            foreach (ENPais p in paises)
            {
                listaPaises_form_galeria.Items.Insert(0, new ListItem(p.name, p.id.ToString()));
            }
            listaPaises_form_galeria.Items.Insert(0, new ListItem("-- Destination --", "-1"));
        }

        protected void btnCrea_Click(object sender, EventArgs e)
        {
            HttpFileCollection _HttpFileCollection = Request.Files;

            //Primero validar los datos

            string titulo=create_galeria_title.Text.Trim();

            if (_HttpFileCollection.Count > 6)
            {
                
            }
            else
            {
                for (int i = 0; i < _HttpFileCollection.Count; i++)
                {
                    HttpPostedFile _HttpPostedFile = _HttpFileCollection[i];
                    if (_HttpPostedFile.ContentLength > 0) _HttpPostedFile.SaveAs(Server.MapPath("~/Media/Galery" + Path.GetFileName(_HttpPostedFile.FileName)));
                }
            }
        }
    }
}