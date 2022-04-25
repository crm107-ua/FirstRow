using System;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADDia
    {
        private String constring;

        public CADDia()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        public bool createDia(ENDia wearing)
        {
            bool created = false;
            return created;
        }

        public bool modifyDia(ENDia wearing)
        {
            bool correctRead = false;
            return correctRead;
        }

        public bool deleteDia(ENDia wearing)
        {
            bool deleted = false;
            return deleted;
        }

    }
}
