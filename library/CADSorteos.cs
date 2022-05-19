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
        /*
         insert into sorteos values ('sorteo de experiencia por el atlantico','lo que su nombre indica','sorteo de experiencia por el atlantico','fuente.jpg',40,'2021-05-08','2021-05-10','Jet Enterprise')
         */
        internal bool addParticipante(ENSorteos en)
        {
            //TODO: addParticipante
            bool anadido = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {

                c.Open();

                string s = "Insert INTO [dbo].[Sorteo_Usuarios] (titulo,descripcion,slug,imagen,FechaInicio,FechaFinal) VALUES ('" + en.Titulo + "','" + en.Descripcion + "','" + en.Slug + "','" + en.Imagen + "','" + en.FechaInicio + "','" + en.FechaFinal + "')";

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

                string query = "SELECT * FROM [firstrow_].[dbo].[Sorteos]";
                SqlCommand consulta = new SqlCommand(query, connection);
                busqueda = consulta.ExecuteReader();

                while (busqueda.Read())
                {
                    //int id = int.Parse(busqueda["id"].ToString());
                    ENSorteos sorteo;
         
                    sorteo = new ENSorteos
                    {
                        Id = Int32.Parse(busqueda["id"].ToString()),
                        Imagen = busqueda["imagen"].ToString(),
                        Titulo = busqueda["titulo"].ToString(),
                        Descripcion = busqueda["descripcion"].ToString(),
                        FechaFinal = DateTime.Parse(busqueda["fechafINAL"].ToString()),
                        FechaInicio = DateTime.Parse(busqueda["fechaInicio"].ToString()),
                        Titular = busqueda["titular"].ToString(),
                        Slug = busqueda["slug"].ToString()
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
        public bool readsorteo( string s)
        {

            bool correctRead;
            SqlConnection connection = null;
            SqlDataReader busqueda = null;

            try
            {
                connection = new SqlConnection(constring);
                connection.Open();

                string query = "SELECT * FROM [firstrow_].[dbo].[Sorteos] where slug=" +"'"+ s.ToString()+"'";
                SqlCommand consulta = new SqlCommand(query, connection);
                busqueda = consulta.ExecuteReader();

                busqueda.Read();
                
                    //int id = int.Parse(busqueda["id"].ToString());
                    
             
                    sorteo = new ENSorteos
                    {
                        Id = Int32.Parse(busqueda["id"].ToString()),
                        Imagen = busqueda["imagen"].ToString(),
                        Titulo = busqueda["titulo"].ToString(),
                        Descripcion = busqueda["descripcion"].ToString(),
                        FechaFinal = DateTime.Parse(busqueda["fechafINAL"].ToString()),
                        FechaInicio = DateTime.Parse(busqueda["fechaInicio"].ToString()),
                        Titular = busqueda["titular"].ToString(),
                        Slug = busqueda["slug"].ToString()
                    };

                  
                

                correctRead = true;
            }
            catch (SqlException ex)
            {
                correctRead = false;
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                correctRead = false;
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
            }
            finally { connection.Close(); }

            return correctRead;

           
        }
       
    }
}
