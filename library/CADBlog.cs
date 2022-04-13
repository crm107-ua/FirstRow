using System;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADBlog
    {
        private String constring;

        public CADBlog()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }
   
    }
}
