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
    public partial class FormBlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario"] != null)
                {
                    ENPais pais = new ENPais();
                    List<ENPais> paises = new List<ENPais>();
                    ENCategorias categoria = new ENCategorias();
                    DataSet listaCategorias = categoria.readCategorias();
                    pais.readPaises(paises);

                    foreach (ENPais p in paises)
                    {
                        listaPaises_form_blog.Items.Insert(0, new ListItem(p.name, p.id.ToString()));
                    }

                    foreach (DataRow row in listaCategorias.Tables["Categorias"].Rows)
                    {
                        listaCategorias_form_blog.Items.Insert(0, new ListItem(row["nombre"].ToString(), row["id"].ToString()));
                    }

                }
                else
                {
                    Response.Redirect("/");
                }
            }
        }


        protected void crearBlog(object sender, EventArgs e)
        {
            Random rand = new Random();
            ENBlog blog = new ENBlog();
            ENUsuario usuario = (ENUsuario)Session["usuario"];

            blog.Titulo = create_titulo_blog.Text.Trim();
            blog.Descripcion = create_descripcion_blog.Text.Trim();
            blog.Texto_1 = create_text_1_blog.Text.Trim();
            blog.Texto_2 = create_text_2_blog.Text.Trim();
            blog.Texto_3 = create_text_3_blog.Text.Trim();
            blog.Citacion = create_citacion_blog.Text.Trim();
            blog.Slug = Home.slug(blog.Titulo) + "-" + rand.Next(1, 999999).ToString();
            blog.Usuario.nickname = usuario.nickname;
            blog.Categoria.id = Int32.Parse(listaCategorias_form_blog.SelectedItem.Value);
            blog.Pais.id = Int32.Parse(listaPaises_form_blog.SelectedItem.Value);

            ENCategorias categoria = new ENCategorias();
            categoria.id = Int32.Parse(listaCategorias_form_blog.SelectedItem.Value);
            categoria.readCategoria(true);
            blog.Categoria = categoria;


            foreach (HttpPostedFile imagenes in imagenes_blog.PostedFiles)
            {
                if (imagenes_blog.HasFiles)
                {
                    string imagen = blog.Slug + "-blog-" + Path.GetFileName(imagenes.FileName);
                    blog.Imagenes.Add(new ENImagenes(imagen));
                    imagenes.SaveAs(Server.MapPath("~/Media/Blogs/") + imagen);
                }
            }

            if (background_blog.HasFile)
            {
                string imagen = blog.Slug + "-bg-blog-" + Path.GetFileName(background_blog.PostedFile.FileName);
                blog.Imagen_principal = imagen;
                background_blog.SaveAs(Server.MapPath("~/Media/Blogs/") + imagen);
            }
            else
            {
                blog.Imagen_principal = "blog_bg_img.jpg"; ;
            }


            if (blog.crearBlog())
            {
                Response.Redirect("/blog/" + blog.Categoria.slug + "/" + blog.Slug);
            }
            else
            {
                resultado.Text = "Ha ocurrido un error";
            }

        }
    }
}