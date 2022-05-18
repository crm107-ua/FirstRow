using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class CADReserva
    {
        private String constring;
        public CADReserva()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        public DataSet readReservas()
        {

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(constring);
                DataSet bd = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select * from [firstrow_].[dbo].[Reservas]", c);
                da.Fill(bd, "Reserva");
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

        internal bool readReserva(ENReserva reserva, bool mode)
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
                    query = "Select * From [firstrow_].[dbo].[Reservas] where id = @id";
                    consulta = new SqlCommand(query, conection);
                    consulta.Parameters.AddWithValue("@id", reserva.id);
                }
                else
                {
                    query = "Select * From [firstrow_].[dbo].[Reservas] where id = @id";
                    consulta = new SqlCommand(query, conection);
                    consulta.Parameters.AddWithValue("@id", reserva.id);
                }
                busqueda = consulta.ExecuteReader();
                busqueda.Read();

                // Lectura de campos de reserva
                reserva.nombre = busqueda["nombre"].ToString();
                reserva.id = Int32.Parse(busqueda["id"].ToString());
                reserva.descripcion = busqueda["descripcion"].ToString();
                reserva.fechaEntrada = DateTime.Parse(busqueda["fechaEntrada"].ToString());
                reserva.fechaSalida = DateTime.Parse(busqueda["fechaSalida"].ToString());
                reserva.id = Int32.Parse(busqueda["telefono"].ToString());
                reserva.personas = Int16.Parse(busqueda["personas"].ToString());
                reserva.precio = int.Parse(busqueda["precio"].ToString());
 


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

        internal bool registerReserva(ENReserva reserva)
        {
            bool creado = false;
            if (reserva is ENReserva)
            {

                bool created = false;
                SqlConnection connection = new SqlConnection(constring);
                try
                {
                    connection.Open();
                    string query = "INSERT INTO [firstrow_].[dbo].[Reservas] " +
                        "(id, nombre, descripcion, experiencia, fechaEntrada, fechaSalida, usuario, precio_asignado, personas, numero) VALUES " +
                        $"({reserva.id}, {reserva.usuario.name}, {reserva.descripcion},{reserva.experiencia.Id},{reserva.fechaEntrada.ToString()},{reserva.fechaSalida.ToString()},{reserva.usuario.nickname},{reserva.precio},{reserva.personas},{reserva.telefono})";

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

        internal bool deleteReserva(ENReserva reserva)
        {

            bool deleted = false;
            return deleted;


        }
    }


  

}
