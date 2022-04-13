using System;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADGaleria
    {
        private String constring;

        public CADGaleria()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }
   
    }
}
