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

        private int _id;
        private string _imagen_principal;
        private string _titulo;
        private string _descripcion;
        private string _texto_1;
        private string _texto_2;
        private string _texto_3;
        private string _citacion;
        private string _slug;
        private DateTime _fecha;
        private ENPais _pais;
        private ENUsuario _usuario;
        private ENCategorias _categoria;
        private List<ENComentarios> _comentarios;
        private List<ENImagenes> _imagenes;
        public int Id { get => _id; set => _id = value; }
        public string Imagen_principal { get => _imagen_principal; set => _imagen_principal = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Texto_1 { get => _texto_1; set => _texto_1 = value; }
        public string Texto_2 { get => _texto_2; set => _texto_2 = value; }
        public string Texto_3 { get => _texto_3; set => _texto_3 = value; }
        public string Citacion { get => _citacion; set => _citacion = value; }
        public string Slug { get => _slug; set => _slug = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public ENPais Pais { get => _pais; set => _pais = value; }
        public ENUsuario Usuario { get => _usuario; set => _usuario = value; }
        public ENCategorias Categoria { get => _categoria; set => _categoria = value; }
        public List<ENComentarios> Comentarios { get => _comentarios; set => _comentarios = value; }
        public List<ENImagenes> Imagenes { get => _imagenes; set => _imagenes = value; }

        public ENBlog()
        {
            _id = 0;
            _imagen_principal = "";
            _titulo = "";
            _descripcion = "";
            _texto_1 = "";
            _texto_2 = "";
            _texto_3 = "";
            _citacion = "";
            _slug = "";
            _fecha = new DateTime();
            _pais = new ENPais();
            _usuario = new ENUsuario();
            _categoria = new ENCategorias();
            _comentarios = new List<ENComentarios>();
            _imagenes = new List<ENImagenes>();
        }

        public ENBlog(int id, string imagen_principal, string titulo, string descripcion, string texto_1, string texto_2, string texto_3, string citacion, string slug, DateTime fecha, ENPais pais, ENUsuario usuario, ENCategorias categoria, List<ENComentarios> comentarios, List<ENImagenes> imagenes)
        {
            _id = id;
            _imagen_principal = imagen_principal;
            _titulo = titulo;
            _descripcion = descripcion;
            _texto_1 = texto_1;
            _texto_2 = texto_2;
            _texto_3 = texto_3;
            _citacion = citacion;
            _slug = slug;
            _fecha = fecha;
            _pais = pais;
            _usuario = usuario;
            _categoria = categoria;
            _comentarios = comentarios;
            _imagenes = imagenes;
        }

        public bool crearBlog()
        {
            CADBlog blog = new CADBlog();
            return blog.addBlog(this);
        }

        public bool mostrarBlog()
        {
            CADBlog blog = new CADBlog();
            return blog.readBlog(this);
        }

        public bool blogsPorCategoria(List<ENBlog> listaBlogs, int categoria)
        {
            CADBlog blog = new CADBlog();
            return blog.readBlogs(listaBlogs, categoria);
        }

        //public bool updateBlog()
        //{
        //    bool actualizado = false;
        //    CADBlog blog = new CADBlog();
        //    ENBlog aux = new ENBlog();

        //    aux.imagen_principal = this.imagen_principal;
        //    aux.titulo = this.titulo;
        //    aux.descripcion = this.descripcion;
        //    aux.texto_1 = this.texto_1;
        //    aux.texto_2 = this.texto_2;
        //    aux.texto_3 = this.texto_3;
        //    aux.citacion = this.citacion;
        //    aux.imagenes = this.imagenes;
        //    aux.usuario = this.usuario;
        //    aux.categoria = this.categoria;
        //    aux.stories = this.stories;
        //    aux.comentarios = this.comentarios;
        //    aux.pais = this.pais;
        //    aux.slug = generateSlug(this.usuario, this.titulo);

        //    if (blog.readBlog(this))
        //    {
        //        actualizado = blog.updateBlog(aux);
        //        this.titulo = aux.titulo;
        //        this.descripcion = aux.descripcion;
        //        this.texto_1 = aux.texto_1;
        //        this.texto_2 = aux.texto_2;
        //        this.texto_3 = aux.texto_3;
        //        this.citacion = aux.citacion;
        //        this.imagenes = aux.imagenes;
        //        this.usuario = aux.usuario;
        //        this.categoria = aux.categoria;
        //        this.stories = aux.stories;
        //        this.comentarios = aux.comentarios;
        //        this.pais = aux.pais;
        //        this.slug = generateSlug(aux.usuario, aux.titulo);
        //    }

        //    return actualizado;
        //}

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
