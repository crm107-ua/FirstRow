using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace library
{
    public class CADBlog
    {
        private String constring;

        public CADBlog()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        public bool addBlog(ENBlog blog)
        {
            bool creado = false;
            SqlConnection conection = null;

            try
            {
                conection = new SqlConnection(constring);
                conection.Open();

                string query = "Insert INTO [firstrow_].[dbo].[Blogs] " +
                    "(imagen_principal,titulo, descripcion, text_1, text_2," +
                    "text_3, citacion, slug, usuario, categoria, pais) " +
                    "VALUES " +
                    "(@imagen_principal,@titulo,@descripcion,@text_1,@text_2," +
                    "@text_3,@citacion,@slug,@usuario,@categoria,@pais) " +
                    "select scope_identity()";
                SqlCommand consulta = new SqlCommand(query, conection);
                consulta.Parameters.AddWithValue("@imagen_principal", blog.Imagen_principal);
                consulta.Parameters.AddWithValue("@titulo", blog.Titulo);
                consulta.Parameters.AddWithValue("@descripcion", blog.Descripcion);
                consulta.Parameters.AddWithValue("@text_1", blog.Texto_1);
                consulta.Parameters.AddWithValue("@text_2", blog.Texto_2);
                consulta.Parameters.AddWithValue("@text_3", blog.Texto_3);
                consulta.Parameters.AddWithValue("@citacion", blog.Citacion);
                consulta.Parameters.AddWithValue("@slug", blog.Slug);
                consulta.Parameters.AddWithValue("@usuario", blog.Usuario.nickname);
                consulta.Parameters.AddWithValue("@categoria", blog.Categoria.id);
                consulta.Parameters.AddWithValue("@pais", blog.Pais.id);
                int ultimoID_Blog = Convert.ToInt32(consulta.ExecuteScalar());

                foreach (ENImagenes imagen in blog.Imagenes)
                {
                    query = "Insert INTO [firstrow_].[dbo].[Imagenes] " +
                            "(name) " +
                            "VALUES " +
                            "(@name) " +
                            "select scope_identity()";
                    consulta = new SqlCommand(query, conection);
                    consulta.Parameters.AddWithValue("@name", imagen.Name);
                    int ultimoID_Imagen = Convert.ToInt32(consulta.ExecuteScalar());


                    query = "Insert INTO [firstrow_].[dbo].[Blog_Imagenes] " +
                            "(id_Blog,id_Imagen) " +
                            "VALUES " +
                            "(@id_Blog,@id_Imagen)";
                    consulta = new SqlCommand(query, conection);
                    consulta.Parameters.AddWithValue("@id_Blog", ultimoID_Blog);
                    consulta.Parameters.AddWithValue("@id_Imagen", ultimoID_Imagen);
                    consulta.ExecuteNonQuery();
                }

                creado = true;

            }
            catch (SqlException e)
            {
                creado = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                creado = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return creado;
        }

        public bool readBlog(ENBlog blog)
        {

            SqlConnection conection = null;
            SqlConnection conectionSecundario = null;
            SqlDataReader busqueda = null;
            SqlDataReader busquedaSecundaria = null;

            try
            {
                conection = new SqlConnection(constring);
                conection.Open();

                string query = "Select * From [firstrow_].[dbo].[Blogs] where slug = @slug";
                SqlCommand consulta = new SqlCommand(query, conection);
                consulta.Parameters.AddWithValue("@slug", blog.Slug);
                busqueda = consulta.ExecuteReader();
                busqueda.Read();

                // Lectura de campos de blog

                blog.Id = Int32.Parse(busqueda["id"].ToString());
                blog.Imagen_principal = busqueda["imagen_principal"].ToString();
                blog.Titulo = busqueda["titulo"].ToString();
                blog.Descripcion = busqueda["descripcion"].ToString();
                blog.Texto_1 = busqueda["text_1"].ToString();
                blog.Texto_2 = busqueda["text_2"].ToString();
                blog.Texto_3 = busqueda["text_3"].ToString();
                blog.Citacion = busqueda["citacion"].ToString();
                ENUsuario usuario = new ENUsuario();
                usuario.nickname = busqueda["usuario"].ToString();
                usuario.readUsuario();
                blog.Usuario = usuario;

                try
                {
                    // Lectura de pais de blog

                    conectionSecundario = new SqlConnection(constring);
                    conectionSecundario.Open();
                    string querySecundaria = "Select * From [firstrow_].[dbo].[Paises] where ID = @id";
                    SqlCommand consultaSecundaria = new SqlCommand(querySecundaria, conectionSecundario);
                    consultaSecundaria.Parameters.AddWithValue("@id", Int32.Parse(busqueda["pais"].ToString()));
                    busquedaSecundaria = consultaSecundaria.ExecuteReader();
                    busquedaSecundaria.Read();
                    ENPais pais = new ENPais();
                    pais.id = Int32.Parse(busquedaSecundaria["id"].ToString());
                    pais.name = busquedaSecundaria["name"].ToString();
                    blog.Pais = pais;
                    busquedaSecundaria.Close();

                    // Lectura de imagenes de blog

                    List<ENImagenes> imagenes = new List<ENImagenes>();
                    querySecundaria = "Select * From [firstrow_].[dbo].[Blog_Imagenes] b " +
                    "inner join [firstrow_].[dbo].[Imagenes] i " +
                    "on i.id = b.id_Imagen " +
                    "where id_Blog = @id_Blog";
                    consultaSecundaria = new SqlCommand(querySecundaria, conectionSecundario);
                    consultaSecundaria.Parameters.AddWithValue("@id_Blog", blog.Id);
                    busquedaSecundaria = consultaSecundaria.ExecuteReader();

                    while (busquedaSecundaria.Read())
                    {
                        ENImagenes imagen = new ENImagenes();
                        imagen.Id = Int32.Parse(busquedaSecundaria["id"].ToString());
                        imagen.Name = busquedaSecundaria["name"].ToString();
                        imagen.Mode = Int32.Parse(busquedaSecundaria["mode"].ToString());
                        imagenes.Add(imagen);
                    }

                    blog.Imagenes = imagenes;
                    busquedaSecundaria.Close();

                    // Lectura de comentarios de blog

                    List<ENComentarios> comentarios = new List<ENComentarios>();
                    querySecundaria = "Select * From [firstrow_].[dbo].[Blog_Comentarios] b " +
                    "inner join [firstrow_].[dbo].[Comentarios] i " +
                    "on i.id = b.id_Comentario " +
                    "where id_Blog = @id_Blog";
                    consultaSecundaria = new SqlCommand(querySecundaria, conectionSecundario);
                    consultaSecundaria.Parameters.AddWithValue("@id_Blog", blog.Id);
                    busquedaSecundaria = consultaSecundaria.ExecuteReader();

                    while (busquedaSecundaria.Read())
                    {
                        ENComentarios comentario = new ENComentarios();
                        comentario.Id = Int32.Parse(busquedaSecundaria["id"].ToString());
                        comentario.Texto = busquedaSecundaria["texto"].ToString();
                        comentario.Estrellas = Int32.Parse(busquedaSecundaria["estrellas"].ToString());

                        // Lectura de usuario del comentario

                        ENUsuario usuarioComentario = new ENUsuario();
                        usuarioComentario.nickname = busquedaSecundaria["nickname"].ToString();
                        usuarioComentario.readUsuario();
                        comentario.Usuario = usuario;
                        comentarios.Add(comentario);
                    }

                    blog.Comentarios = comentarios;
                    busquedaSecundaria.Close();

                }
                catch (SqlException e)
                {
                    Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                    return false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                    return false;
                }
                finally
                {
                    if (busquedaSecundaria != null)
                    {
                        busquedaSecundaria.Close();
                    }
                    if (conectionSecundario != null)
                    {
                        conectionSecundario.Close();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                return false;
            }
            finally
            {
                if (busqueda != null)
                {
                    busqueda.Close();
                }
                if (conection != null)
                {
                    conection.Close();
                }
            }

            return true;
        }

        public bool readBlogs(List<ENBlog> listaBlogs, int categoria)
        {
            bool leido = false;
            SqlConnection connection = null;
            DataSet blogs = null;
            SqlConnection connectionSecundaria = null;
            DataSet blogSecundario = null;
            ENBlog blog = null;

            try
            {
                connection = new SqlConnection(constring);
                blogs = new DataSet();
                string query = "";

                if (categoria == 0)
                {
                    query = "Select * From [firstrow_].[dbo].[Blogs];";
                }
                else
                {
                    query = "Select * From [firstrow_].[dbo].[Blogs] where categoria=" + categoria + ";";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(blogs, "Blogs");
                DataTable tableBlogs = blogs.Tables["Blogs"];
                DataRow[] rowsBlogs = tableBlogs.Select();

                for (int i = 0; i < rowsBlogs.Length; i++)
                {
                    blog = new ENBlog();

                    blog.Id = Int32.Parse(rowsBlogs[i]["id"].ToString());
                    blog.Imagen_principal = rowsBlogs[i]["imagen_principal"].ToString();
                    blog.Titulo = rowsBlogs[i]["titulo"].ToString();
                    blog.Descripcion = rowsBlogs[i]["descripcion"].ToString();
                    blog.Texto_1 = rowsBlogs[i]["text_1"].ToString();
                    blog.Texto_2 = rowsBlogs[i]["text_2"].ToString();
                    blog.Texto_3 = rowsBlogs[i]["text_3"].ToString();
                    blog.Citacion = rowsBlogs[i]["citacion"].ToString();
                    blog.Slug = rowsBlogs[i]["slug"].ToString();
                    blog.Pais.id = Int32.Parse(rowsBlogs[i]["pais"].ToString());
                    blog.Categoria.id = Int32.Parse(rowsBlogs[i]["categoria"].ToString());
                    ENUsuario usuario = new ENUsuario();
                    usuario.nickname = rowsBlogs[i]["usuario"].ToString();
                    usuario.readUsuario();
                    blog.Usuario = usuario;


                    connectionSecundaria = new SqlConnection(constring);
                    blogSecundario = new DataSet();
                    query = "Select * From [firstrow_].[dbo].[Paises] where id='" + blog.Pais.id + "'";
                    SqlDataAdapter adapterSecundario = new SqlDataAdapter(query, connectionSecundaria);
                    adapterSecundario.Fill(blogSecundario, "Paises");
                    DataTable tablePaises = blogSecundario.Tables["Paises"];
                    DataRow[] rowsPaises = tablePaises.Select();
                    blog.Pais.id = Int32.Parse(rowsPaises[0]["id"].ToString());
                    blog.Pais.name = rowsPaises[0]["name"].ToString();
                    connectionSecundaria.Close();


                    connectionSecundaria = new SqlConnection(constring);
                    blogSecundario = new DataSet();
                    query = "Select * From [firstrow_].[dbo].[Categorias] where id='" + blog.Categoria.id + "'";
                    adapterSecundario = new SqlDataAdapter(query, connectionSecundaria);
                    adapterSecundario.Fill(blogSecundario, "Categorias");
                    DataTable tableCategorias = blogSecundario.Tables["Categorias"];
                    DataRow[] rowsCategorias = tableCategorias.Select();
                    blog.Categoria.id = Int32.Parse(rowsCategorias[0]["id"].ToString());
                    blog.Categoria.nombre = rowsCategorias[0]["nombre"].ToString();
                    blog.Categoria.descripcion = rowsCategorias[0]["descripcion"].ToString();
                    blog.Categoria.slug = rowsCategorias[0]["slug"].ToString();
                    connectionSecundaria.Close();


                    connectionSecundaria = new SqlConnection(constring);
                    blogSecundario = new DataSet();
                    query = "Select * From [firstrow_].[dbo].[Blog_Imagenes] b " +
                        "inner join [firstrow_].[dbo].[Imagenes] i " +
                        "on i.id = b.id_Imagen " +
                        "where id_Blog = '" + blog.Id + "'";
                    adapterSecundario = new SqlDataAdapter(query, connectionSecundaria);
                    adapterSecundario.Fill(blogSecundario, "Blog_Imagenes");
                    DataTable tableBlog_Imagenes = blogSecundario.Tables["Blog_Imagenes"];
                    DataRow[] rowsBlog_Imagenes = tableBlog_Imagenes.Select();
                    List<ENImagenes> imagenes = new List<ENImagenes>();
                    for (int j = 0; j < rowsBlog_Imagenes.Length; j++)
                    {
                        ENImagenes imagen = new ENImagenes();
                        imagen.Id = Int32.Parse(rowsBlog_Imagenes[j]["id"].ToString());
                        imagen.Name = rowsBlog_Imagenes[j]["name"].ToString();
                        imagen.Mode = Int32.Parse(rowsBlog_Imagenes[j]["mode"].ToString());
                        imagenes.Add(imagen);
                    }
                    blog.Imagenes = imagenes;
                    connectionSecundaria.Close();

                    connectionSecundaria = new SqlConnection(constring);
                    blogSecundario = new DataSet();
                    query = "Select * From [firstrow_].[dbo].[Blog_Comentarios] b " +
                        "inner join [firstrow_].[dbo].[Comentarios] i " +
                        "on i.id = b.id_Comentario " +
                        "where id_Blog = '" + blog.Id + "'";
                    adapterSecundario = new SqlDataAdapter(query, connectionSecundaria);
                    adapterSecundario.Fill(blogSecundario, "Blog_Comentarios");
                    DataTable tableBlog_Comentarios = blogSecundario.Tables["Blog_Comentarios"];
                    DataRow[] rowsBlog_Comentarios = tableBlog_Comentarios.Select();
                    List<ENComentarios> comentarios = new List<ENComentarios>();
                    for (int j = 0; j < rowsBlog_Comentarios.Length; j++)
                    {
                        ENComentarios comentario = new ENComentarios();
                        comentario.Id = Int32.Parse(rowsBlog_Comentarios[j]["id"].ToString());
                        comentario.Texto = rowsBlog_Comentarios[j]["texto"].ToString();
                        comentario.Estrellas = Int32.Parse(rowsBlog_Comentarios[j]["estrellas"].ToString());
                        ENUsuario usuario_comentario = new ENUsuario();
                        usuario_comentario.nickname = rowsBlog_Comentarios[j]["nickname"].ToString();
                        usuario_comentario.readUsuario();
                        comentario.Usuario = usuario_comentario;
                        comentarios.Add(comentario);
                    }
                    blog.Comentarios = comentarios;
                    connectionSecundaria.Close();

                    listaBlogs.Add(blog);
                }

            }
            catch (DataException e)
            {
                Console.WriteLine(e.Message);
                leido = false;
            }
            finally
            {
                connection.Close();

                if(connectionSecundaria != null)
                {
                    connectionSecundaria.Close();
                }
            }

            return leido;
        }

        public bool updateBlog(ENBlog en)
        {
            bool update = false;
            return update;
        }

        public bool deleteBlog(ENBlog en)
        {
            bool delete = false;
            return delete;
        }
    }
}
