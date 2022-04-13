using System;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADViajes
    {
        private String constring;

        public CADViajes()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }
   
    }
}
