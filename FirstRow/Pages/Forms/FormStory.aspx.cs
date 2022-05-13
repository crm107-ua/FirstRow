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
    public partial class FormStory : System.Web.UI.Page
    {
        private ENStories seccion_story;
        protected void Page_Load(object sender, EventArgs e)
        {
            Error.Text = "";
            Error.Visible = false;
            if (!IsPostBack)
            {
                seccion_story = new ENStories();

                if (Session["usuario"] != null)
                {
                    seccion_story.Usuario = (ENUsuario)Session["usuario"];
                }
                else
                {
                    //Response.Redirect("/");
                }
            }
        }

        protected void btnCrea_Click(object sender, EventArgs e)
        {
            
        }
    }
}