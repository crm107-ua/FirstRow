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
        public bool getlistadesconectado(List<ENSorteos> sorteos)
        {
            bool correctRead = false;

            DataSet ds = new DataSet();
            try
            {
                if (ReadSorteosDataSet(ds))
                {
                    DataTable dtsorteos = ds.Tables["Sorteos"];
          
                    using (DataTableReader dtRdr = dtsorteos.CreateDataReader())
                    {
                        while (dtRdr.Read())
                        {
                            ENSorteos p = new ENSorteos();
                            p.Id = Convert.ToInt32(dtRdr[0]);
                            p.Nombre = Convert.ToString(dtRdr[1]);
                            sorteos.Add(p);
                        }
                    }

                    correctRead = true;
                }

            }
            catch (Exception ex)
            {
                correctRead = false;
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
            }

            return correctRead;

        }
        public bool ReadSorteosDataSet(DataSet ds)
        {
            bool correctRead;
            SqlConnection connection = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("SELECT * FROM [firstrow_].[dbo].[sorteos]", connection);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "Sorteos");
                correctRead = true;

            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                correctRead = false;
            }

            return correctRead;

        }
        public bool readsorteo(ENSorteos sorteo)
        {

            //TODO: readsorteo
            bool correctRead = false;
            SqlConnection connection = new SqlConnection(constring);

            try
            {
                
                connection.Open();
                string query = "SELECT * FROM [firstrow_].[dbo].[Sorteos] WHERE"+"id = @id";
                SqlCommand com = new SqlCommand(query,connection);
                com.Parameters.AddWithValue("@id", sorteo.Id);
         
                SqlDataReader dr = com.ExecuteReader();
                try
                {
                    
                    dr.Read();

                    if (sorteo.Id > 0 && sorteo.Id == int.Parse(dr["id"].ToString()))
                    {
                        sorteo.Nombre= dr["nombre"].ToString();
                        sorteo.Descripcion= dr["descripcion"].ToString();
                        sorteo.FechaFinal= (DateTime)dr["fechaFinal"];
                        sorteo.Imagen= dr["imagen"].ToString();
                        sorteo.FechaInicio =(DateTime) dr["fechaInicio"];
                        

                        correctRead = true;

                    }
                    else  correctRead = false;

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                    return false;
                }
                finally { dr.Close(); }
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
