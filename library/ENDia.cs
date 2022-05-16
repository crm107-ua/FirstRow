using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENDia
    {
        private int _id;
        private string _nombre;
        private string _titulo;
        private string _descripcion;
        private string _imagen;
        private ENViajes _experiencia;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Imagen { get => _imagen; set => _imagen = value; }
        public ENViajes Experiencia { get => _experiencia; set => _experiencia = value; }

        public ENDia()
        {
            _id = 0;
            _nombre = "";
            _titulo = "";
            _descripcion = "";
            _imagen = "";
            _experiencia =new ENViajes();
        }

        public ENDia(int id, string nombre, string titulo, string descripcion, string imagen, ENViajes experiencia)
        {
            _id = id;
            _nombre = nombre;
            _titulo = titulo;
            _descripcion = descripcion;
            _imagen = imagen;
            _experiencia = experiencia;
        }

        public bool createDia()
        {
            CADDia blog = new CADDia();
            return blog.createDia(this);
        }

        public bool modifyDia()
        {
            CADDia blog = new CADDia();
            return blog.modifyDia(this);
        }

        public bool deleteDia()
        {
            CADDia blog = new CADDia();
            return blog.deleteDia(this);
        }

    }
}
