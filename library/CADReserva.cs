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
    class CADReserva
    {
        private String constring;
        public CADReserva()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        public DataSet readReserva(ENReserva eNReserva, bool v)
        {

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(constring);
                DataSet bd = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select * from [firstrow_].[dbo].[Reserva]", c);
                da.Fill(bd, "Reserva");
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
