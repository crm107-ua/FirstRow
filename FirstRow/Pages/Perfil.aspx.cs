using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstRow.Pages
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargaElementos();
        }

        private void cargaElementos()
        {
            if (Session["usuario"] != null)
            {
                ENUsuario usuario = (ENUsuario)Session["usuario"];
                tipo.InnerHtml = "Tu cuenta de usuario";
                name_titulo_text.InnerText = "¡Hola " + usuario.name + "!";
                nickname_text.InnerText = "Nickname: " + usuario.nickname;
                email_text.InnerText = "Email: " +  usuario.email;
                name_text.InnerText = "Name: " +  usuario.name;
                firstname_text.InnerText = "FirstName: " +  usuario.firstname;
                secondname_text.InnerText = "SecondName: " +  usuario.secondname;
                face_text.InnerText = "Facebook: " +  usuario.facebook;
                tw_text.InnerText = "Twitter: " +  usuario.twitter;
                foto_perfil.Src = usuario.image;
                settings_user_pop_up.Visible = true;
                settings_emp_pop_up.Visible = false;
            }
            else if (Session["empresa"] != null)
            {
                ENEmpresa empresa = (ENEmpresa)Session["empresa"];
                tipo.InnerHtml = "Tu cuenta de empresa";
                name_titulo_text.InnerText = "¡Hola " + empresa.name + "!";
                nickname_text.InnerText = "Nickname: " + empresa.nickname;
                email_text.InnerText = "Email: " + empresa.email;
                name_text.InnerText = "Name: " + empresa.name;
                firstname_text.InnerText = "FirstName: " + empresa.firstname;
                secondname_text.InnerText = "SecondName: " + empresa.secondname;
                face_text.InnerText = "Facebook: " + empresa.facebook;
                tw_text.InnerText = "Twitter: " + empresa.twitter;
                foto_perfil.Src = empresa.image;
                cif_text.InnerText = "CIF: " + empresa.cif;
                direccion_text.InnerText = "Dirección: " + empresa.direccion;
                fecha_text.InnerText = "Fecha de creación: " + empresa.fechaCreacion.ToString("dd/MM/yyyy");
                pais_text.InnerText = "Pais: " + empresa.pais.name;
                settings_user_pop_up.Visible = false;
                settings_emp_pop_up.Visible = true;
            }
            else
            {
                Response.Redirect("/");
            }
        }
    }
}