using System;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADCategorias
    {
        private String constring;

        internal int idViaje;
        internal int nombreUsuario;
        internal int TourViaje;

        public CADCategorias()
        {
                constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        // Set/get - Identificativo con un entero
        public int id
        {
            get { return idViaje; }
            private set { idViaje = value; }
        }

        // Set/get - Identificativo con un entero
        public int Ciudad_pais
        {
            get { return Ciudad_pais; }
            private set { idViaje = value; }
        }

        // Set/get - Identificativo con un entero
        public int Tour_Viaje
        {
            get { return Tour_Viaje; }
            private set { idViaje = value; }
        }

        // Crear Categoria
        public bool registerCategoria(ENCategoria en)
        {
            bool creado = false;
            if(en is ENCategoria)
            {
              
            }
            
            return creado;
        }

        // Leer Categoria
        public bool readCategoria(ENCategoria en)
        {
            bool read = false;
            if (en is ENCategoria)
            {
                
            }
            
            return read;
        }

        // Actualizar Categoria
        public bool updateCategoria(ENCategoria en)
        {
            bool update = false;
            if (en is ENCategoria)
            {
               
            }
           
            return update;
        }

        // Eliminar Categoria
        public bool deleteCategoria(ENCategoria en)
        {
            bool delete = false;
            return delete;
        }

        public static string imagenes; //Add-Delete

    }

}

