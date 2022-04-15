using System;
using System.Configuration;
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
        private int _Id;
        private string _Imagen;

        public int Id //GET-SET
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Imagen //GET-SET
        {
            get { return _Imagen; }
            set { _Imagen = value; }
        }

        public static string _Nombre; //CRUD

        public static string _Descripcion; //CRUD

        public static string _Categoria; //CRUD

        public static string _Empresa; //CRUD

    }
}
