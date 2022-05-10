using library;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstRow.Pages.Forms
{
    public partial class FormExperiencia : System.Web.UI.Page
    {
        private TextBox tb;
        private TextBox tb2;
        private FileUpload fu;
        private CheckBox checkbox;
        private static int i = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["empresa"] != null)
                {
                    ENPais pais = new ENPais();
                    List<ENPais> paises = new List<ENPais>();
                    pais.readPaises(paises);

                    foreach (ENPais p in paises)
                    {
                        listaPaises_form_experiencia.Items.Insert(0, new ListItem(p.name, p.id.ToString()));
                    }
                }
                else
                {
                    ENPais pais = new ENPais();
                    List<ENPais> paises = new List<ENPais>();
                    pais.readPaises(paises);

                    foreach (ENPais p in paises)
                    {
                        listaPaises_form_experiencia.Items.Insert(0, new ListItem(p.name, p.id.ToString()));
                    }
                    //Response.Redirect("/403");
                }
            }
            cargaDeEtapas();
            cargaDeIncluidos();
        }
        protected void crearExperiencia(object sender, EventArgs e)
        {

            ENPais pais = new ENPais();
            ENViajes experiencia = new ENViajes();
            List<ENIncluido> listaIncluidos = new List<ENIncluido>();

            //ENEmpresa empresa = (ENEmpresa)Session["empresa"];

            experiencia.Titulo = create_titulo_experiencia.Text.Trim();
            experiencia.Nombre = create_nombre_experiencia.Text.Trim();
            experiencia.Descripcion = create_descripcion_experiencia.Text.Trim();
            experiencia.Precio = Convert.ToDouble(create_precio_experiencia.Text.ToString());
            experiencia.Pais.id = Int32.Parse(listaPaises_form_experiencia.SelectedItem.Value);
            experiencia.Empresa.nickname = "empresa"; // = (ENEmpresa)Session["empresa"];


            List<ENDia> etapas = new List<ENDia>();
            ENDia dia = new ENDia();

            int i = 0;
            foreach (TextBox dias in panelEtapas.Controls.OfType<TextBox>())
            {
                if (!string.IsNullOrEmpty(dias.Text))
                {
                    switch (i)
                    {
                        case 0:
                            dia = new ENDia();
                            dia.Titulo = dias.Text.Trim();
                            i++;
                            break;
                        case 1:
                            dia.Nombre = dias.Text.Trim();
                            i++;
                            break;
                        case 2:
                            dia.Descripcion = dias.Text.Trim();
                            etapas.Add(dia);
                            i = 0;
                            break;
                    }
                }
            }

            i = 0;
            foreach (FileUpload imagenes_etapas in panelEtapas.Controls.OfType<FileUpload>())
            {
                if (imagenes_etapas.HasFile)
                {
                    string imagen = experiencia.Empresa.nickname + "_" + Path.GetFileName(imagenes_etapas.PostedFile.FileName);
                    etapas[i].Imagen = imagen;
                    imagenes_etapas.SaveAs(Server.MapPath("~/Media/Etapas/") + imagen);
                }
                i++;
            }

            foreach (HttpPostedFile imagenes in imagenes_experiencia.PostedFiles)
            {
                if (imagenes_experiencia.HasFiles)
                {
                    string imagen = experiencia.Empresa.nickname + "_" + Path.GetFileName(imagenes.FileName);
                    experiencia.Imagenes.Add(new ENImagenes(imagen));
                    imagenes.SaveAs(Server.MapPath("~/Media/Experiencias/") + imagen);
                }
            }

            if (background_experiencia.HasFile)
            {
                string imagen = experiencia.Empresa.nickname + "_bg_" + Path.GetFileName(background_experiencia.PostedFile.FileName);
                experiencia.Background = imagen;
                background_experiencia.SaveAs(Server.MapPath("~/Media/Experiencias/") + imagen);
            }

            foreach (CheckBox checkbox in panelIncluidos.Controls.OfType<CheckBox>())
            {
                if (checkbox.Checked)
                {
                    listaIncluidos.Add(new ENIncluido(Int32.Parse(checkbox.ID), checkbox.Text));
                }
            }

        }


        private void cargaDeIncluidos()
        {
            ENIncluido incluido = new ENIncluido();
            DataSet dataSetListaIncluidos = incluido.readIncluidos();

            foreach (DataRow row in dataSetListaIncluidos.Tables["Incluidos"].Rows)
            {
                checkbox = new CheckBox();
                checkbox.ID = row["id"].ToString();
                checkbox.Text = row["titulo"].ToString();
                checkbox.Attributes.Add("style", "margin-left:5%");
                panelIncluidos.Controls.Add(checkbox);
            }

        }



        protected void agregarEtapa(object sender, EventArgs e)
        {
            cargaDeEtapas();
            i++;
        }


        private void cargaDeEtapas()
        {
            int contador = 0;

            foreach (TextBox dias in panelEtapas.Controls.OfType<TextBox>())
            {
                contador++;
            }

            for (int j = 0; j <= i-contador; j++)
            {
                tb = new TextBox();
                tb.Attributes.Add("runat", "server");
                tb.Attributes.Add("type", "text");
                tb.Attributes.Add("style", "margin-top: 3%; width:100%;");
                tb.Attributes.Add("class", "input");
                tb.Attributes.Add("placeholder", "Titulo");
                tb.Attributes.Add("required", "true");
                tb.Attributes.Add("value", "Ejemplo texto");

                panelEtapas.Controls.Add(tb);

                tb2 = new TextBox();
                tb2.Attributes.Add("runat", "server");
                tb2.Attributes.Add("type", "text");
                tb2.Attributes.Add("style", "margin-top: 3%; width:100%;");
                tb2.Attributes.Add("class", "input");
                tb2.Attributes.Add("placeholder", "Nombre del dia");
                tb2.Attributes.Add("required", "true");
                tb2.Attributes.Add("value", "Ejemplo texto");

                panelEtapas.Controls.Add(tb2);

                tb2 = new TextBox();
                tb2.Attributes.Add("runat", "server");
                tb2.Attributes.Add("type", "text");
                tb2.Attributes.Add("style", "margin-top: 3%; width:100%;");
                tb2.Attributes.Add("class", "input");
                tb2.Attributes.Add("placeholder", "Descripcion");
                tb2.Attributes.Add("required", "true");
                tb2.Attributes.Add("value", "Ejemplo texto");

                panelEtapas.Controls.Add(tb2);

                fu = new FileUpload();
                fu.Attributes.Add("runat", "server");
                fu.Attributes.Add("type", "file");
                fu.Attributes.Add("style", "margin-top: 3%; width:100%; margin-bottom: 20px;");
                fu.Attributes.Add("class", "input");
                fu.Attributes.Add("placeholder", "Foto de etapa");

                panelEtapas.Controls.Add(fu);

                panelEtapas.Controls.Add(new LiteralControl("<br><hr><br>"));
            }

            if (i == 0)
            {
                i++;
                cargaDeEtapas();
            }
        }
    }
}