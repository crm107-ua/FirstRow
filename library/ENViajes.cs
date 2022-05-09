using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    
    public class ENViajes
    {
        
        private int _Id;
        private string _Titulo;
        private string _Nombre;
        private string _Slug;
        private string _Descripcion;
        private double _Precio;
        private ENPais _Pais;
        private List<ENDia> _Incluido;
        private List<ENImagenes> _Imagenes;
        private List<ENStories> _Stories;
        private List<ENComentarios> _Comentarios;
        private ENEmpresa _Empresa;

        public int Id { get => _Id; set => _Id = value; }
        public string Titulo { get => _Titulo; set => _Titulo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Slug { get => _Slug; set => _Slug = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public double Precio { get => _Precio; set => _Precio = value; }
        public ENPais Pais { get => _Pais; set => _Pais = value; }
        public List<ENDia> Incluido { get => _Incluido; set => _Incluido = value; }
        public List<ENImagenes> Imagenes { get => _Imagenes; set => _Imagenes = value; }
        public List<ENStories> Stories { get => _Stories; set => _Stories = value; }
        public List<ENComentarios> Comentarios { get => _Comentarios; set => _Comentarios = value; }
        public ENEmpresa Empresa { get => _Empresa; set => _Empresa = value; }

        public ENViajes()
        {
            Id = 0;
            Titulo = "";
            Nombre = "";
            Slug = "";
            Descripcion = "";
            Precio = 0;
            Pais = new ENPais();
            Imagenes = new List<ENImagenes>();
            Stories = new List<ENStories>();
            Comentarios = new List<ENComentarios>();
            Empresa = new ENEmpresa();
            Incluido = new List<ENDia>();
        }

        public ENViajes(int id, string titulo, string nombre, string slug, string descripcion, double precio, ENPais pais, List<ENDia> incluido, List<ENImagenes> imagenes, List<ENStories> stories, List<ENComentarios> comentarios, ENEmpresa empresa)
        {
            _Id = id;
            _Titulo = titulo;
            _Nombre = nombre;
            _Slug = slug;
            _Descripcion = descripcion;
            _Precio = precio;
            _Pais = pais;
            _Incluido = incluido;
            _Imagenes = imagenes;
            _Stories = stories;
            _Comentarios = comentarios;
            _Empresa = empresa;
        }

        public bool addImagen(){
            CADViajes img = new CADViajes();
            bool ok = img.addImagen(this);
            return ok;
        }
        public bool readImagen() {
            CADViajes img = new CADViajes();
            bool ok = img.readImagen(this);
            return ok;
        }
        public bool updateImagen() {
            CADViajes img = new CADViajes();
            bool ok = img.updateImagen(this);
            return ok;
        }
        public bool deleteImagen() {
            CADViajes img = new CADViajes();
            bool ok = img.deleteImagen(this);
            return ok;
        }
        public bool createIncluido() {
            CADViajes inc = new CADViajes();
            bool ok = inc.createIncluido(this);
            return ok;
        }
        public bool readIncluido() {
            CADViajes inc = new CADViajes();
            bool ok = inc.readIncluido(this);
            return ok;
        }
        public bool updateIncluido() {
            CADViajes inc = new CADViajes();
            bool ok = inc.updateIncluido(this);
            return ok;
        }
        public bool deleteIncluido() {
            CADViajes inc = new CADViajes();
            bool ok = inc.deleteIncluido(this);
            return ok;
        }


    }
}
