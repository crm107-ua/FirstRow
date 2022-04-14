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

        public bool CreateStory(ENStories story)
        {
            bool created = false;
            return created;
        }

        public bool ReadStory(ENStories story)
        {
            bool correctRead = false;
            return correctRead;
        }

        public bool UpdateStory(ENStories story)
        {
            bool updated = false;
            return updated;
        }

        public bool DeleteStory(ENStories story)
        {
            bool deleted = false;
            return deleted;
        }
   
    }
}
