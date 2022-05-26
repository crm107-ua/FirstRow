﻿using System;
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


        internal bool newPropuesta(ENPropuestas propuesta)
        {
            bool creado = false;
            if (propuesta is ENPropuestas)
            {
                bool created = false;
                SqlConnection connection = new SqlConnection(constring);
                try
                {
                    connection.Open();
                    string query = "INSERT INTO [Propuestas] " +
                        "(titulo, texto, imagen, slug) VALUES " +
                        $"({propuesta.Titulo},{propuesta.Descripcion},{propuesta.Imagen})";

                    SqlCommand com = new SqlCommand(query, connection);
                    com.ExecuteNonQuery();
                    created = true;
                }
                catch (SqlException e)
                {
                    created = false;
                    Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                }
                catch (Exception e)
                {
                    created = false;
                    Console.WriteLine("User operation has failed.Error: {0}", e.Message);
                }
                finally
                {
                    if (connection != null)
                    {
                        connection.Close();
                    }
                }

                return created;

            }

            return creado;
        }

        internal bool deletePropuesta(ENPropuestas propuestas)
        {

            bool deleted = false;
            return deleted;


        }

    }
}
