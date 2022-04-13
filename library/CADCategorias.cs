using System;
using System.Configuration;
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
   
    }
}
