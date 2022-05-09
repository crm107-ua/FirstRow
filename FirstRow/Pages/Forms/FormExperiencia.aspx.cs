using library;
using System;
using System.Collections.Generic;
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
            cargaDeIncluidos();
        }
        protected void crearExperiencia(object sender, EventArgs e)
        {

            ENPais pais = new ENPais();
            ENViajes experiencia = new ENViajes();

            experiencia.Titulo = create_titulo_experiencia.Text;
            experiencia.Nombre = create_nombre_experiencia.Text;
            experiencia.Descripcion = create_descripcion_experiencia.Text;
            experiencia.Precio = Double.Parse(create_descripcion_experiencia.Text);
            experiencia.Pais.id = Int32.Parse(listaPaises_form_experiencia.SelectedItem.Value);


            List<ENDia> incluido = new List<ENDia>();
            ENDia dia = new ENDia();

            int i = 0;
            foreach (TextBox dias in incluidos.Controls.OfType<TextBox>())
            {
                if (!string.IsNullOrEmpty(dias.Text))
                {
                    switch (i)
                    {
                        case 0:
                            dia = new ENDia();
                            dia.Titulo = dias.Text;
                            i++;
                            break;
                        case 1:
                            dia.Nombre = dias.Text;
                            i++;
                            break;
                        case 2:
                            dia.Descripcion = dias.Text;
                            incluido.Add(dia);
                            i = 0;
                            break;
                    }
                }
            }

            i = 0;
            foreach (FileUpload iamgenes_dias in incluidos.Controls.OfType<FileUpload>())
            {
                if (!string.IsNullOrEmpty(Path.GetFileName(iamgenes_dias.PostedFile.FileName)))
                {
                    incluido[i].Imagen = Path.GetFileName(iamgenes_dias.PostedFile.FileName);
                }
                i++;
            }
        }

        protected void agregarEtapa(object sender, EventArgs e)
        {
            cargaDeIncluidos();
            i++;
        }

        private void cargaDeIncluidos()
        {
            int contador = 0;

            foreach (TextBox dias in incluidos.Controls.OfType<TextBox>())
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

                incluidos.Controls.Add(tb);

                tb2 = new TextBox();
                tb2.Attributes.Add("runat", "server");
                tb2.Attributes.Add("type", "text");
                tb2.Attributes.Add("style", "margin-top: 3%; width:100%;");
                tb2.Attributes.Add("class", "input");
                tb2.Attributes.Add("placeholder", "Nombre del dia");

                incluidos.Controls.Add(tb2);

                tb2 = new TextBox();
                tb2.Attributes.Add("runat", "server");
                tb2.Attributes.Add("type", "text");
                tb2.Attributes.Add("style", "margin-top: 3%; width:100%;");
                tb2.Attributes.Add("class", "input");
                tb2.Attributes.Add("placeholder", "Descripcion");

                incluidos.Controls.Add(tb2);

                fu = new FileUpload();
                fu.Attributes.Add("runat", "server");
                fu.Attributes.Add("type", "file");
                fu.Attributes.Add("style", "margin-top: 3%; width:100%; margin-bottom: 20px;");
                fu.Attributes.Add("class", "input");
                fu.Attributes.Add("placeholder", "Foto de etapa");

                incluidos.Controls.Add(fu);

                incluidos.Controls.Add(new LiteralControl("<br><hr><br>"));
            }

            if (i == 0)
            {
                i++;
                cargaDeIncluidos();
            }
        }
    }
}