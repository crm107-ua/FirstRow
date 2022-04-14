using System;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADComentarios
    {
        private String constring;

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

    }
}
