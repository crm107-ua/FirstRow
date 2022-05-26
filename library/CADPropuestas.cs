using System;
using System.Collections.Generic;
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


        internal DataSet readPropuestas()
        {

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(constring);
                DataSet bd = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select * from [Propuesta]", c);
                da.Fill(bd, "Propuesta");
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






        internal DataSet readPropuestas(ENPropuestas eNPropuestas)
        {
            SqlConnection c = null;

            try
            {
                c = new SqlConnection(constring);
                DataSet bd = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select * from [Propuestas]", c);
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

        internal bool readPropuestas(ENPropuestas propuesta, bool v)
        {

            SqlConnection conection = null;
            SqlDataReader busqueda = null;

            try
            {
                conection = new SqlConnection(constring);
                SqlCommand consulta = new SqlCommand();
                conection.Open();
                string query = "";

                if (v)
                {
                    query = "Select * From [Propuestas] where id = @id";
                    consulta = new SqlCommand(query, conection);
                    consulta.Parameters.AddWithValue("@id", propuesta.Id);
                }
                else
                {
                    query = "Select * From [Propuestas] where id = @id";
                    consulta = new SqlCommand(query, conection);
                    consulta.Parameters.AddWithValue("@id", propuesta.Id);
                }
                busqueda = consulta.ExecuteReader();
                busqueda.Read();



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




        public bool readpropuestasconectado(List<ENPropuestas> lista)
        {
            bool correctRead;
            SqlConnection connection = null;
            SqlDataReader busqueda = null;

            try
            {
                connection = new SqlConnection(constring);
                connection.Open();

                string query = "SELECT * FROM [Propuestas]";
                SqlCommand consulta = new SqlCommand(query, connection);
                busqueda = consulta.ExecuteReader();

                while (busqueda.Read())
                {
                    //int id = int.Parse(busqueda["id"].ToString());
                    ENPropuestas propuesta;

                    propuesta = new ENPropuestas
                    {
                        Id = Int32.Parse(busqueda["id"].ToString()),
                        Titulo = busqueda["titulo"].ToString(),
                        Descripcion = busqueda["descripcion"].ToString(),
                        Slug = busqueda["slug"].ToString()
                    };

                    lista.Add(propuesta);
                }

                correctRead = true;

            }
            catch (SqlException e)
            {
                Console.WriteLine("Sorteo operation has failed.Error: {0}", e.Message);
                correctRead = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorteo operation has failed.Error: {0}", e.Message);
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

        internal bool newPropuesta(ENPropuestas propuesta)
        {
            bool anadido = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();

                string s = "Insert INTO [dbo].[Propuestas] (titulo,descripcion,slug,imagen,usuario,empresa) VALUES ( @titulo , @descripcion , @slug , @imagen, @usuario, @empresa)";

                SqlCommand com = new SqlCommand(s, c);
                com.Parameters.AddWithValue("@titulo", propuesta.Titulo);
                com.Parameters.AddWithValue("@descripcion", propuesta.Descripcion);
                com.Parameters.AddWithValue("@slug", propuesta.Slug);
                com.Parameters.AddWithValue("@imagen", propuesta.Imagenes);
                com.Parameters.AddWithValue("@usuario", propuesta.Usuario);
                com.Parameters.AddWithValue("@empresa", propuesta.Empresa);

                com.ExecuteNonQuery();
                anadido = true;
            }
            catch (SqlException e)
            {
                anadido = false;

                Console.WriteLine("Fallo: {0}", e.Message);
            }
            catch (Exception e)
            {
                anadido = false;
                Console.WriteLine("Fallo: {0}", e.Message);
            }
            finally
            {
                c.Close();
            }
            return anadido;

        }

        internal bool deletePropuesta(ENPropuestas propuestas)
        {

            bool deleted = false;
            return deleted;


        }

    }
}