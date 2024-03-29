﻿using library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FirstRow.Pages
{
    public partial class Sorteo : System.Web.UI.Page
    {
        private ENSorteos so;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cadena="";
            Route myRoute = RouteData.Route as Route;
            if (myRoute != null && myRoute.Url == "sorteo/{slug}")
            {
                cadena = char.ToUpper(RouteData.Values["slug"].ToString()[0]) + RouteData.Values["slug"].ToString().Substring(1);
                titulo.Text = slug.Text = cadena.Replace("-", " ");

            }
           so=new ENSorteos();
            so.Slug = slug.Text.ToString();
            so.readsorteo();
            Home.slug(so.Titulo.ToString());
            //background_image_header.Style.Add("background-image", "url(/Media/Sorteos/"+so.Imagen+")");
           
            describe.Text = so.Descripcion.ToString();
            empresa.Text=so.Titular.ToString();
            diaI.Text = so.FechaInicio.ToString("dd");
            mesI.Text = so.FechaInicio.ToString("MMMM");
            anioI.Text = so.FechaInicio.ToString("yyyy");

            diaF.Text = so.FechaFinal.ToString("dd");
            mesF.Text = so.FechaFinal.ToString("MMMM");
            anioF.Text = so.FechaFinal.ToString("yyyy");

            /*
             * Oculta el boton cuando el sorteo ha finalizado
            if (so.FechaFinal < DateTime.Now) 
            {
                participar_button.Visible = false;
            }
            */
            /*                                  
            participantes.Text =  so.readcantidad().ToString();
            */

        }
        protected void modificarSorteo(object sender, EventArgs e)
        {

        }
        protected void participarSorteo(object sender, EventArgs e)
        {
            if (Session["empresa"] != null)
            {
                participar_button.Attributes.Add("onClick", "return false;");
            }
            if (Session["usuario"] == null)
            {

                Page.ClientScript.RegisterClientScriptBlock(GetType(), "login_user", "setTimeout(ClickTheLink,500); function ClickTheLink() { document.getElementById('login_user_pop_up').click(); }", true);
            }
            else
            { 
                /*meterlo en la base de datos*/
                ENUsuario user = (ENUsuario)Session["usuario"];
                so.addParticipante(user);
                
                    /*el usuario ya ha participado*/
                 // participar_button.Visible = false;  
                participar_button.Attributes.Add("onClick","return false;");
            }

        }
        protected void salirSorteo(object sender, EventArgs e)
        {

        }
        protected void eliminarSorteo(object sender, EventArgs e)
        {

        }

    }

   

}