using System;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;
using System.Transactions;

namespace library
{
    public class CADComentarios
    {
        private String constring;

        public CADComentarios()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        public bool readComentario(ENComentarios comentario)
        {

            SqlConnection conection = null;
            SqlDataReader busqueda = null;

            try
            {
                conection = new SqlConnection(constring);
                SqlCommand consulta = new SqlCommand();
                conection.Open();
                string query = query = "Select * From [Comentarios] where id = @id";
                consulta = new SqlCommand(query, conection);
                consulta.Parameters.AddWithValue("@id", comentario.Id);
                busqueda = consulta.ExecuteReader();
                busqueda.Read();

                // Lectura de campos de comentario

                comentario.Texto = busqueda["texto"].ToString();
                comentario.Usuario.nickname = busqueda["nickname"].ToString();
                comentario.Usuario.readUsuario();
                comentario.Estrellas = Int32.Parse(busqueda["estrellas"].ToString());

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

        public bool InsertComennt(ENComentarios comentario, int id, bool mode)
        {
            /**
             * El mode indica donde se inserta true blog, false experiencia
             */
            bool created = false;

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    //Primera transacion
                    using (SqlConnection connection = new SqlConnection(constring))
                    {

                        connection.Open();

                        string query = "Insert INTO [Comentarios] " +
                            "(texto,nickname,estrellas) " +
                            "VALUES " +
                            "(@texto,@nickname,@estrellas); " +
                            "select scope_identity()";
                        SqlCommand consulta = new SqlCommand(query, connection);
                        consulta.Parameters.AddWithValue("@texto", comentario.Texto);
                        consulta.Parameters.AddWithValue("@nickname", comentario.Usuario.nickname);
                        consulta.Parameters.AddWithValue("@estrellas", comentario.Estrellas);
                        int ultimoID_Comentario = Convert.ToInt32(consulta.ExecuteScalar());

                        if (mode)
                        {
                            query = "Insert INTO [Blog_Comentarios] " +
                            "(id_Blog,id_Comentario) " +
                            "VALUES " +
                            "(@id_Blog,@id_Comentario);";

                            consulta = new SqlCommand(query, connection);
                            consulta.Parameters.AddWithValue("@id_Blog", id);
                            consulta.Parameters.AddWithValue("@id_Comentario", ultimoID_Comentario);

                        }
                        else
                        {
                            query = "Insert INTO [Experiencia_Comentarios] " +
                            "(id_Experiencia,id_Comentario) " +
                            "VALUES " +
                            "(@id_Experiencia,@id_Comentario);";

                            consulta = new SqlCommand(query, connection);
                            consulta.Parameters.AddWithValue("@id_Experiencia", id);
                            consulta.Parameters.AddWithValue("@id_Comentario", ultimoID_Comentario);
                        }

                        consulta.ExecuteNonQuery();

                        created = true;
                        connection.Close();
                    }

                    scope.Complete();
                }
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
            return created;
        }

        public bool DeleteComennt(ENComentarios comentario)
        {
            bool deleted = false;

            SqlConnection connection = new SqlConnection(constring);

            try
            {
                connection.Open();
                // Propagacion automatica de la eliminacion en las tablas relacionales
                string query = "Delete from [Comentarios] " +
                    "where id = @id";
                SqlCommand consulta = new SqlCommand(query, connection);
                consulta.Parameters.AddWithValue("@id", comentario.Id);
                consulta.ExecuteNonQuery();

                deleted = true;
            }
            catch (SqlException e)
            {
                deleted = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                deleted = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            return deleted;
        }

    }
}

    

