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
        protected void Page_Load(object sender, EventArgs e)
        {
            Error.Text = "";
            Error.Visible = false;
            if (!IsPostBack)
            {
                fillDestinos();

                if (Session["usuario"] == null)
                {
                    Response.Redirect("/");
                }
            }
        }

        /// <summary>
        /// llena el dropDownList con los paises
        /// </summary>
        private void fillDestinos()
        {
            ENPais pais = new ENPais();
            List<ENPais> paises = new List<ENPais>();
            pais.readPaises(paises);

            foreach (ENPais p in paises)
            {
                listaPaises_form_story.Items.Insert(0, new ListItem(p.name, p.id.ToString()));
            }
            //elemento por defecto
            listaPaises_form_story.Items.Insert(0, new ListItem("-- Destination --", "-1"));
        }

        /// <summary>
        /// Crea una story con los datos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCrea_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (listaPaises_form_story.SelectedValue == "-1")
            {
                Error.Text = "*Seleccione un país";
                Error.Visible = true;
            }
            else
            {
                Error.Visible = false;

                //guarda una imagen
                if (crear_story_imagen.HasFile)
                {
                    string imagen = rand.Next(1, 999999).ToString() + "-story-" + crear_story_imagen.FileName;
                    string ruta = "~/Media/Stories/" + imagen;
                    crear_story_imagen.SaveAs(Server.MapPath(ruta));

                    ENStories nuevaStory = new ENStories(
                        (ENUsuario)Session["usuario"], //usuario
                        DateTime.Now, //fecha
                        create_story_title.Text, //titulo
                        int.Parse(listaPaises_form_story.SelectedValue), //país
                        create_story_descripcion.Text, //descripción
                        imagen); //imagen

                    try
                    {
                        if (!nuevaStory.ReadStory())
                        {
                            if (nuevaStory.CreateStory())
                            {
                                Error.Text = "Creación exitosa";
                                Error.Visible = true;
                                ENPais p = new ENPais();
                                p.id = nuevaStory.Pais;
                                if (p.ReadPais())
                                {
                                    Response.Redirect("/stories/" + p.name);
                                }
                                else
                                {
                                    Response.Redirect("/stories");
                                }
                            }
                            else
                            {
                                Error.Text = "*ERROR: story no creada";
                                Error.Visible = true;

                                string filePath = Server.MapPath("~/Media/Stories/" + imagen);
                                File.Delete(filePath);
                            }
                        }
                        else
                        {
                            Error.Text = "*ERROR: story ya existente";
                            Error.Visible = true;
                        }

                    }catch(Exception ex)
                    {
                        Console.WriteLine("Story operation has failed.Error: {0}", ex.Message);
                    }
                }
                else
                {
                    Error.Text = "*ERROR: imagen no subida";
                    Error.Visible = true;
                }

                //se guardan los campor del form en la nueva story
                /*
                ENStories nuevaStory = new ENStories();
                nuevaStory.Titulo = create_story_title.Text;
                nuevaStory.Descripcion = create_story_descripcion.Text;
                nuevaStory.Fecha = DateTime.Now;
                nuevaStory.Pais = int.Parse(listaPaises_form_story.SelectedValue);
                nuevaStory.Usuario = (ENUsuario) Session["usuario"];
                nuevaStory.Imagen = imagen;
                nuevaStory.Id = ENStories.GenerateId(nuevaStory.Fecha, nuevaStory.Usuario);
                */
            }
        }
    }
}