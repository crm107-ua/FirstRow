using System;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADUsuario
    {
        private String constring;

        public CADUsuario()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        public bool registerUsuario(ENUsuario en)
        {
            bool creado = false;
            SqlConnection conection = null;

            try
            {
                conection = new SqlConnection(constring);
                conection.Open();

                string query = "Insert INTO [firstrow_].[dbo].[Usuarios] " +
                    "(nickname,email, password, image, background_image," +
                    "name, firstname, secondname, facebook, twitter) " +
                    "VALUES " +
                    "(@nickname,@email,@password,@image,@background_image," +
                    "@name,@firstname,@secondname,@facebook,@twitter)";
                SqlCommand consulta = new SqlCommand(query, conection);
                consulta.Parameters.AddWithValue("@nickname", en.nickname);
                consulta.Parameters.AddWithValue("@email", en.email);
                consulta.Parameters.AddWithValue("@password", en.password);
                consulta.Parameters.AddWithValue("@image", en.image);
                consulta.Parameters.AddWithValue("@background_image", en.background_image);
                consulta.Parameters.AddWithValue("@name", en.name);
                consulta.Parameters.AddWithValue("@firstname", en.firstname);
                consulta.Parameters.AddWithValue("@secondname", en.secondname);
                consulta.Parameters.AddWithValue("@facebook", en.facebook);
                consulta.Parameters.AddWithValue("@twitter", en.twitter);
                consulta.ExecuteNonQuery();
                creado = true;

            }
            catch (SqlException e)
            {
                creado = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                creado = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return creado;
        }

        public bool loginUsuario(ENUsuario en)
        {
            bool login = false;
            SqlConnection conection = null;
            SqlDataReader busqueda = null;

            try
            {
                conection = new SqlConnection(constring);
                conection.Open();

                string query = "Select count(*) From [firstrow_].[dbo].[Empresas] where nickname = @nickname ";
                SqlCommand consulta = new SqlCommand(query, conection);
                consulta.Parameters.AddWithValue("@nickname", en.nickname);

                if ((int)consulta.ExecuteScalar() == 0)
                {

                    query = "Select * From [firstrow_].[dbo].[Usuarios] Where nickname = @nickname and password = @password";
                    consulta = new SqlCommand(query, conection);
                    consulta.Parameters.AddWithValue("@nickname", en.nickname);
                    consulta.Parameters.AddWithValue("@password", en.password);
                    busqueda = consulta.ExecuteReader();
                    busqueda.Read();

                    en.nickname = busqueda["nickname"].ToString();
                    en.password = busqueda["password"].ToString();
                    en.email = busqueda["email"].ToString();
                    en.image = busqueda["image"].ToString();
                    en.background_image = busqueda["background_image"].ToString();
                    en.name = busqueda["name"].ToString();
                    en.firstname = busqueda["firstname"].ToString();
                    en.secondname = busqueda["secondname"].ToString();
                    en.twitter = busqueda["twitter"].ToString();
                    en.facebook = busqueda["facebook"].ToString();

                    login = true;
                }

            }
            catch (SqlException e)
            {
                login = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                login = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            finally
            {
                if (busqueda != null)
                {
                    busqueda.Close();
                }
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return login;
        }

        public bool readUsuario(ENUsuario en)
        {
            bool encontrado = false;
            SqlConnection conection = null;
            SqlDataReader busqueda = null;

            try
            {
                conection = new SqlConnection(constring);
                conection.Open();

                string query = "Select * From [firstrow_].[dbo].[Usuarios] Where nickname = @nickname";
                SqlCommand consulta = new SqlCommand(query, conection);
                consulta.Parameters.AddWithValue("@nickname", en.nickname);
                busqueda = consulta.ExecuteReader();
                busqueda.Read();

                en.nickname = busqueda["nickname"].ToString();
                en.password = busqueda["password"].ToString();
                en.email = busqueda["email"].ToString();
                en.image = busqueda["image"].ToString();
                en.background_image = busqueda["background_image"].ToString();
                en.name = busqueda["name"].ToString();
                en.firstname = busqueda["firstname"].ToString();
                en.secondname = busqueda["secondname"].ToString();
                en.twitter = busqueda["twitter"].ToString();
                en.facebook = busqueda["facebook"].ToString();

                encontrado = true;
            }
            catch (SqlException e)
            {
                encontrado = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                encontrado = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            finally
            {
                if (busqueda != null)
                {
                    busqueda.Close();
                }
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return encontrado;

        }

        public bool readUsuarios(ENUsuario en)
        {
            bool read = false;
            if (en is ENUsuario)
            {
                // Lectura de clientes
            }
            else
            {
                // Lectura de empresas
            }
            return read;
        }

        public bool updateUsuario(ENUsuario en)
        {
            bool modficiado = false;
            SqlConnection conection = null;

            try
            {
                conection = new SqlConnection(constring);
                conection.Open();

                string query = "UPDATE [firstrow_].[dbo].[Usuarios] set " +
                    "email = @email," +
                    "password = @password," +
                    "image = @image," +
                    "background_image = @background_image," +
                    "name = @name," +
                    "firstname = @firstname," +
                    "secondname = @secondname," +
                    "facebook = @facebook," +
                    "twitter = @twitter " +
                    "WHERE nickname = @nickname";
                SqlCommand consulta = new SqlCommand(query, conection);
                consulta.Parameters.AddWithValue("@nickname", en.nickname);
                consulta.Parameters.AddWithValue("@email", en.email);
                consulta.Parameters.AddWithValue("@password", en.password);
                consulta.Parameters.AddWithValue("@image", en.image);
                consulta.Parameters.AddWithValue("@background_image", en.background_image);
                consulta.Parameters.AddWithValue("@name", en.name);
                consulta.Parameters.AddWithValue("@firstname", en.firstname);
                consulta.Parameters.AddWithValue("@secondname", en.secondname);
                consulta.Parameters.AddWithValue("@facebook", en.facebook);
                consulta.Parameters.AddWithValue("@twitter", en.twitter);
                consulta.ExecuteNonQuery();
                modficiado = true;

            }
            catch (SqlException e)
            {
                modficiado = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                modficiado = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return modficiado;
        }

        public bool deleteUsuario(ENUsuario en)
        {
            bool delete = false;
            SqlConnection conection = null;

            try
            {
                conection = new SqlConnection(constring);
                conection.Open();

                string query = "DELETE from [firstrow_].[dbo].[Usuarios] " +
                    "WHERE nickname = @nickname";
                SqlCommand consulta = new SqlCommand(query, conection);
                consulta.Parameters.AddWithValue("@nickname", en.nickname);
                consulta.ExecuteNonQuery();
                delete = true;

            }
            catch (SqlException e)
            {
                delete = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                delete = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return delete;
        }
    }
}
