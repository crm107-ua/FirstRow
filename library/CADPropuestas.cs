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

        public bool readPropuestas(List<ENPropuestas> propuestas) 
        {
            try
            {
                DataSet dbd = new DataSet();
                SqlConnection connection = new SqlConnection(constring);
                SqlDataAdapter adapter = new SqlDataAdapter("select * from [Propuestas]", connection);
                adapter.Fill(dbd, "Propuestas");

                DataTable tableGaleria = dbd.Tables["Propuestas"];
                DataRow[] rowsPropuestas = tableGaleria.Select();

                propuestas.Clear();

                for (int i = 0; i < rowsPropuestas.Length; i++)
                {
                    ENPropuestas aux = new ENPropuestas();

                    aux.Id =int.Parse( rowsPropuestas[i]["id"].ToString());
                    aux.Imagenes=
                }
            catch (Exception e) 
            {
                return false;
            }

            return true;
        }

        private DataSet readPropuestasAux()
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

        //Para busqyesda con slug v=  true si no para id
        internal bool readPropuesta(ENPropuestas propuesta, bool v)
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
                    query = "Select * From [Propuestas] where slug = @slug";
                    consulta = new SqlCommand(query, conection);
                    consulta.Parameters.AddWithValue("@slug", propuesta.Slug);
                }
                else
                {
                    query = "Select * From [Propuestas] where id = @id";
                    consulta = new SqlCommand(query, conection);
                    consulta.Parameters.AddWithValue("@id", propuesta.Id);

                }
                busqueda = consulta.ExecuteReader();
                busqueda.Read();
                propuesta.Titulo = busqueda["titulo"].ToString();
                propuesta.Texto = busqueda["texto"].ToString();
                propuesta.Imagenes.Name = busqueda["imagen"].ToString();
                propuesta.Usuario.nickname = busqueda["usuario"].ToString();
                propuesta.Empresa.nickname = busqueda["empresa"].ToString();

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

        internal bool newPropuesta(ENPropuestas propuesta)
        {
            bool anadido = false;
            SqlConnection conection = null;
            try
            {
                conection = new SqlConnection(constring);
                conection.Open();

                string query = "Insert INTO [dbo].[Propuestas] (titulo,texto,slug,imagen,usuario,empresa) VALUES ( @titulo , @texto , @slug , @imagen, @usuario, @empresa)";

                SqlCommand com = new SqlCommand(query, conection);
                com.Parameters.AddWithValue("@titulo", propuesta.Titulo);
                com.Parameters.AddWithValue("@texto", propuesta.Texto);
                com.Parameters.AddWithValue("@slug", propuesta.Slug);
                com.Parameters.AddWithValue("@imagen", propuesta.Imagenes.Name);
                com.Parameters.AddWithValue("@usuario", propuesta.Usuario.nickname);
                com.Parameters.AddWithValue("@empresa", propuesta.Empresa.nickname);

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
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return anadido;

        }
        internal bool deletePropuesta(ENPropuestas propuestas)
        {

            bool anadido = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();

                string s = "delete from [Propuestas] where slug=@slug";
                SqlCommand com = new SqlCommand(s, c);
                com.Parameters.AddWithValue("@slug", propuestas.Slug);
                com.Parameters.AddWithValue("@slug", propuestas.Slug);
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

    }
}