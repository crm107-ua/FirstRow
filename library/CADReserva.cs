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

        internal bool readReservasEmpresa(List<ENReserva> reservasEmpresa, string empresa)
        {

            bool leido = false;
            SqlConnection connection = null;
            DataSet reservas = null;
            ENReserva reserva;

            try
            {
                connection = new SqlConnection(constring);
                reservas = new DataSet();
                string query = "Select * From [firstrow_].[dbo].[Reservas] r " +
                               "inner join Experiencias ex " +
                               "on ex.id = r.experiencia " +
                               "inner join Empresas emp " +
                               "on emp.nickname = ex.empresa " +
                               "where emp.nickname = " + empresa + ";";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(reservas, "Reservas");
                DataTable tableReservas = reservas.Tables["Reservas"];
                DataRow[] rowsReservas = tableReservas.Select();

                for (int i = 0; i < rowsReservas.Length; i++)
                {
                    reserva = new ENReserva();

                    reserva.id = Int32.Parse(rowsReservas[i]["id"].ToString());
                    reserva.nombre = rowsReservas[i]["nombre"].ToString();
                    reserva.descripcion = rowsReservas[i]["descripcion"].ToString();
                    reserva.experiencia.Id = Int32.Parse(rowsReservas[i]["experiencia"].ToString());
                    reserva.experiencia.mostrarExperiencia();
                    reserva.fechaEntrada = (DateTime)rowsReservas[i]["fechaEntrada"];
                    reserva.fechaSalida = (DateTime)rowsReservas[i]["fechaSalida"];
                    reserva.usuario.nickname = rowsReservas[i]["nickname"].ToString();
                    reserva.usuario.readUsuario();
                    reserva.precio = Int32.Parse(rowsReservas[i]["precio"].ToString());
                    reserva.personas = Int32.Parse(rowsReservas[i]["personas"].ToString());
                    reservasEmpresa.Add(reserva);
                }

                leido = true;
            }
            catch (DataException e)
            {
                Console.WriteLine(e.Message);
                leido = false;
            }
            finally
            {
                connection.Close();
            }

            return leido;
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
