using library;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                    //Response.Redirect("/");
                }
            }

            cargaDeEtapas();
            cargaDeIncluidos();
        }
        protected void crearExperiencia(object sender, EventArgs e)
        {
            Random rand = new Random();
            ENPais pais = new ENPais();
            ENViajes experiencia = new ENViajes();
            ENEmpresa empresa = (ENEmpresa)Session["empresa"];
            List<ENIncluido> listaIncluidos = new List<ENIncluido>();

            experiencia.Titulo = create_titulo_experiencia.Text.Trim();
            experiencia.Nombre = create_nombre_experiencia.Text.Trim();
            experiencia.Descripcion = create_descripcion_experiencia.Text.Trim();
            experiencia.Dias = Int32.Parse(total_dias.Value);
            experiencia.Slug = slug(experiencia.Titulo)+"-"+rand.Next(1,999999).ToString();
            experiencia.Precio = Convert.ToDouble(create_precio_experiencia.Text.ToString());
            experiencia.Pais.id = Int32.Parse(listaPaises_form_experiencia.SelectedItem.Value);
            experiencia.Empresa.nickname = empresa.nickname;

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
                    string imagen = experiencia.Slug + "-etapa-" + Path.GetFileName(imagenes_etapas.PostedFile.FileName); 
                    etapas[i].Imagen = imagen;
                    imagenes_etapas.SaveAs(Server.MapPath("~/Media/Etapas/") + imagen);
                }
                i++;
            }

            foreach (HttpPostedFile imagenes in imagenes_experiencia.PostedFiles)
            {
                if (imagenes_experiencia.HasFiles)
                {
                    string imagen = experiencia.Slug + "-img-" + Path.GetFileName(imagenes.FileName);
                    experiencia.Imagenes.Add(new ENImagenes(imagen));
                    imagenes.SaveAs(Server.MapPath("~/Media/Experiencias/") + imagen);
                }
            }

            if (background_experiencia.HasFile)
            {
                string imagen = experiencia.Slug + "-bg-" + Path.GetFileName(background_experiencia.PostedFile.FileName);
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

            experiencia.Incluidos = listaIncluidos;
            experiencia.Etapas = etapas;

            if (experiencia.agregarExperiencia())
            {
                Response.Redirect("/experiencia/" + experiencia.Slug);
            }
            else
            {
                resultado.Text = "Ha ocurrido un error";
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
                fu.Attributes.Add("accept", ".jpg , .png");

                panelEtapas.Controls.Add(fu);

                panelEtapas.Controls.Add(new LiteralControl("<br><hr><br>"));
            }

            if (i == 0)
            {
                i++;
                cargaDeEtapas();
            }

        }


        public string slug(string value)
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