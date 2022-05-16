using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENIncluido
    {
        private int _id;
        private string _titulo;
        private string _descripcion;

        public int Id { get => _id; set => _id = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        public ENIncluido()
        {
            Id = 0;
            Titulo = "";
            Descripcion = "";
        }

        public ENIncluido(int id, string titulo)
        {
            Id = id;
            Titulo = titulo;
            Descripcion = "";
        }

        public ENIncluido(int id, string titulo, string descripcion)
        {
            Id = id;
            Titulo = titulo;
            Descripcion = descripcion;
        }

        public DataSet readIncluidos()
        {
            CADIncluido incluidos = new CADIncluido();
            return incluidos.readIncluidos();
        }

    }
}
