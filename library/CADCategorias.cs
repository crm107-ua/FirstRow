using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace library
{
    public class CADCategorias
    {
        private String constring;

        public CADCategorias()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        public DataSet readCategorias()
        {
            SqlConnection c = null;

            try
            {
                c = new SqlConnection(constring);
                DataSet bd = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select * from [Categorias]", c);
                da.Fill(bd, "Categorias");
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

        // Crear Categoria
        public bool registerCategoria(ENCategorias categoria)
        {
            bool creado = false;
            if (categoria is ENCategorias)
            {

                bool created = false;
                SqlConnection connection = new SqlConnection(constring);
                try
                {
                    connection.Open();
                    string query = "INSERT INTO [Categorias] " +
                        "(id, titulo, descripcion, fecha, pais, usuario, imagen) VALUES " +
                        $"({categoria.id}, {categoria.nombre}, {categoria.descripcion}, {categoria.slug})";

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


        public bool readCategoria(ENCategorias categoria, bool mode)
        {

            SqlConnection conection = null;
            SqlDataReader busqueda = null;

            try
            {
                conection = new SqlConnection(constring);
                SqlCommand consulta = new SqlCommand();
                conection.Open();
                string query = "";

                if (mode)
                {
                    query = "Select * From [Categorias] where id = @id";
                    consulta = new SqlCommand(query, conection);
                    consulta.Parameters.AddWithValue("@id", categoria.id);
                }
                else
                {
                    query = "Select * From [Categorias] where slug = @slug";
                    consulta = new SqlCommand(query, conection);
                    consulta.Parameters.AddWithValue("@slug", categoria.slug);
                }
                busqueda = consulta.ExecuteReader();
                busqueda.Read();

                // Lectura de campos de categoria

                categoria.id = Int32.Parse(busqueda["id"].ToString());
                categoria.nombre = busqueda["nombre"].ToString();
                categoria.descripcion = busqueda["descripcion"].ToString();
                categoria.slug = busqueda["slug"].ToString();

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

        // Actualizar Categoria
        public bool updateCategoria(ENCategorias categoria)
        {
            bool update = false;
            if (categoria is ENCategorias)
            {

                bool updated = false;
                return updated;

            }

            return update;
        }

        // Eliminar Categoria
        public bool deleteCategoria(ENCategorias categoria)
        {
            bool deleted = false;
            return deleted;
        }

    }

}
