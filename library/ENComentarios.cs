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
        private ENUsuario _Usuario;

        public int Id { get => _Id; set => _Id = value; }
        public string Texto { get => _Texto; set => _Texto = value; }
        public int Estrellas { get => _Estrellas; set => _Estrellas = value; }
        public ENUsuario Usuario { get => _Usuario; set => _Usuario = value; }

        public ENComentarios()
        {
            _Id = 0;
            _Texto = "";
            _Estrellas = 0;
            _Usuario = new ENUsuario();
        }

        public ENComentarios(int id, string texto, int estrellas, ENUsuario usuario)
        {
            _Id = id;
            _Texto = texto;
            _Estrellas = estrellas;
            _Usuario = usuario;
        }
    }
}
