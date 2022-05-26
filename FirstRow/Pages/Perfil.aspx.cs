using library;
using System;
using System.Collections.Generic;
using System.Data;
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
            getionDeReservas();
        }

        private void getionDeReservas()
        {
            ENReserva reserva = new ENReserva();
            if (Session["usuario"] != null)
            {
                ENUsuario usuario = (ENUsuario)Session["usuario"];
                DataTable tabla = reserva.mostrarReservasUsuario(usuario);
                reservasTabla.DataSource = tabla;
                reservasTabla.DataBind();
                scroll_top.Visible = false;

                if (tabla == null || tabla.Rows.Count == 0)
                {
                    titulo_tabla.InnerText = "No existen reservas";
                    scroll_reservas.Visible = false;
                }
                else
                {
                    scroll_reservas.Visible = true;
                }

            }
            else
            {
                ENEmpresa empresa = (ENEmpresa)Session["empresa"];
                DataTable tabla = reserva.mostrarReservasEmpresa(empresa.nickname);
                reservasTabla.DataSource = tabla;
                reservasTabla.DataBind();

                if (tabla == null || tabla.Rows.Count == 0)
                {
                    titulo_tabla.InnerText = "No existen reservas";
                    scroll_reservas.Visible = false;
                }
                else
                {
                    scroll_reservas.Visible = true;
                }

                DataTable top_table = reserva.mostrarTopClientes(empresa);
                top_clientes.DataSource = top_table;
                top_clientes.DataBind();
                
                if (tabla == null || top_table.Rows.Count == 0)
                {
                    top.InnerText = "No existen estadisticas disponibles";
                    scroll_top.Visible = false;
                }
                else
                {
                    scroll_top.Visible = true;
                }

            }
        }

        private void cargaElementos()
        {
            if (Session["usuario"] != null)
            {
                ENUsuario usuario = (ENUsuario)Session["usuario"];
                titulo_tabla.InnerText = "Tus reservas";
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
                user_stories_link.HRef = "/user-stories/" + ((ENUsuario)Session["usuario"]).nickname;
                user_stories_link.Visible = true;
                settings_user_pop_up.Visible = true;
                settings_emp_pop_up.Visible = false;

                top.InnerText = "";
                top_clientes.Visible = false;
            }
            else if (Session["empresa"] != null)
            {
                ENEmpresa empresa = (ENEmpresa)Session["empresa"];
                titulo_tabla.InnerText = "Todas las reservas de tus experiencias";
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

                top.InnerText = "Tus top 3 clientes";
                top_clientes.Visible = true;
            }
            else
            {
                Response.Redirect("/");
            }
        }
    }
}