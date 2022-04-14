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

        public bool createBlog(ENBlog en)
        {
            bool creado = false;
            return creado;
        }

        public bool readBlog(ENBlog en)
        {
            bool read = false;
            return read;
        }

        public bool readBlogs(ENBlog en)
        {
            bool read = false;
            return read;
        }

        public bool updateBlog(ENBlog en)
        {
            bool update = false;
            return update;
        }

        public bool deleteBlog(ENBlog en)
        {
            bool delete = false;
            return delete;
        }
    }
}
