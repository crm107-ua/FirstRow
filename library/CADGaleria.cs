using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace library
{
    public class CADGaleria
    {
        private String constring;

        public CADGaleria()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        public bool createGaleria(ENGaleria galeria) 
        {
            bool consegido=false;
            CADGaleria aux = new CADGaleria();

            try
            {

                using (TransactionScope scope = new TransactionScope())
                {
                    //Primera transacion
                    using (SqlConnection connection= new SqlConnection(constring))
                    {
                        List<int> idImagnes = new List<int>();
                        if (!aux.readGaleria(galeria))
                        {
                            foreach (ENImagenes imagen in galeria.Imagenes)
                            {
                                if (imagen.addImg())
                                {
                                    idImagnes.Add(int.Parse(imagen.Id.ToString()));
                                }
                            }
                            connection.Open();

                            if (idImagnes.Count != galeria.Imagenes.Count)
                            {
                                throw new Exception();
                            }

                            String sentencia = "insert into [dbo].[Seccion_Galeria] (titulo,descripcion,pais,slug,usuario) " +
                                "values (@titulo, @descripcion, @pais, @slug, @usuario); " +
                                "select scope_identity();";
                            SqlCommand comando = new SqlCommand(sentencia, connection);
                            comando.Parameters.AddWithValue("@titulo",galeria.Titulo);
                            comando.Parameters.AddWithValue("@descripcion", galeria.Descripcion);
                            comando.Parameters.AddWithValue("@pais", galeria.Pais.id);
                            comando.Parameters.AddWithValue("@slug", galeria.Slug);
                            comando.Parameters.AddWithValue("@usuario", galeria.Usuario.nickname);
                            galeria.Id = Convert.ToInt32(comando.ExecuteScalar());

                            foreach (int idImagen in idImagnes) 
                            {
                                String sentenciaRelacion = "insert into[dbo].[Seccion_Galeria_Imagenes] (id_seccion_galeria, id_imagen) values(@idGaleria, @idImagen)";
                                SqlCommand comandoRelacio = new SqlCommand(sentenciaRelacion, connection);
                                comandoRelacio.Parameters.AddWithValue("@idGaleria", galeria.Id);
                                comandoRelacio.Parameters.AddWithValue("@idImagen", idImagen);
                                comandoRelacio.ExecuteNonQuery();
                            }

                            consegido = true;
                        }

                        connection.Close();
                    }

                    //Si no se lanzan excepciones y llega no hace rolback
                    scope.Complete();
                }
            }
            catch (Exception excepcion)
            {
                Console.WriteLine("La excepcion es"+excepcion.Data);
            }

            return consegido;
        }

        public bool readGaleria(ENGaleria galeria) 
        {
            SqlConnection connection = new SqlConnection(constring);
            SqlDataReader reader = null;
            SqlDataReader readerimagenes = null;
            bool conseguido = false;
            string comand = "select Seccion_Galeria.id, titulo, descripcion, usuario , slug, Paises.id 'PaisId', Paises.name 'NamePais' " +
                    "from [firstrow_].[dbo].[Seccion_Galeria] join Paises on(Paises.id = Seccion_Galeria.pais) where slug='"+ galeria.Slug + "'";

            try
            {
                connection.Open();
                SqlCommand com = new SqlCommand(comand, connection);
                reader = com.ExecuteReader();
                reader.Read();
                galeria.Id = int.Parse(reader["id"].ToString());
                galeria.Titulo = reader["titulo"].ToString();
                galeria.Descripcion = reader["descripcion"].ToString();
                galeria.Usuario.nickname = reader["usuario"].ToString();
                galeria.Pais = new ENPais(int.Parse(reader["PaisId"].ToString()), reader["NamePais"].ToString());

                reader.Close();
                string comandImg = "select name from Seccion_Galeria_Imagenes join Imagenes on(Imagenes.id = Seccion_Galeria_Imagenes.id_imagen)" +
                        " where Seccion_Galeria_Imagenes.id_seccion_galeria =" + galeria.Id;

                SqlCommand comandoImagenes = new SqlCommand(comandImg, connection);
                List<ENImagenes> imagenes = new List<ENImagenes>();
                readerimagenes = comandoImagenes.ExecuteReader();

                while (readerimagenes.Read()) {
                    imagenes.Add(new ENImagenes(readerimagenes["name"].ToString()));
                }

                galeria.Imagenes = imagenes;

                conseguido = true;

            }
            catch (Exception exception)
            { 
            }
            finally 
            {
                connection.Close();
            }

            return conseguido;
        }

        public bool deleteGaleria(ENGaleria galeria) 
        {
            bool consegido = false;
            CADGaleria aux = new CADGaleria();

            if (aux.readGaleria(galeria))
            {
                try
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        //Primera transacion
                        using (SqlConnection connection = new SqlConnection(constring))
                        {
                            foreach (ENImagenes imgagen in galeria.Imagenes) 
                            {
                                if (!imgagen.deleteImg()) 
                                {
                                    throw new Exception();
                                }
                            }

                            connection.Open();
                            string comando = "delete from [firstrow_].[dbo].[Seccion_Galeria] where slug=@slug;";

                            SqlCommand sqlCommand = new SqlCommand(comando, connection);
                            sqlCommand.Parameters.AddWithValue("@slug",galeria.Slug);
                            sqlCommand.ExecuteNonQuery();
                            consegido = true;

                            connection.Close();
                        }

                        scope.Complete();
                    }
                }
                catch (Exception excepcion)
                {
                }
                finally
                {
                }

            }

            return consegido;
        }

        public bool updateGaleria(ENGaleria galeria) 
        {
            bool consegido = false;

            if (!this.readGaleria(galeria))
            {
                //Se modifica solo el titulo ciudad y descripcion en la base de datos
                consegido = true;
            }

            return consegido;
        }

        public bool readAllGaleri(List <ENGaleria> lista) 
        {
            bool conseguido = false;
            SqlConnection connection = new SqlConnection(constring);

            try
            {
                //Servicio Desconectado
                //Optencion de la DBD Virtual de galeria
                
                DataSet dbd = new DataSet();
                DataSet dbdImgenes = new DataSet();
                string slectGaleria = "select Seccion_Galeria.id, titulo, descripcion, slug, Paises.id 'PaisId', Paises.name 'NamePais' " +
                    "from [firstrow_].[dbo].[Seccion_Galeria] join Paises on(Paises.id = Seccion_Galeria.pais);";

                SqlDataAdapter adapter = new SqlDataAdapter(slectGaleria, connection);
                adapter.Fill(dbd,"Galerias");

                DataTable tableGaleria = dbd.Tables["Galerias"];
                DataRow[] rowsGaleria = tableGaleria.Select();

                lista.Clear();


                // Las imagenes se tienen que tratar con listas de objectos ENImagenes
                // ENGaleria modificado

                for (int i = 0; i < rowsGaleria.Length; i++)
                {
                    //Rellenado de imagenes
                    string slectImagenes = "select name from Seccion_Galeria_Imagenes join Imagenes on(Imagenes.id = Seccion_Galeria_Imagenes.id_imagen)" +
                        " where Seccion_Galeria_Imagenes.id_seccion_galeria ="+ rowsGaleria[i]["id"]+";";

                    SqlDataAdapter adapterImagenes = new SqlDataAdapter(slectImagenes, connection);
                    adapterImagenes.Fill(dbdImgenes, "Imagenes");

                    DataTable tableImg = dbdImgenes.Tables["Imagenes"];
                    DataRow[] rowsImg = tableImg.Select();

                    List<ENImagenes> imagenes = new List<ENImagenes>();
                    for (int j = 0; j < rowsImg.Length; j++)
                    {
                        imagenes.Add(new ENImagenes(rowsImg[j]["name"].ToString()));
                    }

                    // Modificado por Carlos, pendiente de revision
                    ENPais pais = new ENPais(int.Parse(rowsGaleria[i]["PaisId"].ToString()), rowsGaleria[i]["NamePais"].ToString());
                    ENGaleria galeria = new ENGaleria(int.Parse(rowsGaleria[i]["id"].ToString()) ,pais, rowsGaleria[i]["slug"].ToString(), rowsGaleria[i]["titulo"].ToString(), rowsGaleria[i]["descripcion"].ToString(), imagenes);
                    lista.Add(galeria);

                    dbdImgenes.Clear();
                }

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

        public bool readAllCountyGaleri(List<ENGaleria> lista, ENPais pais)
        {
            bool conseguido = false;
            SqlConnection connection = new SqlConnection(constring);

            try
            {
                //Servicio Desconectado
                //Optencion de la DBD Virtual de galeria

                DataSet dbd = new DataSet();
                DataSet dbdImgenes = new DataSet();
                string slectGaleria = "select Seccion_Galeria.id, titulo, descripcion, slug, Paises.id 'PaisId', Paises.name 'NamePais' " +
                    "from [firstrow_].[dbo].[Seccion_Galeria] join Paises on(Paises.id = Seccion_Galeria.pais)" +
                    "where Paises.id="+pais.id;

                SqlDataAdapter adapter = new SqlDataAdapter(slectGaleria, connection);
                adapter.Fill(dbd, "Galerias");

                DataTable tableGaleria = dbd.Tables["Galerias"];
                DataRow[] rowsGaleria = tableGaleria.Select();

                lista.Clear();


                // Las imagenes se tienen que tratar con listas de objectos ENImagenes
                // ENGaleria modificado
                List<ENImagenes> imagenes = new List<ENImagenes>();

                for (int i = 0; i < rowsGaleria.Length; i++)
                {
                    //Rellenado de imagenes
                    string slectImagenes = "select name from Seccion_Galeria_Imagenes join Imagenes on(Imagenes.id = Seccion_Galeria_Imagenes.id_imagen)" +
                        " where Seccion_Galeria_Imagenes.id_seccion_galeria =" + rowsGaleria[i]["id"] + ";";

                    SqlDataAdapter adapterImagenes = new SqlDataAdapter(slectImagenes, connection);
                    adapterImagenes.Fill(dbdImgenes, "Imagenes");

                    DataTable tableImg = dbdImgenes.Tables["Imagenes"];
                    DataRow[] rowsImg = tableImg.Select();

                    imagenes.Clear();
                    for (int j = 0; j < rowsImg.Length; j++)
                    {
                        imagenes.Add(new ENImagenes(rowsImg[j]["name"].ToString()));
                    }

                    // Modificado por Carlos, pendiente de revision
                    ENGaleria galeria = new ENGaleria(int.Parse(rowsGaleria[i]["id"].ToString()), pais, rowsGaleria[i]["slug"].ToString(), rowsGaleria[i]["titulo"].ToString(), rowsGaleria[i]["descripcion"].ToString(), imagenes);
                    lista.Add(galeria);

                    dbdImgenes.Clear();
                }

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


    }
}
