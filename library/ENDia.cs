using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENDia
    {
        private const int maxImgDia  = 3;
        private int _id;
        private string _nombre;
        private string _titulo;
        private string _descripcion;
        private string []_imagenes;
        private ENViajes _viaje;

        public int id { get => _id; set => _id = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public string titulo { get => _titulo; set => _titulo = value; }
        public string descripcion { get => _descripcion; set => _descripcion = value; }
        public string[] imagenes { get => _imagenes; set => _imagenes = value; }
        public ENViajes viaje { get => _viaje; set => _viaje = value; }

        public ENDia()
        {
            this.id = 0;
            this.nombre = "";
            this.titulo = "";
            this.descripcion = "";
            this.imagenes = new string[maxImgDia];
            this.viaje = new ENViajes();
        }

        public ENDia(int id, string nombre, string titulo, string descripcion, string[] imagenes, ENViajes viaje)
        {
            this.id = id;
            this.nombre = nombre;
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.imagenes = imagenes;
            this.viaje = viaje;
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
