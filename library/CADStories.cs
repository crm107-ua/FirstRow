using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    /// <summary>
    /// Administra las stories de la base de datos
    /// </summary>
    public class CADStories
    {
        /// <summary>
        /// Cadena de conexión
        /// </summary>
        private String constring;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public CADStories()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        /// <summary>
        /// Guarda una story en la base de datos
        /// </summary>
        /// <param name="story">Story a almacenar</param>
        /// <returns>true: si se ha completado con éxito;
        /// false: si no se ha completado</returns>
        public bool CreateStory(ENStories story)
        {
            bool created = false;
            SqlConnection connection = new SqlConnection(constring);
            try
            {
                connection.Open();
                
                string query = "INSERT INTO [firstrow_].[dbo].[Stories] " +
                    "(titulo, descripcion, fecha, pais, usuario, imagen) VALUES " +
                    "(@Titulo, @Descripcion, @Fecha, @Pais, @Usuario, @Imagen)";
                
                SqlCommand com = new SqlCommand(query, connection);
                //com.Parameters.AddWithValue("@Id", story.Id);
                com.Parameters.AddWithValue("@Titulo", story.Titulo);
                com.Parameters.AddWithValue("@Descripcion", story.Descripcion);
                com.Parameters.AddWithValue("@Fecha", story.Fecha);
                com.Parameters.AddWithValue("@Pais", story.Pais);
                com.Parameters.AddWithValue("@Usuario", story.Usuario.nickname);
                com.Parameters.AddWithValue("@Imagen", story.Imagen);
                //story.Id = Convert.ToInt32(com.ExecuteScalar());

                /*
                string query = "INSERT INTO [firstrow_].[dbo].[Stories] " +
                    "(id, titulo, descripcion, fecha, pais, usuario, imagen) VALUES " +
                    $"({story.Id}, {story.Titulo}, {story.Descripcion}, {story.Fecha}, " +
                    $"{story.Pais}, {story.Usuario}, {story.Imagen})";

                SqlCommand com = new SqlCommand(query, connection);
                */
                com.ExecuteNonQuery();
                created = true;
            }
            catch (SqlException e)
            {
                created = false;
                Console.WriteLine("Story operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                created = false;
                Console.WriteLine("Story operation has failed.Error: {0}", e.Message);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return created;
        }

        /// <summary>
        /// Lee una story de la BD
        /// </summary>
        /// <param name="story"></param>
        /// <returns>true: si se ha completado con éxito;
        /// false: si no se ha completado</returns>
        public bool ReadStory(ENStories story)
        {
            bool correctRead = false;
            return correctRead;
        }

        /// <summary>
        /// Actualiza una story
        /// </summary>
        /// <param name="story"></param>
        /// <returns>true: si se ha completado con éxito;
        /// false: si no se ha completado</returns>
        public bool UpdateStory(ENStories story)
        {
            bool updated = false;
            return updated;
        }

        /// <summary>
        /// Elimina una story
        /// </summary>
        /// <param name="story"></param>
        /// <returns>true: si se ha completado con éxito;
        /// false: si no se ha completado</returns>
        public bool DeleteStory(ENStories story)
        {
            bool deleted = false;
            return deleted;
        }

        /// <summary>
        /// Lee todas las stories
        /// </summary>
        /// <param name="listStories"></param>
        /// <returns>true: si se ha completado con éxito;
        /// false: si no se ha completado</returns>
        public bool ReadAllStories(List<ENStories> listStories)
        {
            bool correctRead;
            SqlConnection connection = null;
            SqlDataReader busqueda = null;

            try
            {
                connection = new SqlConnection(constring);
                connection.Open();

                string query = "SELECT * FROM [firstrow_].[dbo].[Stories]";
                SqlCommand consulta = new SqlCommand(query, connection);
                busqueda = consulta.ExecuteReader();

                //listStories.Add(new ENStories(1, new ENUsuario(), new DateTime(), "titulo", 2, "desc", "https://img.freepik.com/vector-gratis/resumen-fondo-plateado-claro_67845-796.jpg"));
                
                while (busqueda.Read())
                {
                    int id = int.Parse(busqueda["id"].ToString());
                    ENUsuario user = new ENUsuario();
                    user.nickname = busqueda["usuario"].ToString();
                    _ = user.readUsuario();
                    DateTime fecha = DateTime.Parse(busqueda["fecha"].ToString());
                    string titulo = busqueda["titulo"].ToString();
                    int pais = int.Parse(busqueda["pais"].ToString());
                    string desc = busqueda["descripcion"].ToString();
                    string img = busqueda["imagen"].ToString();

                    listStories.Add(new ENStories(
                        id, 
                        user,
                        fecha,
                        titulo,
                        pais,
                        desc,
                        img));
                }

                correctRead = true;

            }catch (SqlException e)
            {
                Console.WriteLine("Story operation has failed.Error: {0}", e.Message);
                correctRead = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Story operation has failed.Error: {0}", e.Message);
                correctRead = false;
            }
            finally
            {
                if (busqueda != null)
                {
                    busqueda.Close();
                }
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return correctRead;
        }

        /// <summary>
        /// Lee todas las stories de un país
        /// </summary>
        /// <param name="listStories"></param>
        /// <param name="pais">true: si se ha completado con éxito;
        /// false: si no se ha completado</param>
        /// <returns></returns>
        public bool ReadAllStories(List<ENStories> listStories, int pais)
        {
            bool correctRead;
            SqlConnection connection = null;
            SqlDataReader busqueda = null;

            try
            {
                connection = new SqlConnection(constring);
                connection.Open();

                string query = "SELECT * FROM [firstrow_].[dbo].[Stories] WHERE pais = @pais ";
                SqlCommand consulta = new SqlCommand(query, connection);
                consulta.Parameters.AddWithValue("@pais", pais);
                busqueda = consulta.ExecuteReader();

                //listStories.Add(new ENStories(1, new ENUsuario(), new DateTime(), "titulo", 2, "desc", "https://img.freepik.com/vector-gratis/resumen-fondo-plateado-claro_67845-796.jpg"));

                while (busqueda.Read())
                {
                    int id = int.Parse(busqueda["id"].ToString());
                    ENUsuario user = new ENUsuario();
                    user.nickname = busqueda["usuario"].ToString();
                    _ = user.readUsuario();
                    DateTime fecha = DateTime.Parse(busqueda["fecha"].ToString());
                    string titulo = busqueda["titulo"].ToString();
                    string desc = busqueda["descripcion"].ToString();
                    string img = busqueda["imagen"].ToString();

                    listStories.Add(new ENStories(
                        id,
                        user,
                        fecha,
                        titulo,
                        pais,
                        desc,
                        img));
                }

                correctRead = true;

            }
            catch (SqlException e)
            {
                Console.WriteLine("Story operation has failed.Error: {0}", e.Message);
                correctRead = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Story operation has failed.Error: {0}", e.Message);
                correctRead = false;
            }
            finally
            {
                if (busqueda != null)
                {
                    busqueda.Close();
                }
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return correctRead;
        }

    }
}
