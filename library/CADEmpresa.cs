using System;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADEmpresa
    {
        private String constring;

        public CADEmpresa()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        public bool registerEmpresa(ENEmpresa en)
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
                query = "Insert INTO [firstrow_].[dbo].[Empresas] " +
                    "(nickname,cif,fechaCreacion,direccion,pais) " +
                    "VALUES " +
                    "(@nickname,@cif,@fechaCreacion,@direccion,@pais)";
                consulta = new SqlCommand(query, conection);
                consulta.Parameters.AddWithValue("@nickname", en.nickname);
                consulta.Parameters.AddWithValue("@cif", en.cif);
                consulta.Parameters.AddWithValue("@fechaCreacion", en.fechaCreacion);
                consulta.Parameters.AddWithValue("@direccion", en.direccion);
                consulta.Parameters.AddWithValue("@pais", en.pais.id);
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

        public bool loginEmpresa(ENEmpresa en)
        {
            bool encontrado = false;
            ENPais pais;
            SqlConnection conection = null;
            SqlDataReader busqueda = null;

            try
            {
                pais = new ENPais();
                conection = new SqlConnection(constring);
                conection.Open();

                string query = "SELECT * FROM [firstrow_].[dbo].[Usuarios] u INNER JOIN [firstrow_].[dbo].[Empresas] e on u.nickname = e.nickname where u.email = @email";
                SqlCommand consulta = new SqlCommand(query, conection);
                consulta.Parameters.AddWithValue("@email", en.email);
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
                en.cif = busqueda["cif"].ToString();
                en.direccion = busqueda["direccion"].ToString();
                en.fechaCreacion = DateTime.Parse(busqueda["fechaCreacion"].ToString());
                pais.id = int.Parse(busqueda["pais"].ToString());

                busqueda.Close();
                query = "SELECT * FROM [firstrow_].[dbo].[Paises] where id = @id";
                consulta = new SqlCommand(query, conection);
                consulta.Parameters.AddWithValue("@id", pais.id);
                busqueda = consulta.ExecuteReader();
                busqueda.Read();
                pais.name = busqueda["name"].ToString();
                en.pais = pais;

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

        public bool readEmpresa(ENEmpresa en)
        {
            bool encontrado = false;
            ENPais pais;
            SqlConnection conection = null;
            SqlDataReader busqueda = null;

            try
            {
                pais = new ENPais();
                conection = new SqlConnection(constring);
                conection.Open();

                string query = "SELECT * FROM [firstrow_].[dbo].[Usuarios] u INNER JOIN [firstrow_].[dbo].[Empresas] e on u.nickname = e.nickname where u.nickname = @nickname";
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
                en.cif = busqueda["cif"].ToString();
                en.direccion = busqueda["cif"].ToString();
                en.fechaCreacion = DateTime.Parse(busqueda["fechaCreacion"].ToString());
                pais.id = int.Parse(busqueda["pais"].ToString());

                busqueda.Close();
                query = "SELECT * FROM [firstrow_].[dbo].[Paises] where id = @id";
                consulta = new SqlCommand(query, conection);
                consulta.Parameters.AddWithValue("@id", pais.id);
                busqueda = consulta.ExecuteReader();
                busqueda.Read();
                pais.name = busqueda["name"].ToString();
                en.pais = pais;

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

        public bool updateEmpresa(ENEmpresa en)
        {
            bool modficiado = false;
            SqlConnection conection = null;
            SqlDataReader busqueda = null;

            try
            {
                conection = new SqlConnection(constring);
                conection.Open();

                string query = "UPDATE [firstrow_].[dbo].[Usuarios] set " +
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
                consulta.Parameters.AddWithValue("@password", en.password);
                consulta.Parameters.AddWithValue("@image", en.image);
                consulta.Parameters.AddWithValue("@background_image", en.background_image);
                consulta.Parameters.AddWithValue("@name", en.name);
                consulta.Parameters.AddWithValue("@firstname", en.firstname);
                consulta.Parameters.AddWithValue("@secondname", en.secondname);
                consulta.Parameters.AddWithValue("@facebook", en.facebook);
                consulta.Parameters.AddWithValue("@twitter", en.twitter);
                consulta.Parameters.AddWithValue("@nickname", en.nickname);
                consulta.ExecuteNonQuery();
                query = "UPDATE [firstrow_].[dbo].[Empresas] set " +
                    "cif = @cif," +
                    "direccion = @direccion," +
                    "pais = @pais " +
                    "WHERE nickname = @nickname";
                consulta = new SqlCommand(query, conection);
                consulta.Parameters.AddWithValue("@nickname", en.nickname);
                consulta.Parameters.AddWithValue("@cif", en.cif);
                consulta.Parameters.AddWithValue("@direccion", en.direccion);
                consulta.Parameters.AddWithValue("@pais", en.pais.id);
                consulta.ExecuteNonQuery();
                query = "SELECT name FROM [firstrow_].[dbo].[Paises] where id = @id";
                consulta = new SqlCommand(query, conection);
                consulta.Parameters.AddWithValue("@id", en.pais.id);
                busqueda = consulta.ExecuteReader();
                busqueda.Read();
                en.pais.name = busqueda["name"].ToString();
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
                if (busqueda != null)
                {
                    busqueda.Close();
                }
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return modficiado;
        }
 
    }
}
