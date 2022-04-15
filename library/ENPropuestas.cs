using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENPropuestas
    {
        private int _Id;
        private string _Imagen; 

        public int Id //GET-SET
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Imagen //GET-SET
        {
            get { return _Imagen; }
            set { _Imagen = value; }
        }

        public static string _Nombre; //CRUD

        public static string _Descripcion; //CRUD

        public static string _Categoria; //CRUD

        public static string _Empresa; //CRUD
    }
}
