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
    public partial class FormGaleria : System.Web.UI.Page
    {
        private ENGaleria seccion_galeria;
        protected void Page_Load(object sender, EventArgs e)
        {
            Error.Text = "";
            Error.Visible = false;
            if (!IsPostBack)
            {
                seccion_galeria =new ENGaleria();
                fillDestinos();

                if (Session["usuario"] != null)
                {
                    seccion_galeria.Usuario = (ENUsuario)Session["usuario"];
                }
                else
                {
                    //Response.Redirect("/");
                }
            }
        }

        private void fillDestinos() 
        {
            ENPais pais = new ENPais();
            List<ENPais> paises = new List<ENPais>();
            pais.readPaises(paises);

            foreach (ENPais p in paises)
            {
                listaPaises_form_galeria.Items.Insert(0, new ListItem(p.name, p.id.ToString()));
            }
            listaPaises_form_galeria.Items.Insert(0, new ListItem("-- Destination --", "-1"));
        }

        protected void btnCrea_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
           
            HttpFileCollection _HttpFileCollection = Request.Files;

            //Primero validar los datos
            if (_HttpFileCollection.Count > 10)
            {
                Error.Text = "*Maximo 6 imagenes";
                Error.Visible = true;
            }
            else if (listaPaises_form_galeria.SelectedValue == "-1")
            {
                Error.Text = "*Seleccione un pais valido";
                Error.Visible = true;
            }
            
            else
            {
                Error.Visible = false;
                for (int i = 0; i < _HttpFileCollection.Count; i++)
                {
                    HttpPostedFile _HttpPostedFile = _HttpFileCollection[i];
                    if (_HttpPostedFile.ContentLength > 0)
                    {
                        string imagen = rand.Next(1,999999).ToString() + "-galery-" + Path.GetFileName(_HttpPostedFile.FileName);
                        seccion_galeria.Imagenes.Add(new ENImagenes(imagen));
                        _HttpPostedFile.SaveAs(Server.MapPath("~/Media/Galery/" + imagen));
                    }

                    string titulo = create_galeria_title.Text.Trim();
                    string descripcion = create_galeria_descripcion.Text.Trim();
                    string slug =Home.slug( listaPaises_form_galeria.SelectedItem.Text+"/"+titulo);

                    try
                    {
                        seccion_galeria.Pais = new ENPais(int.Parse(listaPaises_form_galeria.SelectedValue), listaPaises_form_galeria.SelectedItem.Text);

                        if (!seccion_galeria.readGaleria())
                        {
                            if (seccion_galeria.createGaleria())
                            {
                                //Response.Redirect("galeia/"+seccion_galeria.Slug);
                            }
                            else 
                            {
                                Error.Text = "*Algo salio mal";
                                Error.Visible = true;
                            }
                        }
                        else 
                        {
                            Error.Text = "*Algo salio mal: Parece que ya existe revisa el titulo";
                            Error.Visible = true;
                        }
                    }
                    catch (Exception excepcion)
                    { }



                }
            }
        }
    }
}