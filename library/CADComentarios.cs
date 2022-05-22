using System;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADComentarios
    {
        private String constring;
        ArrayList lista = new ArrayList();

        public CADComentarios()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }
        private int _Id;
        private string _Texto;
        private int _Estrellas;
        private string _Nickname;

        public int Id //GET-SET
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Texto //GET-SET
        {
            get { return _Texto; }
            set { _Texto = value; }
        }
        public int Estrellas //GET-SET
        {
            get { return _Estrellas; }
            set { _Estrellas = value; }
        }
        public string Nickname //GET-SET
        {
            get { return _Nickname; }
            set { _Nickname = value; }
        }
        public bool InsertComennt(ENComentarios comentario, int id, bool mode)
        {

            bool created = false;
            SqlConnection connection = new SqlConnection(constring);
            try
            {
                connection = new SqlConnection(constring);
                connection.Open();

                string query = "Insert INTO [Comentarios] " +
                    "(texto,nickname,estrellas) " +
                    "VALUES " +
                    "(@texto,@nickname,@estrellas) " +
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

        public void DeleteComennt(ENComentarios c)
        {
            SqlConnection nueva_conexion = new SqlConnection(constring);

            try
            {
                nueva_conexion.Open();
                string delete = "";
                delete = "Delete from Files where CommentsContent.Id = " + c.Id + "AND CommentsContent.Texto" + c.Texto + "AND CommentsContent.Nickname" + c.Usuario.nickname + "AND CommentsContent.Estrellas" + c.Estrellas;
                SqlCommand com = new SqlCommand(delete, nueva_conexion);


                com.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { nueva_conexion.Close(); }
        }
    }
}

    

