using library;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstRow
{
    public partial class Home : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarElementosSesion();
        }

        protected void registrarse(object sender, EventArgs e)
        {
            ENUsuario usuario = new ENUsuario();
            usuario.nickname = registro_nickname.Text;
            usuario.email = registro_email.Text;
            usuario.password = password_r_1.Text;
            usuario.image = "default.png";
            usuario.background_image = "bg_default.png";
            usuario.name = registro_nombre.Text;
            usuario.firstname = registro_apellido_1.Text;
            usuario.secondname = registro_apellido_2.Text;
            usuario.twitter = registro_twitter.Text;
            usuario.facebook = registro_facebook.Text;

            if (usuario.registerUsuario())
            {
                registro_salida.Text = "Usuario creado correctamente. Bienvenido a FirstRow.";
            }
            else
            {
                registro_salida.Text = "El nickname o el email ya existen.";
                Page.ClientScript.RegisterClientScriptBlock(GetType(), "login_rollback", "document.addEventListener('load', function () {document.getElementById('register_user_pop_up').click();}, true);", true);
            }
        }

        protected void registrarEmpresa(object sender, EventArgs e)
        {
            ENEmpresa empresa = new ENEmpresa();
            empresa.nickname = registro_emp_nickname.Text;
            empresa.email = registro_emp_email.Text;
            empresa.password = password_emp_r_1.Text;
            empresa.image = "default.png";
            empresa.background_image = "bg_default.png";
            empresa.name = registro_emp_nombre.Text;
            empresa.firstname = registro_emp_apellido_1.Text;
            empresa.secondname = registro_emp_apellido_2.Text;
            empresa.twitter = registro_emp_twitter.Text;
            empresa.facebook = registro_emp_facebook.Text;
            empresa.cif = registro_emp_cif.Text;
            empresa.direccion = registro_emp_direccion.Text;
            empresa.fechaCreacion = DateTime.Now;

            ENPais pais = new ENPais();
            List<ENPais> listaPaises = new List<ENPais>();
            pais.readPaises(listaPaises);
            empresa.pais = (ENPais)listaPaises[Int32.Parse(listaPaisesRegEmpresa.SelectedValue)-1];


            if (empresa.registerEmpresa())
            {
                registro_emp_salida.Text = "Empresa creada correctamente. Bienvenido a FirstRow Enterprise.";
            }
            else
            {
                registro_emp_salida.Text = "El nickname o el email ya existen.";
                Page.ClientScript.RegisterClientScriptBlock(GetType(), "login_rollback", "document.addEventListener('load', function () {document.getElementById('register_emp_pop_up').click();}, true);", true);
            }
        }

        protected void iniciarSesion(object sender, EventArgs e)
        {
            ENUsuario usuario = new ENUsuario();
            usuario.nickname = nickname.Text;
            usuario.password = password.Text;

            vaciadoCampos();

            if (usuario.loginUsuario())
            {
                Session["usuario"] = usuario;
                Response.Redirect("/");
            }
            {
                salida.Text = "Usuario o contraseña incorrectos";
                Page.ClientScript.RegisterClientScriptBlock(GetType(), "login_rollback", "document.addEventListener('load', function () {document.getElementById('login_user_pop_up').click();}, true);", true);
            }
        }

        protected void iniciarSesionEmpresa(object sender, EventArgs e)
        {
            ENEmpresa empresa = new ENEmpresa();
            empresa.email = login_email_empresa.Text;
            empresa.password = login_password_empresa.Text;

            vaciadoCampos();

            if (empresa.loginEmpresa())
            {
                Session["empresa"] = empresa;
                Response.Redirect("/");
            }
            else
            {
                salida_login_empresa.Text = "Email o contraseña incorrectos";
                Page.ClientScript.RegisterClientScriptBlock(GetType(), "login_rollback", "document.addEventListener('load', function () {document.getElementById('login_emp_pop_up').click();}, true);", true);

            }
        }

        protected void cerrarSesion(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("/");
        }

        private void vaciadoCampos()
        {
            nickname.Text = "";
            password.Text = "";
        }

        protected void cargarElementosSesion()
        {
            ENPais pais = new ENPais();
            List<ENPais> paises = new List<ENPais>();
            pais.readPaises(paises);

            if (Session["usuario"] != null)
            {
                ENUsuario usuario = (ENUsuario)Session["usuario"];

                nickname_settings.Text = usuario.nickname;
                email_setting.Text = usuario.email;
                name_setting.Text = usuario.name;
                firstname_setting.Text = usuario.firstname;
                secondname_setting.Text = usuario.secondname;

                login_sect.Visible = false;
                register_sect.Visible = false;
                settings_sect.Visible = true;
                settings_emp_sect.Visible = false;
                logout_sect.Visible = true;

            }
            else if (Session["empresa"] != null)
            {
                ENEmpresa empresa = (ENEmpresa)Session["empresa"];

                foreach (ENPais p in paises)
                {
                    listaPaises_ajustes_empresa.Items.Insert(0, new ListItem(p.name, p.id.ToString()));
                }

                listaPaises_ajustes_empresa.SelectedIndex = paises.Count-empresa.pais.id;
                ajustes_nickname_empresa.Text = empresa.nickname;
                ajustes_email_empresa.Text = empresa.email;
                ajustes_nombre_empresa.Text = empresa.name;
                ajustes_apellido_1_empresa.Text = empresa.firstname;
                ajustes_apellido_2_empresa.Text = empresa.secondname;
                ajustes_cif_empresa.Text = empresa.cif;
                ajustes_direccion_empresa.Text = empresa.direccion;
                ajustes_facebook_empresa.Text = empresa.facebook;
                ajustes_twitter_empresa.Text = empresa.twitter;

                login_sect.Visible = false;
                register_sect.Visible = false;
                settings_sect.Visible = false;
                settings_emp_sect.Visible = true;
                logout_sect.Visible = true;
            }
            else
            {
                foreach (ENPais p in paises)
                {
                    listaPaisesRegEmpresa.Items.Insert(0, new ListItem(p.name, p.id.ToString()));
                }

                login_sect.Visible = true;
                register_sect.Visible = true;
                settings_sect.Visible = false;
                settings_emp_sect.Visible = false;
                logout_sect.Visible = false;
            }
        }
    }
}