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
        internal bool addSorteo(ENSorteos en)
        {
            //TODO: addParticipante
            bool anadido = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {

                c.Open();

                string s = "Insert INTO [dbo].[Sorteo_Usuarios] (titulo,descripcion,slug,imagen,FechaInicio,FechaFinal) VALUES ( @titulo , @descripcion , @slug , @imagen, @fechainicio, @fechafinal)";

                SqlCommand com = new SqlCommand(s, c);
                com.Parameters.AddWithValue("@titulo", en.Titulo);
                com.Parameters.AddWithValue("@descripcion", en.Descripcion);
                com.Parameters.AddWithValue("@slug", en.Slug);
                com.Parameters.AddWithValue("@imagen",en.Imagen);
                com.Parameters.AddWithValue("@fechainicio", en.FechaInicio.ToString("yyyy-MM-dd HH:mm:ss.ffffff"));
                com.Parameters.AddWithValue("@fechafinal", en.FechaFinal.ToString("yyyy-MM-dd HH:mm:ss.ffffff"));

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

        internal bool addParticipante(ENSorteos eNSorteos) 
        {
            bool conseguido = false;
            SqlConnection conection = new SqlConnection(constring);
            foreach (ENUsuario usuario in eNSorteos.Participantes) {
                try
                {
                    conection.Open();
                    string querty = "insert into [Sorteo_Usuarios] (id_Sorteo, nickname_Usuario) values (@sorteo,@usuario)";
                    SqlCommand com = new SqlCommand(querty, conection);
                    com.Parameters.AddWithValue("@sorteo", eNSorteos.Id);
                    com.Parameters.AddWithValue("@usuario",usuario.nickname);
    
                }
                catch (Exception e)
                {
                }
                finally
                {
                    conection.Close();
                }
            }

            return conseguido;
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

<<<<<<< HEAD
                string query = "SELECT * FROM [firstrow_].[dbo].[Sorteos]";
                SqlCommand consulta = new SqlCommand(query, connection);
                busqueda = consulta.ExecuteReader();

                //listStories.Add(new ENStories(1, new ENUsuario(), new DateTime(), "titulo", 2, "desc", "https://img.freepik.com/vector-gratis/resumen-fondo-plateado-claro_67845-796.jpg"));
               
=======
                string query = "SELECT * FROM [Sorteos]";
                SqlCommand consulta = new SqlCommand(query, connection);
                busqueda = consulta.ExecuteReader();

>>>>>>> develop
                while (busqueda.Read())
                {
                    //int id = int.Parse(busqueda["id"].ToString());
                    ENSorteos sorteo;
<<<<<<< HEAD
=======
         
>>>>>>> develop
                    sorteo = new ENSorteos
                    {
                        Id = Int32.Parse(busqueda["id"].ToString()),
                        Imagen = busqueda["imagen"].ToString(),
<<<<<<< HEAD
                        Nombre = busqueda["titulo"].ToString(),
                        Descripcion = busqueda["descripcion"].ToString(),
                        FechaFinal = DateTime.Parse(busqueda["fechafINAL"].ToString()),
                        FechaInicio = DateTime.Parse(busqueda["fechaInicio"].ToString()),
                        Titular = busqueda["titular"].ToString()
=======
                        Titulo = busqueda["titulo"].ToString(),
                        Descripcion = busqueda["descripcion"].ToString(),
                        FechaFinal = DateTime.Parse(busqueda["fechafINAL"].ToString()),
                        FechaInicio = DateTime.Parse(busqueda["fechaInicio"].ToString()),
                        Titular = busqueda["titular"].ToString(),
                        Slug = busqueda["slug"].ToString()
>>>>>>> develop
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
        
<<<<<<< HEAD


    }
        public bool readsorteo(List<ENSorteos> lista)
=======


        }

        public bool readsorteo( ENSorteos sorteo)
>>>>>>> develop
        {
            
                /**/
                bool leido = false;
                SqlConnection connection = null;
            DataSet sorteos;

<<<<<<< HEAD
            ENSorteos sorteo;
            try
            {
                connection = new SqlConnection(constring);
                sorteos = new DataSet();
                string query = "Select * From [firstrow_].[dbo].[Sorteos];";

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
=======
            bool correctRead;
            SqlConnection connection = null;
            SqlDataReader busqueda = null;

            try
            {
                connection = new SqlConnection(constring);
                connection.Open();

                string query = "SELECT * FROM [Sorteos] where slug=" +"'"+ sorteo.Slug.ToString()+"'";
                SqlCommand consulta = new SqlCommand(query, connection);
                busqueda = consulta.ExecuteReader();

                busqueda.Read();
                
                    //int id = int.Parse(busqueda["id"].ToString());
                    
             /*
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
                */
                sorteo.Id = Int32.Parse(busqueda["id"].ToString());
                sorteo.Imagen = busqueda["imagen"].ToString();
                sorteo.Titulo = busqueda["titulo"].ToString();
                sorteo.Descripcion = busqueda["descripcion"].ToString();
                sorteo.FechaInicio = DateTime.Parse( busqueda["fechaInicio"].ToString());
                sorteo.FechaFinal = DateTime.Parse(busqueda["fechafINAL"].ToString());
                sorteo.Titular = busqueda["titular"].ToString();
                sorteo.Slug = busqueda["slug"].ToString();




                correctRead = true;
            }
            catch (SqlException ex)
>>>>>>> develop
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
<<<<<<< HEAD
       
=======

        internal int readcantidad(ENSorteos sorteo)
        {
          
            int cantidad = 0;
            SqlConnection connection = null;
            SqlDataReader busqueda = null;

            try
            {
                connection = new SqlConnection(constring);
                connection.Open();

                string query = "SELECT count(*)cant FROM [Sorteo_Usuarios] where id=" + "'" + sorteo.Id + "'";
                SqlCommand consulta = new SqlCommand(query, connection);
                busqueda = consulta.ExecuteReader();

                busqueda.Read();
                cantidad = int.Parse( busqueda["cant"].ToString());
                
                
            }
            catch (SqlException ex)
            {
                
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
               
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
            }
            finally { connection.Close(); }

            return cantidad;


        }
>>>>>>> develop
    }
}
