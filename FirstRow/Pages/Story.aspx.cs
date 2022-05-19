﻿using System;
using library;
using System.Web.Routing;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace FirstRow.Pages
{
    public partial class Story : System.Web.UI.Page
    {
        const string default_img = "https://img5.goodfon.com/wallpaper/nbig/5/d9/italiia-gorod-poberezhe-riomadzhore-doma-zdaniia-vecher-more.jpg";

        string pais_name = "";
        int pais_id = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarElementosSesion();
            if (!Page.IsPostBack)
            {
                if (RouteData.Route is Route myRoute && myRoute.Url == "story/{slug}")
                {
                    string cadena = char.ToUpper(RouteData.Values["slug"].ToString()[0]) + RouteData.Values["slug"].ToString().Substring(1);
                    pais_name = cadena.Replace("-", " ");
                    ENPais pais = new ENPais();

                    pais.name = pais_name;

                    if (!pais.ReadPais())
                    {
                        Response.Redirect("/404");

                    }

                    pais_id = pais.id;
                    pais_name = pais.name;
                    if (Session["usuario"] != null)
                    {
                        crear_story.Visible = true;
                    }
                    else
                    {
                        crear_story.Visible = false;

                    }

                    //country_span.InnerText = pais_name;
                    left_bottom_title.InnerText = pais_name;

                }

                loadStories();

                //default_story_panel.BackImageUrl = example_img;
                //default_story_panel.Attributes["data-blur-bg"] = example_img;

                //addDefaultStory();
                //firstStory(sender, e); //¿?

                //imagen por defecto (fondo plateado): https://img.freepik.com/vector-gratis/resumen-fondo-plateado-claro_67845-796.jpg

            }
        }

        /*
        protected void crearStory(object sender, EventArgs e)
        {
            //Response.Redirect("/agregar-story");
        }
        */
        /*
        protected void modificarStory(object sender, EventArgs e)
        {
            //COMPLETAR -- redirigir a formulario??
        }
        */

        protected void eliminarStory(object sender, EventArgs e)
        {
            //COMPLETAR
        }

        private Panel createStoryPanel(string title, string text, string user, string date)
        {
            Panel p = new Panel();
            p.CssClass = "item";

            
            Panel info = new Panel();
            info.CssClass = "_info";
            Panel country = new Panel();
            country.CssClass = "country";
            Label country_span = new Label();
            country_span.Text = pais_name;
            country.Controls.Add(country_span);
            info.Controls.Add(country);            
            p.Controls.Add(info);

            Label titulo = new Label();
            titulo.CssClass = "_title";
            titulo.Text = title;
            p.Controls.Add(titulo);

            Label texto = new Label();
            texto.CssClass = "_text";
            texto.Text = text;
            p.Controls.Add(texto);

            HyperLink autor = new HyperLink();
            autor.NavigateUrl = $"/user/{user}";
            autor.CssClass = "_text";
            autor.Style.Add("font-size", "15px");
            autor.Style.Add("color", "rgba(255, 255, 255, 0.61)");
            autor.Text = date + " by " + user;
            p.Controls.Add(autor);

            return p;
        }

        /**
         * probablemente no lo use
         * se me ocurre otra forma mejor de hacerlo
         * :)
         */
        /*
        protected void firstStory(object sender, EventArgs e) 
        {
            ENStories story = new ENStories();
            //ENPais pais = new ENPais();
            //pais.name = pais_name;
            story.Pais = pais_id;

            if (story.ReadFirstStory())
            {
                //mostrar la story en la página
                Panel p = createStoryPanel(story.Titulo, story.Descripcion);
                stories_items.Controls.Add(p);
                //showStory(story);

            }
            else { addDefaultStory(); }
            
            //COMPLETAR
        }*/

        private void loadStories()
        {

            List<ENStories> listStories = new List<ENStories>();
            if (ENStories.ReadAllStories(listStories, pais_id)) //, pais_id
            {
                if (listStories.Count == 0)
                {
                    addDefaultStory();
                }
                else
                {
                    foreach (ENStories story in listStories)
                    {
                        addStory(story);
                    }

                }

            }
            else { addDefaultStory(); }
            

        }

        private void addDefaultStory()
        {
            ENStories story = new ENStories();
            story.Titulo = "NO HIT story";
            story.Descripcion = "ce n'est pas une histoire";
            ENUsuario user = new ENUsuario();
            user.nickname = "FirstRow GOD";
            story.Usuario = user;
            story.Imagen = default_img;
            addStory(story);
        }

        private void addStory(ENStories story)
        {
            Panel p = createStoryPanel(story.Titulo, story.Descripcion, story.Usuario.nickname, story.Fecha.ToString("dd.MM.yyyy"));
            if (story.Imagen == "")
            {
                p.BackImageUrl = default_img;
                p.Attributes["data-blur-bg"] = default_img;
                //h.Style.Add("background-image", $"url(../assets/img/default.jpg)");
            }
            else
            {
                try
                {
                    if (File.Exists(Server.MapPath($"~/Media/Stories/{story.Imagen}")))
                    {
                        //string img = Server.MapPath($"~/Media/Stories/{story.Imagen}");
                        string img = $"../Media/Stories/{story.Imagen}";
                        p.BackImageUrl = img;
                        p.Attributes["data-blur-bg"] = img;
                    
                    }
                    else
                    {
                        p.BackImageUrl = default_img;
                        p.Attributes["data-blur-bg"] = default_img;
                    }

                }catch(Exception)
                {
                    p.BackImageUrl = default_img;
                    p.Attributes["data-blur-bg"] = default_img;
                }
            }
            stories_items.Controls.Add(p);
        }



        //master
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
                    perfil_li.Visible = true;

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
                    perfil_li.Visible = true;
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
                    perfil_li.Visible = false;
                }
            }
        }

    }
}