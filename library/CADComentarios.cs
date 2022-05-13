using System;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADComentarios
    {
        private String constring;
        ArrayList lista = new ArrayList();

        public CADComentarios()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }
        private int _Id;
        private string _Texto;
        private int _Estrellas;
        private string _Nickname;

        public int Id //GET-SET
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Texto //GET-SET
        {
            get { return _Texto; }
            set { _Texto = value; }
        }
        public int Estrellas //GET-SET
        {
            get { return _Estrellas; }
            set { _Estrellas = value; }
        }
        public string Nickname //GET-SET
        {
            get { return _Nickname; }
            set { _Nickname = value; }
        }
        public void InsertComennt(ENComentarios c)
        {
            SqlConnection nueva_conexion = new SqlConnection(constring);

            try
            {
                nueva_conexion.Open();
                string insert = "";
                insert = "Insert Into CommentsContent(Id,Texto,Nickname,Estrellas) VALUES (" + c.Id + "," + c.Texto + ",'" + c.Nickname + "," + c.Estrellas + "')";
                SqlCommand com = new SqlCommand(insert, nueva_conexion);

                com.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { nueva_conexion.Close(); }
        }
        public void DeleteComennt(ENComentarios c)
        {
            SqlConnection nueva_conexion = new SqlConnection(constring);

            try
            {
                nueva_conexion.Open();
                string delete = "";
                delete = "Delete from Files where CommentsContent.Id = " + c.Id + "AND CommentsContent.Texto" + c.Texto + "AND CommentsContent.Nickname" + c.Nickname + "AND CommentsContent.Estrellas" + c.Estrellas;
                SqlCommand com = new SqlCommand(delete, nueva_conexion);


                com.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { nueva_conexion.Close(); }
        }
        public ArrayList ShowComennts(ENComentarios comentario)
        {
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand("Select Content from CommentsContent WHERE Id=" + comentario.Id + " AND Texto=" + comentario.Texto + " AND Nickname=" + comentario.Nickname + " AND Estrellas=" + comentario.Estrellas, c);
            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(dr["Content"].ToString());
            }
            dr.Close();
            c.Close();

            return lista;
        }
    }
}

    

