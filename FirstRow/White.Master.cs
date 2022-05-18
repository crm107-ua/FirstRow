using library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
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
            usuario.image = guardadoFotoPerfil(true, usuario.nickname);
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
            }
            Page.ClientScript.RegisterClientScriptBlock(GetType(), "register_user_rollback", "setTimeout(ClickTheLink,500); function ClickTheLink() { document.getElementById('register_user_pop_up').click(); }", true);

        }

        protected void registrarEmpresa(object sender, EventArgs e)
        {
            ENEmpresa empresa = new ENEmpresa();
            empresa.nickname = registro_emp_nickname.Text;
            empresa.email = registro_emp_email.Text;
            empresa.password = password_emp_r_1.Text;
            empresa.image = guardadoFotoPerfil(false, empresa.nickname);
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
            empresa.pais.id = Int32.Parse(listaPaisesRegEmpresa.SelectedItem.Value);


            if (empresa.registerEmpresa())
            {
                registro_emp_salida.Text = "Empresa creada correctamente. Bienvenido a FirstRow Enterprise.";
            }
            else
            {
                registro_emp_salida.Text = "El nickname o el email ya existen.";
            }
            Page.ClientScript.RegisterClientScriptBlock(GetType(), "register_emp_rollback", "setTimeout(ClickTheLink,500); function ClickTheLink() { document.getElementById('register_emp_pop_up').click(); }", true);
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
                Response.Redirect(Request.Url.ToString());
            }
            else
            {
                salida.Text = "Usuario o contraseña incorrectos";
                Page.ClientScript.RegisterClientScriptBlock(GetType(), "login_user", "setTimeout(ClickTheLink,500); function ClickTheLink() { document.getElementById('login_user_pop_up').click(); }", true);
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
                Response.Redirect(Request.Url.ToString());
            }
            else
            {
                salida_login_empresa.Text = "Email o contraseña incorrectos";
                Page.ClientScript.RegisterClientScriptBlock(GetType(), "login_emp", "setTimeout(ClickTheLink,500); function ClickTheLink() { document.getElementById('login_emp_pop_up').click(); }", true);

            }
        }

        protected void modificarUsuario(object sender, EventArgs e)
        {
            ENUsuario usuario = new ENUsuario();
            ENUsuario usuarioSesion = (ENUsuario)Session["usuario"];

            usuario.nickname = usuarioSesion.nickname;
            usuario.email = email_setting.Text;
            usuario.password = password_1_setting.Text;
            usuario.image = modificarFotoPerfil(true, usuarioSesion.nickname, usuarioSesion.image);
            usuario.background_image = "bg_default.png";
            usuario.name = name_setting.Text;
            usuario.firstname = firstname_setting.Text;
            usuario.secondname = secondname_setting.Text;
            usuario.facebook = facebook_setting.Text;
            usuario.twitter = twitter_setting.Text;

            if (usuario.updateUsuario())
            {
                Session["usuario"] = usuario;
                user_setting_foto.ImageUrl = usuario.image;
                salida_ajustes_usuario.Text = "Usuario modificado correctamente.";
            }
            else
            {
                salida_ajustes_usuario.Text = "El email ya existe.";
            }

            Page.ClientScript.RegisterClientScriptBlock(GetType(), "mod_user_rollback", "setTimeout(ClickTheLink,500); function ClickTheLink() { document.getElementById('settings_user_pop_up').click(); }", true);
        }

        protected void modificarEmpresa(object sender, EventArgs e)
        {
            ENEmpresa empresa = new ENEmpresa();
            ENEmpresa empresaSesion = (ENEmpresa)Session["empresa"];
            ENPais pais = new ENPais();
            List<ENPais> paises = new List<ENPais>();
            pais.readPaises(paises);

            empresa.nickname = empresaSesion.nickname;
            empresa.email = empresaSesion.email;
            empresa.password = ajustes_password_1_empresa.Text;
            empresa.image = modificarFotoPerfil(false, empresaSesion.nickname, empresaSesion.image);
            empresa.background_image = "bg_default.png";
            empresa.name = ajustes_nombre_empresa.Text;
            empresa.firstname = ajustes_apellido_1_empresa.Text;
            empresa.secondname = ajustes_apellido_2_empresa.Text;
            empresa.facebook = ajustes_facebook_empresa.Text;
            empresa.twitter = ajustes_twitter_empresa.Text;
            empresa.cif = ajustes_cif_empresa.Text;
            empresa.direccion = ajustes_direccion_empresa.Text;
            empresa.pais.id = Int32.Parse(listaPaises_ajustes_empresa.SelectedItem.Value);

            if (empresa.updateEmpresa())
            {
                Session["empresa"] = empresa;
                ajustes_imagen_empresa.ImageUrl = empresa.image;
                listaPaises_ajustes_empresa.Items.FindByText(empresa.pais.name).Selected = true;
            }
            else
            {
                salida_ajustes_empresa.Text = "El email ya existe.";
            }
            Page.ClientScript.RegisterClientScriptBlock(GetType(), "mod_emp_rollback", "setTimeout(ClickTheLink,500); function ClickTheLink() { document.getElementById('settings_emp_pop_up').click(); }", true);
        }

        protected void cerrarSesion(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect(Request.Url.ToString());
        }

        private void vaciadoCampos()
        {
            nickname.Text = "";
            password.Text = "";
            login_email_empresa.Text = "";
            login_password_empresa.Text = "";
        }

        private string guardadoFotoPerfil(bool mode, string nickname)
        {
            string direccion = "~/Media/Users/";

            if (mode)
            {
                // Guardado de imagen de usuario: foto_perfil
                if (foto_perfil.HasFile)
                {
                    string file_name = nickname + "_" + Path.GetFileName(foto_perfil.PostedFile.FileName);
                    foto_perfil.SaveAs(Server.MapPath(direccion + file_name));
                    return direccion + file_name;
                }
            }
            else
            {
                // Guardado de imagen de usuario: foto_perfil_empresa
                if (foto_perfil_empresa.HasFile)
                {
                    string file_name = nickname + "_" + Path.GetFileName(foto_perfil_empresa.PostedFile.FileName);
                    foto_perfil_empresa.SaveAs(Server.MapPath(direccion + file_name));
                    return direccion + file_name;
                }
            }

            return "default.png";
        }

        private string modificarFotoPerfil(bool mode, string nickname, string deff)
        {
            string direccion = "~/Media/Users/";

            if (mode)
            {
                // Guardado de imagen de usuario: ajustes_foto_perfil
                if (user_setting_foto_mode.HasFile)
                {
                    string file_name = nickname + "_" + Path.GetFileName(user_setting_foto_mode.PostedFile.FileName);
                    user_setting_foto_mode.SaveAs(Server.MapPath(direccion + file_name));
                    return direccion + file_name;
                }
            }
            else
            {
                // Guardado de imagen de usuario: ajustes_foto_perfil_empresa
                if (ajustes_imagen_empresa_mode.HasFile)
                {
                    string file_name = nickname + "_" + Path.GetFileName(ajustes_imagen_empresa_mode.PostedFile.FileName);
                    ajustes_imagen_empresa_mode.SaveAs(Server.MapPath(direccion + file_name));
                    return direccion + file_name;
                }
            }

            return deff;
        }

        protected void cargarElementosSesion()
        {
            if (!IsPostBack)
            {
                ENPais pais = new ENPais();
                List<ENPais> paises = new List<ENPais>();
                pais.readPaises(paises);

                if (Session["usuario"] != null)
                {
                    ENUsuario usuario = (ENUsuario)Session["usuario"];

                    email_setting.Text = usuario.email;
                    name_setting.Text = usuario.name;
                    password_1_setting.Text = usuario.password;
                    password_2_setting.Text = usuario.password;
                    firstname_setting.Text = usuario.firstname;
                    secondname_setting.Text = usuario.secondname;
                    facebook_setting.Text = usuario.facebook;
                    twitter_setting.Text = usuario.twitter;
                    user_setting_foto.ImageUrl = usuario.image;

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

                    listaPaises_ajustes_empresa.SelectedIndex = paises.Count - empresa.pais.id;
                    ajustes_password_1_empresa.Text = empresa.password;
                    ajustes_password_2_empresa.Text = empresa.password;
                    ajustes_nombre_empresa.Text = empresa.name;
                    ajustes_apellido_1_empresa.Text = empresa.firstname;
                    ajustes_apellido_2_empresa.Text = empresa.secondname;
                    ajustes_cif_empresa.Text = empresa.cif;
                    ajustes_direccion_empresa.Text = empresa.direccion;
                    ajustes_facebook_empresa.Text = empresa.facebook;
                    ajustes_twitter_empresa.Text = empresa.twitter;
                    ajustes_imagen_empresa.ImageUrl = empresa.image;

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

        public static string slug(string value)
        {
            //First to lower case 
            value = value.ToLowerInvariant();

            //Remove all accents
            var bytes = Encoding.GetEncoding("Cyrillic").GetBytes(value);

            value = Encoding.ASCII.GetString(bytes);

            //Replace spaces 
            value = Regex.Replace(value, @"\s", "-", RegexOptions.Compiled);

            //Remove invalid chars 
            value = Regex.Replace(value, @"[^\w\s\p{Pd}]", "", RegexOptions.Compiled);

            //Trim dashes from end 
            value = value.Trim('-', '_');

            //Replace double occurences of - or \_ 
            value = Regex.Replace(value, @"([-_]){2,}", "$1", RegexOptions.Compiled);

            return value;
        }

    }
}