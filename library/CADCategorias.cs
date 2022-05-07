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
                SqlDataAdapter da = new SqlDataAdapter("select * from [firstrow_].[dbo].[Categorias]", c);
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
                    string query = "INSERT INTO [firstrow_].[dbo].[Categorias] " +
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

        // Leer Categoria
        public bool readCategoria(ENCategorias categoria)
        {
            bool read = false;
            if (categoria is ENCategorias)
            {

                bool correctRead = false;
                return correctRead;

            }

            return read;
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
