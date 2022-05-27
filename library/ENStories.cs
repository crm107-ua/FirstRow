using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENStories
    {
        //private int _id;
        private string _titulo;
        private string _descripcion;
        private DateTime _fecha;
        private int _pais;
        private ENUsuario _usuario;
        private string _imagen;

        //public int Id { get => _id; set => _id = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public int Pais { get => _pais; set => _pais = value; }
        public ENUsuario Usuario { get => _usuario; set => _usuario = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Imagen { get => _imagen; set => _imagen = value; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ENStories()
        {
            //Id = 0;
            Titulo = "";
            Fecha = new DateTime(); //fecha: 01-01-0001 00:00:00
            Pais = 0; //supongo que el país por defecto es 0, posibles cambios
            Usuario = new ENUsuario();
            Descripcion = "";
            Imagen = "";
        }

        /// <summary>
        /// Constructor con el id especificado
        /// </summary>
        /// <param name="id">El id de la story</param>
        public ENStories(int id)
        {
            //this.Id = id; // Carga de storie en experiencias
            Titulo = "";
            Fecha = new DateTime(); //fecha: 01-01-0001 00:00:00
            Pais = 0; //supongo que el país por defecto es 0, posibles cambios
            Usuario = new ENUsuario();
            Descripcion = "";
            Imagen = "";
        }

        /*
        /// <summary>
        /// Constructor con todos los atributos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="usuario"></param>
        /// <param name="fecha"></param>
        /// <param name="nombre">título</param>
        /// <param name="pais"></param>
        /// <param name="desc">descripción</param>
        /// <param name="img">nombre de la imagen</param>
        public ENStories(int id, ENUsuario usuario, DateTime fecha, string nombre, int pais, string desc, string img)
        {
            this.Id = id;//Tiene que ser un id unico
            this.Titulo = nombre;
            this.Fecha = fecha;
            this.Pais = pais;
            this.Usuario = usuario;
            this.Imagen = img;
            this.Descripcion = desc;
        }
        */

        /// <summary>
        /// Constructor con todos los atributos
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="fecha"></param>
        /// <param name="nombre">título</param>
        /// <param name="pais"></param>
        /// <param name="desc">descripción</param>
        /// <param name="img">nombre de la imagen</param>
        public ENStories(ENUsuario usuario, DateTime fecha, string nombre, int pais, string desc, string img)
        {
            //this.Id = ENStories.GenerateId(fecha, usuario);
            this.Titulo = nombre;
            this.Fecha = fecha;
            this.Pais = pais;
            this.Usuario = usuario;
            this.Imagen = img;
            this.Descripcion = desc;
        }

        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="story">Story origen</param>
        public ENStories(ENStories story)
        {
            //this.Id = story.Id;
            this.Titulo = story.Titulo;
            this.Fecha = story.Fecha;
            this.Pais = story.Pais;
            this.Usuario = story.Usuario;
            this.Imagen = story.Imagen;
            this.Descripcion = story.Descripcion;
        }

        /*
        /// <summary>
        /// genera la Id correspondiente en base a la fecha de publicación
        /// y al usuario que publicó la story
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static int GenerateId(DateTime fecha, ENUsuario usuario)
        {
            return usuario.nickname.GetHashCode() + (int) fecha.Ticks;
        }
        */
        

        /// <summary>
        /// crea una story
        /// </summary>
        /// <returns>true, si se ha creado con exito; 
        /// false, si no se ha creado</returns>
        public bool CreateStory()
        {
            CADStories story = new CADStories();
            bool created = false;

            if (!story.ReadStory(this))
                created = story.CreateStory(this);

            return created;
        }

        /// <summary>
        /// Obtiene los datos de la story que lo llame
        /// </summary>
        /// <returns>true: si existe la story;
        /// false: si no existe</returns>
        public bool ReadStory()
        {
            CADStories story = new CADStories();

            return story.ReadStory(this);
        }

        /*
        /// <summary>
        /// actualiza una story
        /// </summary>
        /// <returns>true: si se ha actualizado con éxito;
        /// false: si no se ha actualizado</returns>
        public bool UpdateStory()
        {
            CADStories story = new CADStories();
            bool updated = false;
            ENStories aux = new ENStories(this);

            if (story.ReadStory(aux))
                updated = story.UpdateStory(this);

            return updated;
        }
        */

        /// <summary>
        /// elimina una story
        /// </summary>
        /// <returns>true: si se ha eliminado con éxito;
        /// false: si no se ha eliminado</returns>
        public bool DeleteStory()
        {
            CADStories story = new CADStories();
            bool deleted = false;

            if (story.ReadStory(this))
                deleted = story.DeleteStory(this);

            return deleted;
        }

        /// <summary>
        /// Obtiene una lista con todas las stories
        /// </summary>
        /// <param name="listStories">lista que se obtiene</param>
        /// <returns>true: si se ha leído con éxito;
        /// false: si no se ha leído</returns>
        public static bool ReadAllStories(List<ENStories> listStories)
        {
            CADStories story = new CADStories();

            if (story.ReadAllStories(listStories))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Obtiene una lista con todas las stories de un país
        /// </summary>
        /// <param name="listStories">lista que se obtiene</param>
        /// <returns>true: si se ha leído con éxito;
        /// false: si no se ha leído</returns>
        public static bool ReadAllStories(List<ENStories> listStories, int pais)
        {
            CADStories story = new CADStories();
            if (story.ReadAllStories(listStories, pais))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Obtiene una lista con todas las stories de un usuario
        /// </summary>
        /// <param name="listStories">lista que se obtiene</param>
        /// <returns>true: si se ha leído con éxito;
        /// false: si no se ha leído</returns>
        public static bool ReadAllStories(List<ENStories> listStories, string user)
        {
            CADStories story = new CADStories();
            if (story.ReadAllStories(listStories, user))
            {
                return true;
            }

            return false;
        }

    }
}
