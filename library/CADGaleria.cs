using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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
            SqlConnection connection = new SqlConnection(constring);
            DataSet dbd = new DataSet();
            string slectGaleria = "select * from [dbo].[Seccion_Galeria];";
            string selectImagenes = "select * from [dbo].[Imagenes];";
            string selectRealcion = "select * from [dbo].[Seccion_Galeria_Imagenes];";

            try
            {
                if (!aux.readGaleria(galeria))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(slectGaleria, connection);
                    adapter.Fill(dbd, "Galerias");
                    SqlDataAdapter adapterImagenes = new SqlDataAdapter(selectImagenes, connection);
                    adapterImagenes.Fill(dbd, "Imagenes");
                    SqlDataAdapter adapterRelacion = new SqlDataAdapter(selectRealcion, connection);
                    adapterRelacion.Fill(dbd, "Relacion");

                    //Añadimos la tabla galeria
                    DataTable galeriaTabla = new DataTable();
                    galeriaTabla = dbd.Tables["Galeria"];
                    DataRow nuevaGaleria = galeriaTabla.NewRow();

                    nuevaGaleria["titulo"] = galeria.Titulo;
                    nuevaGaleria["descripcion"] = galeria.Descripcion;
                    nuevaGaleria["pais"] = galeria.Pais.id;
                    nuevaGaleria["slug"] = galeria.Slug;
                    nuevaGaleria["usuario"] = galeria.Usuario.nickname;
                    galeriaTabla.Rows.Add(nuevaGaleria);

                    //Añadimos tablas galerias
                    DataTable ImagenesTabla = new DataTable();
                    galeriaTabla = dbd.Tables["Galeria"]; 
                    
                    foreach (ENImagenes imagen in galeria.Imagenes)
                    { 
                        DataRow nuevaImagen = ImagenesTabla.NewRow();

                        nuevaGaleria["name"] = imagen.Name;
                        ImagenesTabla.Rows.Add(nuevaGaleria);
                    }

                    if (aux.readGaleria(galeria)) 
                    {
                        foreach (ENImagenes imagen in galeria.Imagenes)
                        {
                            /*
                             * Falta lectura de imagenes y juntar ids
                            if()
                            */
                        }
                    }

                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter); 
                    SqlCommandBuilder commandBuilderImg = new SqlCommandBuilder(adapterImagenes);
                    SqlCommandBuilder commandBuilderRelacion = new SqlCommandBuilder(adapterRelacion);
                    adapter.Update(dbd, "[dbo].[Seccion_Galeria]");
                    adapterImagenes.Update(dbd, "[dbo].[Imagenes]");
                    adapterRelacion.Update(dbd, "[dbo].[Seccion_Galeria_Imagenes]");

                    consegido = true;
                }
            }
            catch (Exception excepcion)
            { 
            }
            finally 
            {
                connection.Close();
            }

            return consegido;
        }

        public bool readGaleria(ENGaleria galeria) 
        {
            SqlConnection connection = new SqlConnection(constring);
            SqlDataReader reader = null;
            SqlDataReader readerimagenes = null;
            bool conseguido = false;
            string comand = "select Seccion_Galeria.id, titulo, descripcion, slug, Paises.id 'PaisId', Paises.name 'NamePais' " +
                    "from [dbo].[Seccion_Galeria] join Paises on(Paises.id = Seccion_Galeria.pais) where slug='" +galeria.Slug+"';";

            try
            {
                connection.Open();
                SqlCommand com = new SqlCommand(comand, connection);
                reader = com.ExecuteReader();
                galeria.Id = int.Parse(reader["id"].ToString());
                galeria.Titulo = reader["titulo"].ToString();
                galeria.Descripcion = reader["descripcion"].ToString();
                galeria.Pais = new ENPais(int.Parse(reader["PaisId"].ToString()), reader["NamePais"].ToString());

                string comandImg = "select name from Seccion_Galeria_Imagenes join Imagenes on(Imagenes.id = Seccion_Galeria_Imagenes.id_imagen)" +
                        " where Seccion_Galeria_Imagenes.id_seccion_galeria ='" + reader["id"].ToString() + "'";

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

            if (!aux.readGaleria(galeria))
            {
                //Se Borra en la base de datos
                consegido = true;
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
                
                DataSet dbdGalerias = new DataSet();
                DataSet dbdImagenes = new DataSet();
                string slectGaleria = "select Seccion_Galeria.id, titulo, descripcion, slug, Paises.id 'PaisId', Paises.name 'NamePais' " +
                    "from [dbo].[Seccion_Galeria] join Paises on(Paises.id = Seccion_Galeria.pais);";

                SqlDataAdapter adapter = new SqlDataAdapter(slectGaleria, connection);
                adapter.Fill(dbdGalerias,"Galerias");

                DataTable tableGaleria = dbdGalerias.Tables["Galerias"];
                DataRow[] rowsGaleria = tableGaleria.Select();

                lista.Clear();


                // Las imagenes se tienen que tratar con listas de objectos ENImagenes
                // ENGaleria modificado
                List<ENImagenes> imagenes = new List<ENImagenes>();

                for (int i = 0; i < rowsGaleria.Length; i++)
                {
                    //Rellenado de imagenes
                    string slectImagenes = "select name from Seccion_Galeria_Imagenes join Imagenes on(Imagenes.id = Seccion_Galeria_Imagenes.id_imagen)" +
                        " where Seccion_Galeria_Imagenes.id_seccion_galeria ='"+ rowsGaleria[i]["id"]+"'";

                    SqlDataAdapter adapterImagenes = new SqlDataAdapter(slectImagenes, connection);
                    adapter.Fill(dbdImagenes, "Imagenes");

                    DataTable tableImg = dbdGalerias.Tables["Imagenes"];
                    DataRow[] rowsImg = tableImg.Select();

                    imagenes.Clear();
                    for (int j = 0; j < rowsGaleria.Length; j++)
                    {
                        imagenes.Add(new ENImagenes(rowsImg[j]["name"].ToString()));
                    }

                    // Modificado por Carlos, pendiente de revision
                    ENPais pais = new ENPais(int.Parse(rowsGaleria[i]["PaisId"].ToString()), rowsGaleria[i]["NamePais"].ToString());
                    ENGaleria galeria = new ENGaleria(int.Parse(rowsGaleria[i]["id"].ToString()) ,pais, rowsGaleria[i]["slug"].ToString(), rowsGaleria[i]["titulo"].ToString(), rowsGaleria[i]["descripcion"].ToString(), imagenes);
                    lista.Add(galeria);
                }

            }
            catch (Exception e) 
            { 
            }
            finally
            {
                connection.Close();
            }


            //Si hay alguna galeria
            if (true) { }

            /*
              select Seccion_Galeria.id, titulo, descripcion, slug, Paises.id "PaisId", Paises.name "NamePais" from Seccion_Galeria
                join Paises on (Paises.id=Seccion_Galeria.pais);

                select * from Seccion_Galeria_Imagenes
                join Imagenes on (Imagenes.id=Seccion_Galeria_Imagenes.id_imagen)
                where Seccion_Galeria_Imagenes.id_seccion_galeria=0
             */

            return conseguido;
        }


    }
}
