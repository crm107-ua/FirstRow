using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADStories
    {
        private String constring;

        public CADStories()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        public bool CreateStory(ENStories story)
        {
            bool created = false;
            SqlConnection connection = new SqlConnection(constring);
            try
            {
                connection.Open();
                string query = "INSERT INTO [firstrow_].[dbo].[Stories] " +
                    "(id, titulo, descripcion, fecha, pais, usuario, imagen) VALUES " +
                    "(@Id, @Titulo, @Descripcion, @Fecha, @Pais, @Usuario, @Imagen)";
                
                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@Id", story.Id);
                com.Parameters.AddWithValue("@Titulo", story.Titulo);
                com.Parameters.AddWithValue("@Descripcion", story.Descripcion);
                com.Parameters.AddWithValue("@Fecha", story.Fecha);
                com.Parameters.AddWithValue("@Pais", story.Pais);
                com.Parameters.AddWithValue("@Usuario", story.Usuario);
                com.Parameters.AddWithValue("@Imagen", story.Imagen);
                com.ExecuteNonQuery();
                created = true;
            }
            catch (SqlException e)
            {
                created = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                created = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
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

        public bool ReadStory(ENStories story)
        {
            bool correctRead = false;
            return correctRead;
        }

        public bool ReadFirstStory(ENStories story)
        {
            bool correctRead = false;
            return correctRead;
        }

        public bool UpdateStory(ENStories story)
        {
            bool updated = false;
            return updated;
        }

        public bool DeleteStory(ENStories story)
        {
            bool deleted = false;
            return deleted;
        }

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
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                correctRead = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
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
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                correctRead = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
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
