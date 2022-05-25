using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

namespace FirstRow.Pages.Forms
{
    public partial class Formadmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ENAdmin admin = new ENAdmin();
            ENUsuario usuario = new ENUsuario();
            
            Error.Text = "";
            Error.Visible = false;
            if (!IsPostBack)
            {
                try
                {
                    if (Session["usuario"] == null)
                    {
                        Response.Redirect("/");
                    }
                    else
                    {
                        usuario = (ENUsuario)Session["usuario"];
                        if (usuario.nickname != "admin") 
                        {
                            throw new Exception("Usuario no valido");
                        }
                    }
                }
                catch (Exception exception) 
                {
                    Response.Redirect("/403");
                }
            }
        }

        protected void btnCrea_Click(object sender, EventArgs e)
        {
                
        }
    }
}