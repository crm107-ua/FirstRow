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

        public bool createStory(ENStories story)
        {
            bool created = false;
            return created;
        }

        public bool readStory(ENStories story)
        {
            bool correctRead = false;
            return correctRead;
        }

        public bool updateStory(ENStories story)
        {
            bool updated = false;
            return updated;
        }

        public bool deleteStory(ENStories story)
        {
            bool deleted = false;
            return deleted;
        }
   
    }
}
