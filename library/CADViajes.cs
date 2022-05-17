using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace library
{
    public class CADViajes
    {
        private String constring;

        public CADViajes()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        public bool addExperiencia(ENViajes experiencia)
        {
            bool creada = false;
            SqlConnection conection = null;

            try
            {
                conection = new SqlConnection(constring);
                conection.Open();

                string query = "Insert INTO [firstrow_].[dbo].[Experiencias] " +
                    "(nombre,titulo, descripcion, slug, pais," +
                    "empresa, precio, background, dias) " +
                    "VALUES " +
                    "(@nombre,@titulo,@descripcion,@slug,@pais," +
                    "@empresa,@precio,@background,@dias) " +
                    "select scope_identity()";
                SqlCommand consulta = new SqlCommand(query, conection);
                consulta.Parameters.AddWithValue("@nombre", experiencia.Nombre);
                consulta.Parameters.AddWithValue("@titulo", experiencia.Titulo);
                consulta.Parameters.AddWithValue("@descripcion", experiencia.Descripcion);
                consulta.Parameters.AddWithValue("@slug", experiencia.Slug);
                consulta.Parameters.AddWithValue("@pais", experiencia.Pais.id);
                consulta.Parameters.AddWithValue("@empresa", experiencia.Empresa.nickname);
                consulta.Parameters.AddWithValue("@precio", experiencia.Precio);
                consulta.Parameters.AddWithValue("@background", experiencia.Background);
                consulta.Parameters.AddWithValue("@dias", experiencia.Dias);
                int ultimoID_Experiencia = Convert.ToInt32(consulta.ExecuteScalar());

                foreach(ENImagenes imagen in experiencia.Imagenes)
                {
                    query = "Insert INTO [firstrow_].[dbo].[Imagenes] " +
                            "(name) " +
                            "VALUES " +
                            "(@name) " +
                            "select scope_identity()";
                    consulta = new SqlCommand(query, conection);
                    consulta.Parameters.AddWithValue("@name", imagen.Name);
                    int ultimoID_Imagen = Convert.ToInt32(consulta.ExecuteScalar());


                    query = "Insert INTO [firstrow_].[dbo].[Experiencia_Imagenes] " +
                            "(id_Experiencia,id_Imagen) " +
                            "VALUES " +
                            "(@id_Experiencia,@id_Imagen)";
                    consulta = new SqlCommand(query, conection);
                    consulta.Parameters.AddWithValue("@id_Experiencia", ultimoID_Experiencia);
                    consulta.Parameters.AddWithValue("@id_Imagen", ultimoID_Imagen);
                    consulta.ExecuteNonQuery();
                }

                foreach (ENDia etapa in experiencia.Etapas)
                {
                    query = "Insert INTO [firstrow_].[dbo].[Etapa] " +
                            "(id_experiencia,titulo,nombre_etapa,descripcion,imagen) " +
                            "VALUES " +
                            "(@id_experiencia,@titulo,@nombre_etapa,@descripcion,@imagen)";
                    consulta = new SqlCommand(query, conection);
                    consulta.Parameters.AddWithValue("@id_experiencia", ultimoID_Experiencia);
                    consulta.Parameters.AddWithValue("@titulo", etapa.Titulo);
                    consulta.Parameters.AddWithValue("@nombre_etapa", etapa.Nombre);
                    consulta.Parameters.AddWithValue("@descripcion", etapa.Descripcion);
                    consulta.Parameters.AddWithValue("@imagen", etapa.Imagen);
                    consulta.ExecuteNonQuery();
                }

                foreach (ENIncluido incluido in experiencia.Incluidos)
                {
                    query = "Insert INTO [firstrow_].[dbo].[Experiencia_Incluido] " +
                            "(id_experiencia,id_incluido) " +
                            "VALUES " +
                            "(@id_experiencia,@id_incluido)";
                    consulta = new SqlCommand(query, conection);
                    consulta.Parameters.AddWithValue("@id_Experiencia", ultimoID_Experiencia);
                    consulta.Parameters.AddWithValue("@id_incluido", incluido.Id);
                    consulta.ExecuteNonQuery();
                }

                creada = true;

            }
            catch (SqlException e)
            {
                creada = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                creada = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return creada;
        }

        public bool readExperiencias(List<ENViajes> listaExperiencias)
        {
            bool leido = false;
            SqlConnection connection = null;
            DataSet experiencias = null;
            SqlConnection connectionSecundaria = null;
            DataSet experienciasSecundario = null;
            ENViajes experiencia = null;

            try
            {
                connection = new SqlConnection(constring);
                experiencias = new DataSet();

                string query = "Select * From [firstrow_].[dbo].[Experiencias];";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(experiencias, "Experiencias");
                DataTable tableExperiencias = experiencias.Tables["Experiencias"];
                DataRow[] rowsExperiencias = tableExperiencias.Select();

                for (int i = 0; i < rowsExperiencias.Length; i++)
                {
                    experiencia = new ENViajes();

                    experiencia.Id = Int32.Parse(rowsExperiencias[i]["id"].ToString());
                    experiencia.Nombre = rowsExperiencias[i]["nombre"].ToString();
                    experiencia.Titulo = rowsExperiencias[i]["titulo"].ToString();
                    experiencia.Descripcion = rowsExperiencias[i]["descripcion"].ToString();
                    experiencia.Precio = Double.Parse(rowsExperiencias[i]["precio"].ToString());
                    experiencia.Background = rowsExperiencias[i]["background"].ToString();
                    experiencia.Dias = Int32.Parse(rowsExperiencias[i]["dias"].ToString());
                    experiencia.Slug = rowsExperiencias[i]["slug"].ToString();
                    experiencia.Pais.id = Int32.Parse(rowsExperiencias[i]["pais"].ToString());
                    experiencia.Empresa.nickname = rowsExperiencias[i]["empresa"].ToString();


                    connectionSecundaria = new SqlConnection(constring);
                    experienciasSecundario = new DataSet();
                    query = "Select * From [firstrow_].[dbo].[Paises] where id='" + experiencia.Pais.id + "'";
                    SqlDataAdapter adapterSecundario = new SqlDataAdapter(query, connectionSecundaria);
                    adapterSecundario.Fill(experienciasSecundario, "Paises");
                    DataTable tablePaises= experienciasSecundario.Tables["Paises"];
                    DataRow[] rowsPaises = tablePaises.Select();
                    experiencia.Pais.id = Int32.Parse(rowsPaises[0]["id"].ToString());
                    experiencia.Pais.name = rowsPaises[0]["name"].ToString();
                    connectionSecundaria.Close();


                    connectionSecundaria = new SqlConnection(constring);
                    experienciasSecundario = new DataSet();
                    query = "Select * From [firstrow_].[dbo].[Etapa] where id_experiencia='" + experiencia.Id + "'";
                    adapterSecundario = new SqlDataAdapter(query, connectionSecundaria);
                    adapterSecundario.Fill(experienciasSecundario, "Etapa");
                    DataTable tableEtapa = experienciasSecundario.Tables["Etapa"];
                    DataRow[] rowsEtapa = tableEtapa.Select();
                    List<ENDia> etapas = new List<ENDia>();
                    for (int j = 0; j < rowsEtapa.Length; j++)
                    {
                        ENDia etapa = new ENDia();
                        etapa.Id = Int32.Parse(rowsEtapa[j]["id"].ToString());
                        etapa.Titulo = rowsEtapa[j]["titulo"].ToString();
                        etapa.Nombre = rowsEtapa[j]["nombre_etapa"].ToString();
                        etapa.Descripcion = rowsEtapa[j]["descripcion"].ToString();
                        etapa.Imagen = rowsEtapa[j]["imagen"].ToString();
                        etapas.Add(etapa);
                    }
                    experiencia.Etapas = etapas;
                    connectionSecundaria.Close();


                    connectionSecundaria = new SqlConnection(constring);
                    experienciasSecundario = new DataSet();
                    query = "Select * From [firstrow_].[dbo].[Experiencia_Incluido] e " +
                    "inner join [firstrow_].[dbo].[Incluidos] i " +
                    "on i.id = e.id_incluido " +
                    "where id_experiencia = '" + experiencia.Id + "'";
                    adapterSecundario = new SqlDataAdapter(query, connectionSecundaria);
                    adapterSecundario.Fill(experienciasSecundario, "Experiencia_Incluido");
                    DataTable tableExperiencia_Incluido = experienciasSecundario.Tables["Experiencia_Incluido"];
                    DataRow[] rowsExperiencia_Incluido = tableExperiencia_Incluido.Select();
                    List<ENIncluido> incluidos = new List<ENIncluido>();
                    for (int j = 0; j < rowsExperiencia_Incluido.Length; j++)
                    {
                        ENIncluido incluido = new ENIncluido();
                        incluido.Id = Int32.Parse(rowsExperiencia_Incluido[j]["id"].ToString());
                        incluido.Titulo = rowsExperiencia_Incluido[j]["titulo"].ToString();
                        incluido.Descripcion = rowsExperiencia_Incluido[j]["descripcion"].ToString();
                        incluidos.Add(incluido);
                    }
                    experiencia.Incluidos = incluidos;
                    connectionSecundaria.Close();


                    connectionSecundaria = new SqlConnection(constring);
                    experienciasSecundario = new DataSet();
                    query = "Select * From [firstrow_].[dbo].[Experiencia_Imagenes] e " +
                        "inner join [firstrow_].[dbo].[Imagenes] i " +
                        "on i.id = e.id_Imagen " +
                        "where id_experiencia = '" + experiencia.Id + "'";
                    adapterSecundario = new SqlDataAdapter(query, connectionSecundaria);
                    adapterSecundario.Fill(experienciasSecundario, "Experiencia_Imagenes");
                    DataTable tableExperiencia_Imagenes = experienciasSecundario.Tables["Experiencia_Imagenes"];
                    DataRow[] rowsExperiencia_Imagenes = tableExperiencia_Imagenes.Select();
                    List<ENImagenes> imagenes = new List<ENImagenes>();
                    for (int j = 0; j < rowsExperiencia_Imagenes.Length; j++)
                    {
                        ENImagenes imagen = new ENImagenes();
                        imagen.Id = Int32.Parse(rowsExperiencia_Imagenes[j]["id"].ToString());
                        imagen.Name = rowsExperiencia_Imagenes[j]["name"].ToString();
                        imagen.Mode = Int32.Parse(rowsExperiencia_Imagenes[j]["mode"].ToString());
                        imagenes.Add(imagen);
                    }
                    experiencia.Imagenes = imagenes;
                    connectionSecundaria.Close();







                    connectionSecundaria = new SqlConnection(constring);
                    experienciasSecundario = new DataSet();
                    query = "Select * From [firstrow_].[dbo].[Experiencia_Comentarios] e " +
                        "inner join [firstrow_].[dbo].[Comentarios] i " +
                        "on i.id = e.id_Comentario " +
                        "where id_experiencia = '" + experiencia.Id + "'";
                    adapterSecundario = new SqlDataAdapter(query, connectionSecundaria);
                    adapterSecundario.Fill(experienciasSecundario, "Experiencia_Comentarios");
                    DataTable tableExperiencia_Comentarios = experienciasSecundario.Tables["Experiencia_Comentarios"];
                    DataRow[] rowsExperiencia_Comentarios = tableExperiencia_Comentarios.Select();
                    List<ENComentarios> comentarios = new List<ENComentarios>();
                    for (int j = 0; j < rowsExperiencia_Comentarios.Length; j++)
                    {
                        ENComentarios comentario = new ENComentarios();
                        comentario.Id = Int32.Parse(rowsExperiencia_Comentarios[j]["id"].ToString());
                        comentario.Texto = rowsExperiencia_Comentarios[j]["texto"].ToString();
                        comentario.Estrellas = Int32.Parse(rowsExperiencia_Comentarios[j]["estrellas"].ToString());
                        ENUsuario usuario = new ENUsuario();
                        usuario.nickname = rowsExperiencia_Comentarios[j]["nickname"].ToString();
                        usuario.readUsuario();
                        comentario.Usuario = usuario;
                        comentarios.Add(comentario);
                    }
                    experiencia.Comentarios = comentarios;
                    connectionSecundaria.Close();

                    listaExperiencias.Add(experiencia);
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
                connectionSecundaria.Close();
            }

            return leido;
        }

        public bool readExperienciasPais(List<ENViajes> listaExperiencias, int pais)
        {
            bool leido = false;
            SqlConnection connection = null;
            DataSet experiencias = null;
            SqlConnection connectionSecundaria = null;
            DataSet experienciasSecundario = null;
            ENViajes experiencia = null;

            try
            {
                connection = new SqlConnection(constring);
                experiencias = new DataSet();

                string query = "Select * From [firstrow_].[dbo].[Experiencias] where pais='" + pais + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(experiencias, "Experiencias");
                DataTable tableExperiencias = experiencias.Tables["Experiencias"];
                DataRow[] rowsExperiencias = tableExperiencias.Select();

                for (int i = 0; i < rowsExperiencias.Length; i++)
                {
                    experiencia = new ENViajes();

                    experiencia.Id = Int32.Parse(rowsExperiencias[i]["id"].ToString());
                    experiencia.Nombre = rowsExperiencias[i]["nombre"].ToString();
                    experiencia.Titulo = rowsExperiencias[i]["titulo"].ToString();
                    experiencia.Descripcion = rowsExperiencias[i]["descripcion"].ToString();
                    experiencia.Precio = Double.Parse(rowsExperiencias[i]["precio"].ToString());
                    experiencia.Background = rowsExperiencias[i]["background"].ToString();
                    experiencia.Dias = Int32.Parse(rowsExperiencias[i]["dias"].ToString());
                    experiencia.Slug = rowsExperiencias[i]["slug"].ToString();
                    experiencia.Pais.id = Int32.Parse(rowsExperiencias[i]["pais"].ToString());
                    experiencia.Empresa.nickname = rowsExperiencias[i]["empresa"].ToString();


                    connectionSecundaria = new SqlConnection(constring);
                    experienciasSecundario = new DataSet();
                    query = "Select * From [firstrow_].[dbo].[Paises] where id='" + experiencia.Pais.id + "'";
                    SqlDataAdapter adapterSecundario = new SqlDataAdapter(query, connectionSecundaria);
                    adapterSecundario.Fill(experienciasSecundario, "Paises");
                    DataTable tablePaises = experienciasSecundario.Tables["Paises"];
                    DataRow[] rowsPaises = tablePaises.Select();
                    experiencia.Pais.id = Int32.Parse(rowsPaises[0]["id"].ToString());
                    experiencia.Pais.name = rowsPaises[0]["name"].ToString();
                    connectionSecundaria.Close();


                    connectionSecundaria = new SqlConnection(constring);
                    experienciasSecundario = new DataSet();
                    query = "Select * From [firstrow_].[dbo].[Etapa] where id_experiencia='" + experiencia.Id + "'";
                    adapterSecundario = new SqlDataAdapter(query, connectionSecundaria);
                    adapterSecundario.Fill(experienciasSecundario, "Etapa");
                    DataTable tableEtapa = experienciasSecundario.Tables["Etapa"];
                    DataRow[] rowsEtapa = tableEtapa.Select();
                    List<ENDia> etapas = new List<ENDia>();
                    for (int j = 0; j < rowsEtapa.Length; j++)
                    {
                        ENDia etapa = new ENDia();
                        etapa.Id = Int32.Parse(rowsEtapa[j]["id"].ToString());
                        etapa.Titulo = rowsEtapa[j]["titulo"].ToString();
                        etapa.Nombre = rowsEtapa[j]["nombre_etapa"].ToString();
                        etapa.Descripcion = rowsEtapa[j]["descripcion"].ToString();
                        etapa.Imagen = rowsEtapa[j]["imagen"].ToString();
                        etapas.Add(etapa);
                    }
                    experiencia.Etapas = etapas;
                    connectionSecundaria.Close();


                    connectionSecundaria = new SqlConnection(constring);
                    experienciasSecundario = new DataSet();
                    query = "Select * From [firstrow_].[dbo].[Experiencia_Incluido] e " +
                    "inner join [firstrow_].[dbo].[Incluidos] i " +
                    "on i.id = e.id_incluido " +
                    "where id_experiencia = '" + experiencia.Id + "'";
                    adapterSecundario = new SqlDataAdapter(query, connectionSecundaria);
                    adapterSecundario.Fill(experienciasSecundario, "Experiencia_Incluido");
                    DataTable tableExperiencia_Incluido = experienciasSecundario.Tables["Experiencia_Incluido"];
                    DataRow[] rowsExperiencia_Incluido = tableExperiencia_Incluido.Select();
                    List<ENIncluido> incluidos = new List<ENIncluido>();
                    for (int j = 0; j < rowsExperiencia_Incluido.Length; j++)
                    {
                        ENIncluido incluido = new ENIncluido();
                        incluido.Id = Int32.Parse(rowsExperiencia_Incluido[j]["id"].ToString());
                        incluido.Titulo = rowsExperiencia_Incluido[j]["titulo"].ToString();
                        incluido.Descripcion = rowsExperiencia_Incluido[j]["descripcion"].ToString();
                        incluidos.Add(incluido);
                    }
                    experiencia.Incluidos = incluidos;
                    connectionSecundaria.Close();


                    connectionSecundaria = new SqlConnection(constring);
                    experienciasSecundario = new DataSet();
                    query = "Select * From [firstrow_].[dbo].[Experiencia_Imagenes] e " +
                        "inner join [firstrow_].[dbo].[Imagenes] i " +
                        "on i.id = e.id_Imagen " +
                        "where id_experiencia = '" + experiencia.Id + "'";
                    adapterSecundario = new SqlDataAdapter(query, connectionSecundaria);
                    adapterSecundario.Fill(experienciasSecundario, "Experiencia_Imagenes");
                    DataTable tableExperiencia_Imagenes = experienciasSecundario.Tables["Experiencia_Imagenes"];
                    DataRow[] rowsExperiencia_Imagenes = tableExperiencia_Imagenes.Select();
                    List<ENImagenes> imagenes = new List<ENImagenes>();
                    for (int j = 0; j < rowsExperiencia_Imagenes.Length; j++)
                    {
                        ENImagenes imagen = new ENImagenes();
                        imagen.Id = Int32.Parse(rowsExperiencia_Imagenes[j]["id"].ToString());
                        imagen.Name = rowsExperiencia_Imagenes[j]["name"].ToString();
                        imagen.Mode = Int32.Parse(rowsExperiencia_Imagenes[j]["mode"].ToString());
                        imagenes.Add(imagen);
                    }
                    experiencia.Imagenes = imagenes;
                    connectionSecundaria.Close();



                    connectionSecundaria = new SqlConnection(constring);
                    experienciasSecundario = new DataSet();
                    query = "Select * From [firstrow_].[dbo].[Experiencia_Comentarios] e " +
                        "inner join [firstrow_].[dbo].[Comentarios] i " +
                        "on i.id = e.id_Comentario " +
                        "where id_experiencia = '" + experiencia.Id + "'";
                    adapterSecundario = new SqlDataAdapter(query, connectionSecundaria);
                    adapterSecundario.Fill(experienciasSecundario, "Experiencia_Comentarios");
                    DataTable tableExperiencia_Comentarios = experienciasSecundario.Tables["Experiencia_Comentarios"];
                    DataRow[] rowsExperiencia_Comentarios = tableExperiencia_Comentarios.Select();
                    List<ENComentarios> comentarios = new List<ENComentarios>();
                    for (int j = 0; j < rowsExperiencia_Comentarios.Length; j++)
                    {
                        ENComentarios comentario = new ENComentarios();
                        comentario.Id = Int32.Parse(rowsExperiencia_Comentarios[j]["id"].ToString());
                        comentario.Texto = rowsExperiencia_Comentarios[j]["texto"].ToString();
                        comentario.Estrellas = Int32.Parse(rowsExperiencia_Comentarios[j]["estrellas"].ToString());
                        ENUsuario usuario = new ENUsuario();
                        usuario.nickname = rowsExperiencia_Comentarios[j]["nickname"].ToString();
                        usuario.readUsuario();
                        comentario.Usuario = usuario;
                        comentarios.Add(comentario);
                    }
                    experiencia.Comentarios = comentarios;
                    connectionSecundaria.Close();

                    listaExperiencias.Add(experiencia);
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

        public bool readExperiencia(ENViajes experiencia)
        {

            SqlConnection conection = null;
            SqlConnection conectionSecundario = null;
            SqlDataReader busqueda = null;
            SqlDataReader busquedaSecundaria = null;

            try
            {
                conection = new SqlConnection(constring);
                conection.Open();

                string query = "Select * From [firstrow_].[dbo].[Experiencias] where slug = @slug";
                SqlCommand consulta = new SqlCommand(query, conection);
                consulta.Parameters.AddWithValue("@slug", experiencia.Slug);
                busqueda = consulta.ExecuteReader();
                busqueda.Read();

                // Lectura de campos de experiencia

                experiencia.Id = Int32.Parse(busqueda["id"].ToString());
                experiencia.Nombre = busqueda["nombre"].ToString();
                experiencia.Titulo = busqueda["titulo"].ToString();
                experiencia.Descripcion = busqueda["descripcion"].ToString();
                experiencia.Slug = busqueda["slug"].ToString();
                experiencia.Precio = Double.Parse(busqueda["precio"].ToString());
                experiencia.Background = busqueda["background"].ToString();
                experiencia.Dias = Int32.Parse(busqueda["dias"].ToString());
                ENEmpresa empresa = new ENEmpresa();
                empresa.nickname = busqueda["empresa"].ToString();
                empresa.readUsuario();
                experiencia.Empresa = empresa;

                try
                {
                    // Lectura de pais de experiencia

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
                    experiencia.Pais = pais;
                    busquedaSecundaria.Close();

                    // Lectura de estapas de experiencia

                    List<ENDia> etapas = new List<ENDia>();
                    querySecundaria = "Select * From [firstrow_].[dbo].[Etapa] where id_experiencia = @id_experiencia";
                    consultaSecundaria = new SqlCommand(querySecundaria, conectionSecundario);
                    consultaSecundaria.Parameters.AddWithValue("@id_experiencia", experiencia.Id);
                    busquedaSecundaria = consultaSecundaria.ExecuteReader();

                    while (busquedaSecundaria.Read())
                    {
                        ENDia etapa = new ENDia();
                        etapa.Id = Int32.Parse(busquedaSecundaria["id"].ToString());
                        etapa.Titulo = busquedaSecundaria["titulo"].ToString();
                        etapa.Nombre = busquedaSecundaria["nombre_etapa"].ToString();
                        etapa.Descripcion = busquedaSecundaria["descripcion"].ToString();
                        etapa.Imagen = busquedaSecundaria["imagen"].ToString();
                        etapas.Add(etapa);
                    }

                    experiencia.Etapas = etapas;
                    busquedaSecundaria.Close();

                    // Lectura de incluidos de experiencia

                    List<ENIncluido> incluidos = new List<ENIncluido>();
                    querySecundaria = "Select * From [firstrow_].[dbo].[Experiencia_Incluido] e " +
                    "inner join [firstrow_].[dbo].[Incluidos] i " +
                    "on i.id = e.id_incluido " +
                    "where id_experiencia = @id_experiencia";
                    consultaSecundaria = new SqlCommand(querySecundaria, conectionSecundario);
                    consultaSecundaria.Parameters.AddWithValue("@id_experiencia", experiencia.Id);
                    busquedaSecundaria = consultaSecundaria.ExecuteReader();

                    while (busquedaSecundaria.Read())
                    {
                        ENIncluido incluido = new ENIncluido();
                        incluido.Id = Int32.Parse(busquedaSecundaria["id"].ToString());
                        incluido.Titulo = busquedaSecundaria["titulo"].ToString();
                        incluido.Descripcion = busquedaSecundaria["descripcion"].ToString();
                        incluidos.Add(incluido);
                    }

                    experiencia.Incluidos = incluidos;
                    busquedaSecundaria.Close();

                    // Lectura de imagenes de experiencia

                    List<ENImagenes> imagenes = new List<ENImagenes>();
                    querySecundaria = "Select * From [firstrow_].[dbo].[Experiencia_Imagenes] e " +
                    "inner join [firstrow_].[dbo].[Imagenes] i " +
                    "on i.id = e.id_Imagen " +
                    "where id_experiencia = @id_experiencia";
                    consultaSecundaria = new SqlCommand(querySecundaria, conectionSecundario);
                    consultaSecundaria.Parameters.AddWithValue("@id_experiencia", experiencia.Id);
                    busquedaSecundaria = consultaSecundaria.ExecuteReader();

                    while (busquedaSecundaria.Read())
                    {
                        ENImagenes imagen = new ENImagenes();
                        imagen.Id = Int32.Parse(busquedaSecundaria["id"].ToString());
                        imagen.Name = busquedaSecundaria["name"].ToString();
                        imagen.Mode = Int32.Parse(busquedaSecundaria["mode"].ToString());
                        imagenes.Add(imagen);
                    }

                    experiencia.Imagenes = imagenes;
                    busquedaSecundaria.Close();

                    // Lectura de comentarios de experiencia

                    List<ENComentarios> comentarios = new List<ENComentarios>();
                    querySecundaria = "Select * From [firstrow_].[dbo].[Experiencia_Comentarios] e " +
                    "inner join [firstrow_].[dbo].[Comentarios] i " +
                    "on i.id = e.id_Comentario " +
                    "where id_experiencia = @id_experiencia";
                    consultaSecundaria = new SqlCommand(querySecundaria, conectionSecundario);
                    consultaSecundaria.Parameters.AddWithValue("@id_experiencia", experiencia.Id);
                    busquedaSecundaria = consultaSecundaria.ExecuteReader();

                    while (busquedaSecundaria.Read())
                    {
                        ENComentarios comentario = new ENComentarios();
                        comentario.Id = Int32.Parse(busquedaSecundaria["id"].ToString());
                        comentario.Texto = busquedaSecundaria["texto"].ToString();
                        comentario.Estrellas = Int32.Parse(busquedaSecundaria["estrellas"].ToString());

                        // Lectura de usuario del comentario

                        ENUsuario usuario = new ENUsuario();
                        usuario.nickname = busquedaSecundaria["nickname"].ToString();
                        usuario.readUsuario();
                        comentario.Usuario = usuario;
                        comentarios.Add(comentario);
                    }

                    experiencia.Comentarios = comentarios;
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

        internal bool updateImagen(ENViajes eNViajes)
        {
            throw new NotImplementedException();
        }
        internal bool deleteImagen(ENViajes eNViajes)
        {
            throw new NotImplementedException();
        }
        internal bool createIncluido(ENViajes eNViajes)
        {
            throw new NotImplementedException();
        }
        internal bool readIncluido(ENViajes eNViajes)
        {
            throw new NotImplementedException();
        }
        internal bool updateIncluido(ENViajes eNViajes)
        {
            throw new NotImplementedException();
        }
        internal bool deleteIncluido(ENViajes eNViajes)
        {
            throw new NotImplementedException();
        }


    }
}
