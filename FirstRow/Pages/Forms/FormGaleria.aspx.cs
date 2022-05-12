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
            Error.Text = "";
            Error.Visible = false;
            if (!IsPostBack)
            {
                fillDestinos();

                if (Session["usuario"] != null)
                {
                }
                else
                {
                    if (Session["empresa"] != null)
                    {
                    }
                    else
                    {
                        //Response.Redirect("/");
                    }
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

            //string titulo=create_galeria_title.Text.Trim();
            
            if (_HttpFileCollection.Count > 10)
            {
                Error.Text = "*Maximo 6 imagenes";
                Error.Visible = true;
            }
            
            else
            {
                Error.Visible = false;
                for (int i = 0; i < _HttpFileCollection.Count; i++)
                {
                    HttpPostedFile _HttpPostedFile = _HttpFileCollection[i];
                    if (_HttpPostedFile.ContentLength > 0) _HttpPostedFile.SaveAs(Server.MapPath("~/Media/Galery/" + Path.GetFileName(_HttpPostedFile.FileName)));
                }
            }
        }
    }
}