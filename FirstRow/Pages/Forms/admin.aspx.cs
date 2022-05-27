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


                ENAdmin eNAdmin = new ENAdmin();

                eNAdmin.readAll();
                create_admin_title_experiencia.Text = eNAdmin.TituloExperiencia;
                create_admin_tittle_blog.Text = eNAdmin.TituloBlog;
                create_admin_tittle_galeria.Text = eNAdmin.TituloGaleria;
                create_admin_tittle_sorteo.Text = eNAdmin.TituloSorteos;
                create_admin_tittle_storie.Text = eNAdmin.TituloStories;
                create_admin_descripcion.Text = eNAdmin.DescpExpperiencia;
                create_admin_descripcion_galeria.Text = eNAdmin.DescpGaleria;
                create_admin_descripcion_sorteos.Text = eNAdmin.DescpSorteos;
                create_admin_descripcion_stories.Text = eNAdmin.DescpStories;
                create_admin_descripcion_blogs.Text = eNAdmin.DecpBlog;
                create_admin_slogan.Text = eNAdmin.ContactoTexto1;
                create_admin_titulo.Text = eNAdmin.tituloPropuesta;
                create_admin_texto.Text = eNAdmin.textoPropuesta;
            }
        }

        protected void btnCrea_Click(object sender, EventArgs e)
        {

            ENAdmin eNAdmin = new ENAdmin();

            eNAdmin.TituloExperiencia= create_admin_title_experiencia.Text;
            eNAdmin.TituloBlog = create_admin_tittle_blog.Text;
            eNAdmin.TituloGaleria= create_admin_tittle_galeria.Text;
            eNAdmin.TituloSorteos = create_admin_tittle_sorteo.Text;
            eNAdmin.TituloStories = create_admin_tittle_storie.Text;
            eNAdmin.DescpExpperiencia = create_admin_descripcion.Text;
            eNAdmin.DescpGaleria= create_admin_descripcion_galeria.Text;
            eNAdmin.DescpSorteos = create_admin_descripcion_sorteos.Text;
            eNAdmin.DescpStories = create_admin_descripcion_stories.Text;
            eNAdmin.DecpBlog = create_admin_descripcion_blogs.Text;
            eNAdmin.ContactoTexto1 = create_admin_slogan.Text;
            eNAdmin.ContactoTexto2 = create_admin_info.Text;
            eNAdmin.tituloPropuesta = create_admin_titulo.Text;
            eNAdmin.textoPropuesta = create_admin_texto.Text;

            if (eNAdmin.modify())
            {
                Error.Visible = true;
                Error.Text = "Cambios realizados con exito";
            }
            else 
            {
                Error.Visible = true;
                Error.Text = "*Algo a salido mal";
            }

        }
    }
}