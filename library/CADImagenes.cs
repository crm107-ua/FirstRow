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
                string comando = "insert into [firstrow_].[dbo].[Imagenes]" +
                    " (name, mode) values (@name,@mode); " +
                    "select SCOPE_IDENTITY();";
                
                SqlCommand sqlCommand = new SqlCommand(comando,connection);
                sqlCommand.Parameters.AddWithValue("@name", img.Name);
                sqlCommand.Parameters.AddWithValue("@mode", img.Mode);
                img.Id= Convert.ToInt32(sqlCommand.ExecuteScalar());
                
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
            bool consegido= false;
            SqlConnection connection = new SqlConnection(constring);

            try
            {
                connection.Open();
                string comando = "delete from [dbo].[Imagenes] where name=@name;";

                SqlCommand sqlCommand = new SqlCommand(comando, connection);
                sqlCommand.Parameters.AddWithValue("@name", img.Name);
                sqlCommand.ExecuteNonQuery();

                consegido = true;
            }
            catch (Exception excepcion)
            {
            }
            finally
            {
                connection.Close();
            }

            return consegido;
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
