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
using System.Data;

namespace FirstRow.Pages.Forms
{
    public partial class FormStory : System.Web.UI.Page
    {
        const int description_maxlength = 100;

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
        
        private void ServerValidation_description_maxlength(object source, ServerValidateEventArgs args)
        {
            int description_length = create_story_descripcion.Text.Length;
            if (description_length <= description_maxlength)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        /// <summary>
        /// llena el dropDownList con los paises
        /// </summary>
        private void fillDestinos()
        {
            DataSet ds = new DataSet();
            if (ENPais.ReadPaisesDataSet(ds))
            {
                //country_list.Attributes.Add("style", "font-size: 18px");
                listaPaises_form_story.DataSource = ds;
                listaPaises_form_story.DataTextField = "name";
                listaPaises_form_story.DataValueField = "id";
                listaPaises_form_story.DataBind();

            }
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

            if (create_story_descripcion.Text.Length > description_maxlength)
            {
                ErrorDesc.Text = $"*Longitud máxima de descripción({description_maxlength}) superada";
                ErrorDesc.Visible = true;
                return;
            }

            
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
                            try
                            {
                                if (p.ReadPais())
                                {
                                    Response.Redirect("/story/" + p.name);
                                }
                                else
                                {
                                    Response.Redirect("/stories");
                                }

                            }
                            catch (System.Threading.ThreadAbortException) { }

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