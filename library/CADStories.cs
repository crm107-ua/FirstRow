using System;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADStories
    {
        private String constring;

        public CADStories()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }
   
    }
}
