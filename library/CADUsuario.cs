using System;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADUsuario
    {
        private String constring;

        public CADUsuario()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }
   
    }
}
