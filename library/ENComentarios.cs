using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENComentarios
    {
        private int _Id;
        private string _Texto;
        private int _Estrellas;
        private string _Nickname;

        public ENComentarios()
        {
            _Id = 0;
            _Texto = "";
            _Estrellas = 0;
            _Nickname = "";
        }

        public ENComentarios(int id, string texto, int estrellas, string nickname)
        {
            _Id = id;
            _Texto = texto;
            _Estrellas = estrellas;
            _Nickname = nickname;
        }

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
