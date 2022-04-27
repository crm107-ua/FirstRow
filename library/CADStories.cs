using System;
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
                    "(id, titulo, descripcion, fecha, pais, usuario) VALUES " +
                    $"({story.Id}, {story.Titulo}, {story.Descripcion}, {story.Fecha}, {story.Pais}, {story.Usuario})";
                
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
   
    }
}
