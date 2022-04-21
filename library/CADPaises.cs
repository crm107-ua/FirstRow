using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADPaises
    {
        private String constring;

        public CADPaises()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }


        public List<ENPais> readPaises(List<ENPais> paises)
        {

            SqlConnection conection = null;
            SqlDataReader busqueda = null;

            try
            {
                conection = new SqlConnection(constring);
                conection.Open();

                string query = "Select * From [FirstRow].[Paises]";
                SqlCommand consulta = new SqlCommand(query, conection);
                busqueda = consulta.ExecuteReader();

                while (busqueda.Read())
                {
                    paises.Add(new ENPais(int.Parse(busqueda["id"].ToString()), busqueda["name"].ToString()));
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
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

            return paises;
        }
    }
}
