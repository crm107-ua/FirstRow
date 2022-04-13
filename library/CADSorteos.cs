using System;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADSorteos
    {
        private String constring;

        public CADSorteos()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }
   
    }
}
