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
                SqlDataAdapter da = new SqlDataAdapter("select * from [Reservas]", c);
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
                    query = "Select * From [Reservas] where id = @id";
                    consulta = new SqlCommand(query, conection);
                    consulta.Parameters.AddWithValue("@id", reserva.id);
                }
                else
                {
                    query = "Select * From [Reservas] where id = @id";
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

        internal DataTable readReservasEmpresa(string empresa)
        {
            SqlConnection connection = null;
            DataSet reservas = null;
            DataTable tablaReservas = null;

            try
            {
                connection = new SqlConnection(constring);
                reservas = new DataSet();
                string query = "Select r.id,r.nombre,r.descripcion,r.experiencia,r.fechaEntrada,r.fechaSalida,r.usuario, r.precio_asignado, r.personas " +
                               "From [Reservas] r " +
                               "inner join Experiencias ex " +
                               "on ex.id = r.experiencia " +
                               "inner join Empresas emp " +
                               "on emp.nickname = ex.empresa " +
                               "where emp.nickname = " + empresa + ";";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(reservas, "Reservas");
                tablaReservas = reservas.Tables["Reservas"];
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DataException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return tablaReservas;
        }

        internal DataTable readReservasUsuario(ENUsuario usuario)
        {
            SqlConnection connection = null;
            DataSet reservas = null;
            DataTable tablaReservas = null;

            try
            {
                connection = new SqlConnection(constring);
                reservas = new DataSet();
                string query = "Select r.id,r.nombre,r.descripcion,r.experiencia,r.fechaEntrada,r.fechaSalida,r.usuario, r.precio_asignado, r.personas " +
                               "From [Reservas] r " +
                               "where usuario = '" + usuario.nickname + "';";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(reservas, "ReservasUsuario");
                tablaReservas = reservas.Tables["ReservasUsuario"];
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DataException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return tablaReservas;
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
                    string query = "INSERT INTO [Reservas] " +
                        "(nombre, descripcion, experiencia, fechaEntrada, fechaSalida, usuario, precio_asignado, personas, numero) VALUES " +
                        "(@name, @descripcion,@experiencia,@fechaEntrada, @fechaSalida,@usuario,@precio,@nPersonas,@telefono)";

                    SqlCommand com = new SqlCommand(query, connection);
                    com.Parameters.AddWithValue("@name", reserva.usuario.name);
                    com.Parameters.AddWithValue("@descripcion", reserva.descripcion);
                    com.Parameters.AddWithValue("@experiencia", reserva.experiencia.Id);
                    com.Parameters.AddWithValue("@fechaEntrada", reserva.fechaEntrada.ToString("yyyy-MM-dd HH:mm:ss.ffffff"));
                    com.Parameters.AddWithValue("@fechaSalida", reserva.fechaSalida.ToString("yyyy-MM-dd HH:mm:ss.ffffff"));
                    com.Parameters.AddWithValue("@usuario", reserva.usuario.nickname);
                    com.Parameters.AddWithValue("@precio", reserva.precio);
                    com.Parameters.AddWithValue("@nPersonas", reserva.personas);
                    com.Parameters.AddWithValue("@telefono", reserva.telefono);


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

        internal DataTable readTopClientesEmpresa(ENEmpresa empresa)
        {
            SqlConnection connection = null;
            DataSet clientes = null;
            DataTable tablaReservas = null;

            try
            {
                connection = new SqlConnection(constring);
                clientes = new DataSet();
                string query = "select top 3 count(u.nickname) as TotalReservas, " +
                               "u.nickname, u.email, u.name, u.firstname, u.secondname, u.facebook, u.twitter " +
                               "from Usuarios u " +
                               "inner join Reservas r " +
                               "on u.nickname = r.usuario " +
                               "inner join Experiencias e " +
                               "on r.experiencia = e.id " +
                               "where e.empresa='" + empresa.nickname+ "' " +
                               "group by u.nickname, u.email, u.name, u.firstname, u.secondname, u.facebook, u.twitter " +
                               "order by TotalReservas desc;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(clientes, "Clientes");
                tablaReservas = clientes.Tables["Clientes"];
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DataException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return tablaReservas;
        }

        internal bool deleteReserva(ENReserva reserva)
        {

            bool deleted = false;
            return deleted;
        }
    }


  

}
