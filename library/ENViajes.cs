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
        private int _Pais;
        private string _Nombre;
        private int _Slug;
        private string _Descripcion;
        private string[] _Imagenes;
        private string[] _Incluido;
        private ENStories _Stories;
        private ENComentarios _Comentarios;
        private ENEmpresa _Empresa;
        /// <summary>
        /// Identificador de los viajes
        /// </summary>
        public int Id { get => _Id; set => _Id = value; }
        /// <summary>
        /// Pais de destino del viaje
        /// </summary>
        public int Pais { get => _Pais; set => _Pais = value; }
        /// <summary>
        /// Nombre del viaje
        /// </summary>
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        /// <summary>
        /// slug para los nombres de la pagina web
        /// </summary>
        public int Slug { get => _Slug; set => _Slug = value; }
        /// <summary>
        /// Descripcion del viaje
        /// </summary>
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        /// <summary>
        /// Imagenes del viaje
        /// </summary>
        public string[] Imagenes { get => _Imagenes; set => _Imagenes = value; }//crud
        /// <summary>
        /// Detalles incluidos en el viaje
        /// </summary>
        public string[] Incluido { get => _Incluido; set => _Incluido = value; }//crud
        /// <summary>
        /// Stories del viaje
        /// </summary>
        public ENStories Stories { get => _Stories; set => _Stories = value; }
        /// <summary>
        /// comentarios del viaje
        /// </summary>
        public ENComentarios Comentarios { get => _Comentarios; set => _Comentarios = value; }
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ENEmpresa Empresa { get => _Empresa; set => _Empresa = value; }
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ENViajes()
        {
            Id = 0;
            Pais = 0;
            Nombre = "";
            Slug = 0;
            Descripcion = "";
            Imagenes = null;
            Incluido = null;
            Stories = new ENStories();
            Comentarios = new ENComentarios();
            Empresa = new ENEmpresa();
        }
        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <param name="pais">Destino</param>
        /// <param name="nombre">Nombre del viaje</param>
        /// <param name="slug">Slug</param>
        /// <param name="descripcion">Descripcion</param>
        /// <param name="imagenes">Array de imagenes</param>
        /// <param name="incluido">Array de detalles incluidos</param>
        /// <param name="stories">Stories</param>
        /// <param name="comentarios">Comentarios</param>
        public ENViajes(int id, int pais, string nombre, int slug, string descripcion, string[] imagenes, string[] incluido, ENStories stories, ENComentarios comentarios, ENEmpresa empresa)
        {
            Id = id;
            Pais = pais;
            Nombre = nombre;
            Slug = slug;
            Descripcion = descripcion;
            Imagenes = imagenes;
            Incluido = incluido;
            Stories = stories;
            Comentarios = comentarios;
            Empresa = empresa;
        }
      /// <summary>
      /// añade una imagen
      /// </summary>
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
