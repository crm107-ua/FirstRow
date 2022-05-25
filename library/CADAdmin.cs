using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace library
{
    class CADAdmin
    {
        private String constring;

        public CADAdmin()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        public bool modify(ENAdmin en) 
        {
            bool conseguido = false;

            SqlConnection connection = new SqlConnection(constring);

            try
            {
                connection.Open();
                string querty = "update [Admin] set text=@text where slug='titulo-exp'";
                SqlCommand command = new SqlCommand(querty, connection);
                command.Parameters.AddWithValue("@text", en.TituloExperiencia);
                command.ExecuteNonQuery();

                querty = "update [Admin] set text=@text where slug='des-exp'";
                command = new SqlCommand(querty, connection);
                command.Parameters.AddWithValue("@text", en.DescpExpperiencia);
                command.ExecuteNonQuery();

                querty = "update [Admin] set text=@text where slug='titulo-gal'";
                command = new SqlCommand(querty, connection);
                command.Parameters.AddWithValue("@text", en.TituloGaleria);
                command.ExecuteNonQuery();

                querty = "update [Admin] set text=@text where slug='des-gal'";
                command = new SqlCommand(querty, connection);
                command.Parameters.AddWithValue("@text", en.DescpGaleria);
                command.ExecuteNonQuery();

                querty = "update [Admin] set text=@text where slug='titulo-stories'";
                command = new SqlCommand(querty, connection);
                command.Parameters.AddWithValue("@text", en.TituloStories);
                command.ExecuteNonQuery();

                querty = "update [Admin] set text=@text where slug='des-stories'";
                command = new SqlCommand(querty, connection);
                command.Parameters.AddWithValue("@text", en.DescpStories);
                command.ExecuteNonQuery();

                querty = "update [Admin] set text=@text where slug='titulo-blogs'";
                command = new SqlCommand(querty, connection);
                command.Parameters.AddWithValue("@text", en.TituloBlog);
                command.ExecuteNonQuery();

                querty = "update [Admin] set text=@text where slug='des-exp'";
                command = new SqlCommand(querty, connection);
                command.Parameters.AddWithValue("@text", en.DescpExpperiencia);
                command.ExecuteNonQuery();

                querty = "update [Admin] set text=@text where slug='titulo-sorteos'";
                command = new SqlCommand(querty, connection);
                command.Parameters.AddWithValue("@text", en.TituloSorteos);
                command.ExecuteNonQuery();

                querty = "update [Admin] set text=@text where slug='des-sorteos'";
                command = new SqlCommand(querty, connection);
                command.Parameters.AddWithValue("@text", en.DescpSorteos);
                command.ExecuteNonQuery();

                querty = "update [Admin] set text=@text where slug='contacto-texto-1'";
                command = new SqlCommand(querty, connection);
                command.Parameters.AddWithValue("@text", en.ContactoTexto1);
                command.ExecuteNonQuery();

                querty = "update [Admin] set text=@text where slug='contacto-texto-2'";
                command = new SqlCommand(querty, connection);
                command.Parameters.AddWithValue("@text", en.ContactoTexto2);
                command.ExecuteNonQuery();

                conseguido = true;
            }
            catch (Exception e)
            {
            }
            finally 
            {
                connection.Close();
            }

            return conseguido;
        }

        public bool readAll(ENGaleria en) 
        {
            bool conseguido = false;
            
           

            return conseguido;
        }

    }
}
