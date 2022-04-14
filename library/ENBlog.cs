using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENBlog
    {
        private const int maxImages = 6;
        private string _imagen_principal;
        private string _titulo;
        private string _descripcion;
        private string _texto_1;
        private string _texto_2;
        private string _texto_3;
        private string _citacion;
        private string[] _imagenes;
        private ENUsuario _usurio;
        private ENCategorias _categoria;
        private List<ENStories> _stories;
        private List<ENComentarios> _comentarios;
        private ENPais _pais;

        public string imagen_principal { get => _imagen_principal; set => _imagen_principal = value; }
        public string titulo { get => _titulo; set => _titulo = value; }
        public string descripcion { get => _descripcion; set => _descripcion = value; }
        public string texto_1 { get => _texto_1; set => _texto_1 = value; }
        public string texto_2 { get => _texto_2; set => _texto_2 = value; }
        public string texto_3 { get => _texto_3; set => _texto_3 = value; }
        public string citacion { get => _citacion; set => _citacion = value; }
        public string[] imagenes { get => _imagenes; set => _imagenes = value; }
        public ENUsuario usurio { get => _usurio; set => _usurio = value; }
        public ENCategorias categoria { get => _categoria; set => _categoria = value; }
        public List<ENStories> stories { get => _stories; set => _stories = value; }
        public List<ENComentarios> comentarios { get => _comentarios; set => _comentarios = value; }
        public ENPais pais { get => _pais; set => _pais = value; }

        public ENBlog()
        {
            this.imagen_principal = "";
            this.titulo = "";
            this.descripcion = "";
            this.texto_1 = "";
            this.texto_2 = "";
            this.texto_3 = "";
            this.citacion = "";
            this.imagenes = new string[maxImages];
            this.usurio = new ENUsuario();
            this.categoria = new ENCategorias();
            this.stories = new List<ENStories>();
            this.comentarios = new List<ENComentarios>();
            this.pais = new ENPais();
        }

        public ENBlog(string imagen_principal, string titulo, string descripcion, string texto_1, string texto_2, string texto_3, string citacion, string[] imagenes, ENUsuario usurio, ENCategorias categoria, List<ENStories> stories, List<ENComentarios> comentarios, ENPais pais)
        {
            this.imagen_principal = imagen_principal;
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.texto_1 = texto_1;
            this.texto_2 = texto_2;
            this.texto_3 = texto_3;
            this.citacion = citacion;
            this.imagenes = imagenes;
            this.usurio = usurio;
            this.categoria = categoria;
            this.stories = stories;
            this.comentarios = comentarios;
            this.pais = pais;
        }

        public bool crearBlog()
        {
            CADBlog blog = new CADBlog();
            return blog.createBlog(this);
        }

        public bool updateBlog()
        {
            bool actualizado = false;
            CADBlog blog = new CADBlog();
            ENBlog aux = new ENBlog();

            aux.imagen_principal = this.imagen_principal;
            aux.titulo = this.titulo;
            aux.descripcion = this.descripcion;
            aux.texto_1 = this.texto_1;
            aux.texto_2 = this.texto_2;
            aux.texto_3 = this.texto_3;
            aux.citacion = this.citacion;
            aux.imagenes = this.imagenes;
            aux.usurio = this.usurio;
            aux.categoria = this.categoria;
            aux.stories = this.stories;
            aux.comentarios = this.comentarios;
            aux.pais = this.pais;

            if (blog.readBlog(this))
            {
                actualizado = blog.updateBlog(aux);
                this.titulo = aux.titulo;
                this.descripcion = aux.descripcion;
                this.texto_1 = aux.texto_1;
                this.texto_2 = aux.texto_2;
                this.texto_3 = aux.texto_3;
                this.citacion = aux.citacion;
                this.imagenes = aux.imagenes;
                this.usurio = aux.usurio;
                this.categoria = aux.categoria;
                this.stories = aux.stories;
                this.comentarios = aux.comentarios;
                this.pais = aux.pais;
            }

            return actualizado;
        }

        public bool deleteBlog()
        {
            bool eliminado = false;
            CADBlog blog = new CADBlog();

            if (blog.readBlog(this))
            {
                eliminado = blog.deleteBlog(this);
            }

            return eliminado;
        }

    }
}
