using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace library
{
    public class CADPropuestas
    {
        private String constring;

        public CADPropuestas()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        public DataSet readPropuesta(ENPropuestas eNPropuestas, bool v)
        {
            SqlConnection c = null;

            try
            {
                c = new SqlConnection(constring);
                DataSet bd = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select * from [firstrow_].[dbo].[Propuestas]", c);
                da.Fill(bd, "Propuestas");
                return bd;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (c != null)
                {
                    c.Close();
                }
            }
        }

        internal bool readPropuesta(ENReserva propuesta, bool mode)
        {

            SqlConnection conection = null;
            SqlDataReader busqueda = null;

            try
            {
                conection = new SqlConnection(constring);
                SqlCommand consulta = new SqlCommand();
                conection.Open();
                string query = "";

                if (mode)
                {
                    query = "Select * From [firstrow_].[dbo].[Propuestas] where id = @id";
                    consulta = new SqlCommand(query, conection);
                    consulta.Parameters.AddWithValue("@id", propuesta.id);
                }
                else
                {
                    query = "Select * From [firstrow_].[dbo].[Propuestas] where id = @id";
                    consulta = new SqlCommand(query, conection);
                    consulta.Parameters.AddWithValue("@id", propuesta.id);
                }
                busqueda = consulta.ExecuteReader();
                busqueda.Read();

                // Lectura de campos de reserva

                propuesta.id = Int32.Parse(busqueda["id"].ToString());
                propuesta.descripcion = busqueda["descripcion"].ToString();

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

        internal DataSet readPropuestas()
        {
            throw new NotImplementedException();
        }

        internal DataSet readPropuesta()
        {
            throw new NotImplementedException();
        }

        internal bool readPropuestas(ENPropuestas eNPropuestas, bool v)
        {
            throw new NotImplementedException();
        }

        internal bool newPropuesta(ENPropuestas propuesta)
        {
            bool creado = false;
            if (propuesta is ENPropuestas)
            {
                bool created = false;
                SqlConnection connection = new SqlConnection(constring);
                try
                {
                    connection.Open();
                    string query = "INSERT INTO [firstrow_].[dbo].[Propuestas] " +
                        "(id, titulo, texto, imagen, usario, empresa, slug) VALUES " +
                        $"({propuesta.id}, ,{propuesta.descripcion})";

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

            return creado;
        }

        internal bool deletePropuesta(ENPropuestas propuestas)
        {

            bool deleted = false;
            return deleted;


        }

    }
}
