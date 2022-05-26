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
    public partial class FormPropuesta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CrearPropuesta(object sender, EventArgs e)
        {
            Random rand = new Random();
            ENPropuestas propuesta = new ENPropuestas();
            ENUsuario usuario = (ENUsuario)Session["usuario"];

            propuesta.Titulo = create_propuesta_title.Text.Trim();
            propuesta.Descripcion = create_propuesta_descripcion.Text.Trim();
            propuesta.Slug = Home.slug(propuesta.Titulo) + "-" + rand.Next(1, 999999).ToString();
            propuesta.Usuario.nickname = usuario.nickname;

            foreach (HttpPostedFile imagenes in crear_propuesta_imagenes.PostedFiles)
            {
                if (crear_propuesta_imagenes.HasFiles)
                {
                    string imagen = propuesta.Slug + "-propuesta-" + Path.GetFileName(imagenes.FileName);
                    propuesta.Imagenes.Add(new ENImagenes(imagen));
                    imagenes.SaveAs(Server.MapPath("~/Media/Propuestas/") + imagen);
                }
            }
            if (propuesta.newPropuesta())
            {
                Response.Redirect("/propuesta/" + "/" + propuesta.Slug);
            }
            else
            {
                resultado.Text = "Ha ocurrido un error";
            }

        }

    }
    }
  
        