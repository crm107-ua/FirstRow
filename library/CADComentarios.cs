using System;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADComentarios
    {
        private String constring;

        public CADComentarios()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }
   
    }
}
