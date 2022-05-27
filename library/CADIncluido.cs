using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class CADIncluido
    {
        private String constring;

        public CADIncluido()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        public DataSet readIncluidos()
        {
            SqlConnection c = null;

            try
            {
                c = new SqlConnection(constring);
                DataSet bd = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select * from [Incluidos]", c);
                da.Fill(bd, "Incluidos");
                return bd;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (c != null)
                {
                    c.Close();
                }
            }
        }
    }
}
