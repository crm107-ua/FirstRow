using System;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADWearing
    {
        private String constring;

        public CADWearing()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }
   
    }
}
