using System;
using System.Configuration;
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
            bool anadido=false;
            SqlConnection c = new SqlConnection(constring);
            try {

                c.Open();

                string s = "Insert INTO [dbo].[Sorteo_Usuarios] (titulo,description,slug,imagen,FechaInicio,FechaFinal) VALUES ('" + en.Nombre + "','" + en.Descripcion + "','" + en.Slug + "','" + en.Imagen + "','" + en.FechaInicio + "','" + en.FechaFinal + "')";

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
    }
}
