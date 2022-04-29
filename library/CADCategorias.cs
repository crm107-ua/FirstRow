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
                SqlDataAdapter da = new SqlDataAdapter("select * from [FirstRow].[Categorias]", c);
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
        public bool registerCategoria(ENCategorias en)
        {
            bool creado = false;
            if(en is ENCategorias)
            {
              
            }
            
            return creado;
        }

        // Leer Categoria
        public bool readCategoria(ENCategorias en)
        {
            bool read = false;
            if (en is ENCategorias)
            {
                
            }
            
            return read;
        }

        // Actualizar Categoria
        public bool updateCategoria(ENCategorias en)
        {
            bool update = false;
            if (en is ENCategorias)
            {
               
            }
           
            return update;
        }

        // Eliminar Categoria
        public bool deleteCategoria(ENCategorias en)
        {
            bool delete = false;
            return delete;
        }

    }

}

