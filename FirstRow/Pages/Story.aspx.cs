﻿using System;
using library;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstRow.Pages
{
    public partial class Storie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            firstStory(sender, e); //¿?
        }

        protected void crearStorie(object sender, EventArgs e)
        {
            //COMPLETAR -- redirigir a formulario??
        }

        protected void modificarStorie(object sender, EventArgs e)
        {
            //COMPLETAR -- redirigir a formulario??
        }

        protected void verUsuario(object sender, EventArgs e)
        {
            //COMPLETAR
        }

        protected void eliminarStorie(object sender, EventArgs e)
        {
            //COMPLETAR
        }

        protected void nextStory(object sender, EventArgs e)
        {
            //ENStories story = new ENStories();
            //authorLabel.Text = "";
            //COMPLETAR
        }

        protected void prevStory(object sender, EventArgs e)
        {
            //COMPLETAR
        }

        protected void firstStory(object sender, EventArgs e)
        {
            ENStories story = new ENStories();
            //story.Pais = (int) Session["story_pais"]; //¿?
            if (story.ReadFirstStory())
            {
                //mostrar la story en la página
                showStory(story);
                
            }
            
            //COMPLETAR
        }

        private void showStory(ENStories story)
        {
            //COMPLETAR
        }
    }
}