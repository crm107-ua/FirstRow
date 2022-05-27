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
using library;

namespace FirstRow.Pages.Forms
{
    public partial class FormSorteo:System.Web.UI.Page
    {
        const int description_maxlength = 500;//cambiar en función del límite de la BD
        
        protected void Page_Load(object sender, EventArgs e)
        {
            fechainicio.ForeColor = System.Drawing.Color.LightGray;
            fechafinal.ForeColor = System.Drawing.Color.LightGray;
            if (!IsPostBack)
            {
                if (Session["empresa"] != null || true)
                {
                    ENPais pais = new ENPais();
                    List<ENPais> paises = new List<ENPais>();
                    pais.readPaises(paises);

                    ENViajes viaje = new ENViajes();
                    List<ENViajes> lista = new List<ENViajes>();
                    ENEmpresa empresa = (ENEmpresa)Session["empresa"];

                    empresa.readEmpresa();
                    viaje.mostrarExperienciasEmpresa(lista, empresa.nickname);
                    foreach (ENViajes v in lista)
                    {
                        //  listaPaises_form_experiencia.Items.Insert(0, new ListItem(p.name, p.id.ToString()));
                        listaexperiencias.Items.Insert(0, new ListItem(v.Nombre, v.Id.ToString()));
                    }
                }
                else
                {
                    ENPais pais = new ENPais();
                    List<ENPais> paises = new List<ENPais>();
                    pais.readPaises(paises);

                    foreach (ENPais p in paises)
                    {
                     //   listaPaises_form_experiencia.Items.Insert(0, new ListItem(p.name, p.id.ToString()));
                    }
                    //Response.Redirect("/");
                }
            }
        }
        protected void crearSorteo(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (listaexperiencias.SelectedValue == "-1")
            {
              //  Error.Text = "*Seleccione un país";
               // Error.Visible = true;
                return;
            }

            if (create_sorteo_descripcion.Text.Length > description_maxlength)
            {
                ErrorDesc.Text = $"*Longitud máxima de descripción({description_maxlength}) superada";
                ErrorDesc.Visible = true;
                return;
            }


           // Error.Visible = false;

            //guarda una imagen
            if (crear_sorteo_imagen.HasFile)
            {
               /* string imagen = rand.Next(1, 999999).ToString() + "-sorteo-" + crear_sorteo_imagen.FileName;
                string ruta = "~/Media/Stories/" + imagen;
                crear_sorteo_imagen.SaveAs(Server.MapPath(ruta));
               */

                ENStories nuevasorteo = new ENStories(
                    (ENUsuario)Session["usuario"], //usuario
                    DateTime.Now, //fecha
                    create_sorteo_title.Text, //titulo
                    int.Parse(listaPaises_form_sorteo.SelectedValue), //país
                    create_sorteo_descripcion.Text, //descripción
                    imagen); //imagen
                ENSorteos sorteo = new ENSorteos();
                sorteo.Descripcion = create_sorteo_descripcion.ToString();
                sorteo.Titular = Session["empresa"].ToString();
                DateTime dateTime;
                    System.DateTime.TryParse(fechafinal.ToString(),out dateTime);
                sorteo.FechaFinal = dateTime;
                System.DateTime.TryParse(fechainicio.ToString(), out dateTime);
                sorteo.FechaFinal = dateTime;
                sorteo.Titulo = create_sorteo_title.ToString();
                sorteo.Premio = listaexperiencias.SelectedValue;
                try
                {
                    if (!nuevasorteo.Readsorteo())
                    {
                        if (nuevasorteo.Createsorteo())
                        {
                            Error.Text = "Creación exitosa";
                            Error.Visible = true;
                            ENPais p = new ENPais();
                            p.id = nuevasorteo.Pais;
                            try
                            {
                                if (p.ReadPais())
                                {
                                    Response.Redirect("/sorteo/" + p.name);
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
                            Error.Text = "*ERROR: sorteo no creada";
                            Error.Visible = true;

                            string filePath = Server.MapPath("~/Media/Stories/" + imagen);
                            File.Delete(filePath);
                        }
                    }
                    else
                    {
                        Error.Text = "*ERROR: sorteo ya existente";
                        Error.Visible = true;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("sorteo operation has failed.Error: {0}", ex.Message);
                }
            }
            else
            {
                Error.Text = "*ERROR: imagen no subida";
                Error.Visible = true;
            }

        }
        /*
        private void ServerValidation_description_maxlength(object source, ServerValidateEventArgs args)
        {
            int description_length = create_sorteo_descripcion.Text.Length;
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
                listaPaises_form_sorteo.DataSource = ds;
                listaPaises_form_sorteo.DataTextField = "name";
                listaPaises_form_sorteo.DataValueField = "id";
                listaPaises_form_sorteo.DataBind();

            }
            listaPaises_form_sorteo.Items.Insert(0, new ListItem("-- Destination --", "-1"));
        }

        /// <summary>
        /// Crea una sorteo con los datos del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCrea_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (listaPaises_form_sorteo.SelectedValue == "-1")
            {
                Error.Text = "*Seleccione un país";
                Error.Visible = true;
                return;
            }

            if (create_sorteo_descripcion.Text.Length > description_maxlength)
            {
                ErrorDesc.Text = $"*Longitud máxima de descripción({description_maxlength}) superada";
                ErrorDesc.Visible = true;
                return;
            }

            
            Error.Visible = false;

            //guarda una imagen
            if (crear_sorteo_imagen.HasFile)
            {
                string imagen = rand.Next(1, 999999).ToString() + "-sorteo-" + crear_sorteo_imagen.FileName;
                string ruta = "~/Media/Stories/" + imagen;
                crear_sorteo_imagen.SaveAs(Server.MapPath(ruta));

                ENStories nuevasorteo = new ENStories(
                    (ENUsuario)Session["usuario"], //usuario
                    DateTime.Now, //fecha
                    create_sorteo_title.Text, //titulo
                    int.Parse(listaPaises_form_sorteo.SelectedValue), //país
                    create_sorteo_descripcion.Text, //descripción
                    imagen); //imagen

                try
                {
                    if (!nuevasorteo.Readsorteo())
                    {
                        if (nuevasorteo.Createsorteo())
                        {
                            Error.Text = "Creación exitosa";
                            Error.Visible = true;
                            ENPais p = new ENPais();
                            p.id = nuevasorteo.Pais;
                            try
                            {
                                if (p.ReadPais())
                                {
                                    Response.Redirect("/sorteo/" + p.name);
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
                            Error.Text = "*ERROR: sorteo no creada";
                            Error.Visible = true;

                            string filePath = Server.MapPath("~/Media/Stories/" + imagen);
                            File.Delete(filePath);
                        }
                    }
                    else
                    {
                        Error.Text = "*ERROR: sorteo ya existente";
                        Error.Visible = true;
                    }

                }catch(Exception ex)
                {
                    Console.WriteLine("sorteo operation has failed.Error: {0}", ex.Message);
                }
            }
            else
            {
                Error.Text = "*ERROR: imagen no subida";
                Error.Visible = true;
            }
            
        }
        */
    }
}