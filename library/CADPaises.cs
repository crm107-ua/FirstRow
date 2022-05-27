using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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


        public bool readPaises(List<ENPais> paises)
        {

            SqlConnection conection = null;
            SqlDataReader busqueda = null;

            try
            {
                conection = new SqlConnection(constring);
                conection.Open();

                string query = "Select * From [Paises]";
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

        public bool ReadPaisesDataSet(DataSet ds)
        {
            bool correctRead;
            SqlConnection connection = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Paises]" +
                "ORDER BY name", connection);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "Paises");
                correctRead = true;

            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                correctRead = false;
            }

            return correctRead;

        }

        /// <summary>
        /// Lee un único país de la DB.
        /// Si el país pasado omo argumento tiene un id válido(> 0),
        /// se busca el país con el id, si no, se busca con el nombre del país
        /// </summary>
        /// <param name="pais"></param>
        /// <returns>true: si se ha encontrado el país en la DB,
        /// false: si no se ha encontrado o ha saltado algún error</returns>
        public bool ReadPais(ENPais pais)
        {
            bool correctRead = false;
            SqlConnection connection = new SqlConnection(constring);

            try
            {
                connection.Open();
                string query = "";
                SqlCommand com;
                if (pais.id > 0)
                {
                    query = "SELECT * FROM [Paises] WHERE id = @id";
                    com = new SqlCommand(query, connection);
                    com.Parameters.AddWithValue("@id", pais.id);
                }
                else
                {
                    /*
                    query = "SELECT * FROM [Paises] " +
                        "WHERE name = @name";
                    com = new SqlCommand(query, connection);
                    com.Parameters.AddWithValue("@name", pais.name);
                    */
                    query = "SELECT * FROM [Paises];";
                    com = new SqlCommand(query, connection);

                }
                SqlDataReader dr = com.ExecuteReader();
                try
                {
                    if (pais.id > 0)
                    {
                        dr.Read();

                    }
                    else
                    {
                        while (dr.Read())
                        {
                            if (dr["name"].ToString().ToLower() == pais.name.ToLower())
                            {
                                break;
                            }
                            
                        }
                    }

                    if (pais.id > 0 && pais.id == int.Parse(dr["id"].ToString()))
                    {
                        pais.name = dr["name"].ToString();
                        correctRead = true;

                    }
                    else if (pais.id <= 0 && pais.name.ToLower() == dr["name"].ToString().ToLower())
                    {
                        pais.id = int.Parse(dr["id"].ToString());
                        pais.name = dr["name"].ToString();
                        correctRead = true;
                    }
                    else correctRead = false;

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

        public bool getListPaisesDesconectado(List<ENPais> paises)
        {
            bool correctRead = false;

            DataSet ds = new DataSet();
            try
            {
                if (ReadPaisesDataSet(ds))
                {
                    DataTable dtPaises = ds.Tables["Paises"];
                    /*
                    //Preparamos columna con clave primaria
                    DataColumn dc = new DataColumn("id");
                    dc.AutoIncrement = true;
                    dc.AutoIncrementSeed = 1;
                    dc.AutoIncrementStep = 1;
                    dc.DataType = typeof(Int32);

                    //Añadimos la columna a al datable
                    dtPaises.Columns.Add(dc);

                    //Establecemos la clave primaria
                    DataColumn[] pk = new DataColumn[] { dc };
                    dtPaises.PrimaryKey = pk;
                    */

                    using (DataTableReader dtRdr = dtPaises.CreateDataReader())
                    {
                        while (dtRdr.Read())
                        {
                            ENPais p = new ENPais();
                            p.id = Convert.ToInt32(dtRdr[0]);
                            p.name = Convert.ToString(dtRdr[1]);
                            paises.Add(p);
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
    }
}
