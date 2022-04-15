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

        public bool CreateWearing(ENWearing wearing)
        {
            bool created = false;
            return created;
        }

        public bool ReadWearing(ENWearing wearing)
        {
            bool correctRead = false;
            return correctRead;
        }

        public bool UpdateWearing(ENWearing wearing)
        {
            bool updated = false;
            return updated;
        }

        public bool DeleteWearing(ENWearing wearing)
        {
            bool deleted = false;
            return deleted;
        }


    }
}
