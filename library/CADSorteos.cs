using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace library
{
    public class CADSorteos
    {
        private String constring;

        public CADSorteos()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        internal bool addParticipante(ENSorteos en)
        {
            //TODO: addParticipante
            bool anadido = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {

                c.Open();

                string s = "Insert INTO [dbo].[Sorteo_Usuarios] (titulo,descripcion,slug,imagen,FechaInicio,FechaFinal) VALUES ('" + en.Nombre + "','" + en.Descripcion + "','" + en.Slug + "','" + en.Imagen + "','" + en.FechaInicio + "','" + en.FechaFinal + "')";

                SqlCommand com = new SqlCommand(s, c);
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

        internal bool deleteParticipante(ENSorteos eNSorteos)
        {
            throw new NotImplementedException();
        }

        internal bool raffle(ENSorteos eNSorteos)
        {
            throw new NotImplementedException();
        }
        public bool readsorteosconectado(List<ENSorteos> lista)
        {
            bool correctRead;
            SqlConnection connection = null;
            SqlDataReader busqueda = null;

            try
            {
                connection = new SqlConnection(constring);
                connection.Open();

                string query = "SELECT * FROM [Sorteos]";
                SqlCommand consulta = new SqlCommand(query, connection);
                busqueda = consulta.ExecuteReader();

                //listStories.Add(new ENStories(1, new ENUsuario(), new DateTime(), "titulo", 2, "desc", "https://img.freepik.com/vector-gratis/resumen-fondo-plateado-claro_67845-796.jpg"));
               
                while (busqueda.Read())
                {
                    //int id = int.Parse(busqueda["id"].ToString());
                    ENSorteos sorteo;
                    sorteo = new ENSorteos
                    {
                        Id = Int32.Parse(busqueda["id"].ToString()),
                        Imagen = busqueda["imagen"].ToString(),
                        Nombre = busqueda["titulo"].ToString(),
                        Descripcion = busqueda["descripcion"].ToString(),
                        FechaFinal = DateTime.Parse(busqueda["fechafINAL"].ToString()),
                        FechaInicio = DateTime.Parse(busqueda["fechaInicio"].ToString()),
                        Titular = busqueda["titular"].ToString()
                    };

                    lista.Add(sorteo);
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
        public bool readsorteo(List<ENSorteos> lista)
        {
            
                /**/
                bool leido = false;
                SqlConnection connection = null;
            DataSet sorteos;

            ENSorteos sorteo;
            try
            {
                connection = new SqlConnection(constring);
                sorteos = new DataSet();
                string query = "Select * From [Sorteos];";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(sorteos, "Sorteos");
                DataTable tablesorteos = sorteos.Tables["Sorteos"];
                DataRow[] rowsSorteos = tablesorteos.Select();
                for (int i = 0; i < rowsSorteos.Length; i++)
                {
                    sorteo = new ENSorteos
                    {
                        Id = Int32.Parse(rowsSorteos[i]["id"].ToString()),
                        Imagen = rowsSorteos[i]["imagen"].ToString(),
                        Nombre = rowsSorteos[i]["nombre"].ToString(),
                        Descripcion = rowsSorteos[i]["descripcion"].ToString(),
                        FechaFinal = (DateTime)rowsSorteos[i]["fechafinal"],
                        FechaInicio = (DateTime)rowsSorteos[i]["fechainicio"],
                        Titular = rowsSorteos[i]["titular"].ToString()
                    };
                    lista.Add(sorteo);
                }
                leido = true;
            }catch (SqlException ex)
            {
                leido = false;
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                leido = false;
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
            }
            finally { connection.Close(); }

            return leido;

           
        }
       
    }
}
