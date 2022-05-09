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
            if (Session["usuario"] != null)
            {
                ENPais pais = new ENPais();
                List<ENPais> paises = new List<ENPais>();
                pais.readPaises(paises);

                foreach (ENPais p in paises)
                {
                    listaPaises_form_experiencia.Items.Insert(0, new ListItem(p.name, p.id.ToString()));
                }
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(GetType(), "register_user_rollback", "setTimeout(ClickTheLink,500); function ClickTheLink() { document.getElementById('register_user_pop_up').click(); }", true);
            }

        }

        protected void btnCrea_Click(object sender, EventArgs e)
        {
            HttpFileCollection _HttpFileCollection = Request.Files;

            //Primero validar los datos

            string titulo=Tiulo.Text.Trim();

            if (_HttpFileCollection.Count > 6)
            {
                Mensaje.Text = "El numero de imagenes debe estar entre 1/6";
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