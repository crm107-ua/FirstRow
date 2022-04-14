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

        public int id
        {
            get { return idViaje; }
            private set { idViaje = value; }
        }

        public int Ciudad_pais
        {
            get { return Ciudad_pais; }
            private set { idViaje = value; }
        }

        public int Tour_Viaje
        {
            get { return Tour_Viaje; }
            private set { idViaje = value; }
        }

        public static string Titulo; //CRUD

        public static string desempeño; //CRUD

        public static string imagenes; //Add-Delete

    }

}

