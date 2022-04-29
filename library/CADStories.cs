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
                string query = "INSERT INTO [FirstRow].[Stories] " +
                    "(id, titulo, descripcion, fecha, pais, usuario, slug, imagen) VALUES " +
                    $"({story.Id}, {story.Titulo}, {story.Descripcion}, {story.Fecha}, {story.Pais}, {story.Usuario}, {story.slug}, {story.Imagen})";
                
                SqlCommand com = new SqlCommand(query, connection);
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

                string query = "SELECT * FROM [FirstRow].[Stories]";
                SqlCommand consulta = new SqlCommand(query, connection);
                busqueda = consulta.ExecuteReader();

                while (busqueda.Read())
                {
                    int id = int.Parse(busqueda["id"].ToString());
                    ENUsuario user = (ENUsuario) busqueda["usuario"];
                    //ENUsuario user = new ENUsuario();
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
   
    }
}
