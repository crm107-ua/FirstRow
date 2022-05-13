using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class CADImagenes
    {
        private string constring;

        public CADImagenes() 
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        public bool addImg(ENImagenes img)
        {
            bool created = false;
            SqlConnection connection = new SqlConnection(constring);

            try
            {
                connection.Open();
                string comando = "insert into [dbo].[Imagenes] (name, mode) values (@name, @mode);";

                SqlCommand sqlCommand = new SqlCommand(comando,connection);
                sqlCommand.Parameters.AddWithValue("@nombre", img.Name);
                sqlCommand.Parameters.AddWithValue("@mode", img.Name);
                img.Id= Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand.ExecuteNonQuery();
                created = true;
            }
            catch (Exception excepcion)
            { 
            }
            finally
            {
                connection.Close();
            }

            return created;
        }
        public bool deleteImg(ENImagenes img)
        {
            bool created = false;
            SqlConnection connection = new SqlConnection(constring);

            try
            {
                connection.Open();
                string comando = "delete from [dbo].[Imagenes] where id=@id;";

                SqlCommand sqlCommand = new SqlCommand(comando, connection);
                sqlCommand.Parameters.AddWithValue("@id", img.Id);
                sqlCommand.ExecuteNonQuery();
                created = true;
            }
            catch (Exception excepcion)
            {
            }
            finally
            {
                connection.Close();
            }

            return created;
        }

        public bool readImg(ENImagenes img)
        {
            bool created = false;
            SqlConnection connection = new SqlConnection(constring);

            try
            {
                connection.Open();
                string comando = "select * from [dbo].[Imagenes] where id=@id;";

                SqlCommand sqlCommand = new SqlCommand(comando, connection);
                sqlCommand.Parameters.AddWithValue("@id", img.Name);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                reader.Read();

                img.Name = reader["name"].ToString();

                created = true;
            }
            catch (Exception excepcion)
            {
            }
            finally
            {
                connection.Close();
            }

            return created;
        }
    }
}
