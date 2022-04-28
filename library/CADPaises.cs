﻿using System;
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


        public bool readPaises(List<ENPais> paises)
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

        /**
         * Lee un único país de la DB
         * si el país pasado omo argumento tiene un id válido (> 0),
         * se busca el país con el id, si no, se busca con el nombre del país
         * 
         * Devuelve 'true' si se ha encontrado el país en la DB y
         * 'false' si no se ha encontrado o ha saltado algún error
         * 
         */
        public bool ReadPais(ENPais pais)
        {
            bool correctRead = false;
            SqlConnection connection = new SqlConnection(constring);

            try
            {
                connection.Open();
                string query = "";
                if (pais.id > 0)
                {
                    query = $"SELECT * FROM [FirstRow].[Paises] WHERE id = '{pais.id}'";
                }
                else
                {
                    query = $"SELECT * FROM [FirstRow].[Paises] WHERE name = '{pais.name}'";
                }
                SqlCommand com = new SqlCommand(query, connection);
                SqlDataReader dr = com.ExecuteReader();
                try
                {
                    dr.Read();

                    if (pais.id > 0 && pais.id == int.Parse(dr["id"].ToString()))
                    {
                        pais.name = dr["name"].ToString();
                        correctRead = true;

                    }
                    else if (pais.id >= 0 && pais.name == dr["name"].ToString())
                    {
                        pais.id = int.Parse(dr["id"].ToString());
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
    }
}
