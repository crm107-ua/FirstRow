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

        public bool readAll(ENAdmin en)
        {
            bool conseguido = false;
            SqlConnection connection = new SqlConnection(constring);

            try
            {
                connection.Open();
                string querty = "select * from [Admin]";
                SqlCommand command = new SqlCommand(querty, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["slug"].ToString().Split('-')[0] == "titulo")
                    {
                        escrituraDatos(en, reader, true);
                    }
                    else if (reader["slug"].ToString().Split('-')[0] == "des")
                    {
                        escrituraDatos(en, reader, false);
                    }
                    else
                    {
                        if (reader["slug"].ToString().Split('-')[2] == "1")
                        {
                            en.ContactoTexto1 = reader["text"].ToString();
                        }
                        else
                        {
                            en.ContactoTexto2 = reader["text"].ToString();
                        }
                    }
                }
                conseguido = true;

            }
            catch (Exception e)
            {
            }
            finally
            {
                conseguido.ToString();
            }


            return conseguido;
        }

        public string read(string slug)
        {

            string text = "";

            SqlConnection connection = new SqlConnection(constring);

            try
            {
                connection.Open();
                string querty = "select * from [Admin] where slug=@slug";
                SqlCommand command = new SqlCommand(querty, connection);
                command.Parameters.AddWithValue("@slug", slug);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                text = reader["text"].ToString();

            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();
            }

            return text;
        }

        private static void escrituraDatos(ENAdmin en, SqlDataReader reader, bool title_desc)
        {
            if (title_desc)
            {
                switch (reader["slug"].ToString().Split('-')[1])
                {
                    case "exp":
                        en.TituloExperiencia = reader["text"].ToString();
                        break;

                    case "gal":
                        en.TituloGaleria = reader["text"].ToString();
                        break;

                    case "stories":
                        en.TituloStories = reader["text"].ToString();
                        break;
                    case "blogs":
                        en.TituloBlog = reader["text"].ToString();
                        break;
                    case "sorteos":
                        en.TituloSorteos = reader["text"].ToString();
                        break;

                }
            }
            else
            {
                switch (reader["slug"].ToString().Split('-')[1])
                {
                    case "exp":
                        en.DescpExpperiencia = reader["text"].ToString();
                        break;

                    case "gal":
                        en.DescpGaleria = reader["text"].ToString();
                        break;

                    case "stories":
                        en.DescpStories = reader["text"].ToString();
                        break;
                    case "blogs":
                        en.DecpBlog = reader["text"].ToString();
                        break;
                    case "sorteos":
                        en.DescpSorteos = reader["text"].ToString();
                        break;
                }
            }
        }
    }
}
