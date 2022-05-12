using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    
    public class ENViajes
    {
        
        private int _Id;
        private int _Dias;
        private string _Titulo;
        private string _Nombre;
        private string _Slug;
        private string _Descripcion;
        private double _Precio;
        private string _Background;
        private ENPais _Pais;
        private List<ENIncluido> _Incluidos;
        private List<ENDia> _Etapas;
        private List<ENImagenes> _Imagenes;
        private List<ENComentarios> _Comentarios;
        private ENEmpresa _Empresa;

        public int Id { get => _Id; set => _Id = value; }
        public int Dias { get => _Dias; set => _Dias = value; }
        public string Titulo { get => _Titulo; set => _Titulo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Slug { get => _Slug; set => _Slug = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public double Precio { get => _Precio; set => _Precio = value; }
        public string Background { get => _Background; set => _Background = value; }
        public ENPais Pais { get => _Pais; set => _Pais = value; }
        public List<ENIncluido> Incluidos { get => _Incluidos; set => _Incluidos = value; }
        public List<ENDia> Etapas { get => _Etapas; set => _Etapas = value; }
        public List<ENImagenes> Imagenes { get => _Imagenes; set => _Imagenes = value; }
        public List<ENComentarios> Comentarios { get => _Comentarios; set => _Comentarios = value; }
        public ENEmpresa Empresa { get => _Empresa; set => _Empresa = value; }

        public ENViajes()
        {
            Id = 0;
            Dias = 0;
            Titulo = "";
            Nombre = "";
            Slug = "";
            Descripcion = "";
            Precio = 0;
            Background = "default_bg.png";
            Pais = new ENPais();
            Incluidos = new List<ENIncluido>();
            Etapas = new List<ENDia>();
            Imagenes = new List<ENImagenes>();
            Comentarios = new List<ENComentarios>();
            Empresa = new ENEmpresa();
        }

        public ENViajes(int id, int dias, string titulo, string nombre, string slug, string descripcion, double precio, string background, ENPais pais, List<ENIncluido> incluidos, List<ENDia> etapas, List<ENImagenes> imagenes, List<ENComentarios> comentarios, ENEmpresa empresa)
        {
            Id = id;
            Dias = dias;
            Titulo = titulo;
            Nombre = nombre;
            Slug = slug;
            Descripcion = descripcion;
            Precio = precio;
            Background = background;
            Pais = pais;
            Incluidos = incluidos;
            Etapas = etapas;
            Imagenes = imagenes;
            Comentarios = comentarios;
            Empresa = empresa;
        }

        public bool agregarExperiencia()
        {
            CADViajes experiencia = new CADViajes();
            return experiencia.addExperiencia(this);
        }

        public bool mostrarExperiencias(List<ENViajes> listaExperiencias)
        {
            CADViajes experiencias = new CADViajes();
            return experiencias.readExperiencias(listaExperiencias);
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
