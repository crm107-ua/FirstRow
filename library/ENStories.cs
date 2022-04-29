using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENStories
    {
        private int _id;
        private string _titulo;
        private string _descripcion;
        private DateTime _fecha;
        private int _pais;
        private ENUsuario _usuario;
        private string _imagen;
        private string _slug;

        public int Id { get => _id; set => _id = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public int Pais { get => _pais; set => _pais = value; }
        public ENUsuario Usuario { get => _usuario; set => _usuario = value; }
        public string slug { get => _slug; set => _slug = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Imagen { get => _imagen; set => _imagen = value; }

        public ENStories()
        {
            Id = 0;
            Titulo = "";
            Fecha = new DateTime(); //fecha: 01-01-0001 00:00:00
            Pais = 0; //supongo que el país por defecto es 0, posibles cambios
            Usuario = new ENUsuario();
            Descripcion = "";
            Imagen = "";
            slug = "";
        }

        public ENStories(int id, ENUsuario usuario, DateTime fecha, string nombre, int pais, string desc, string img)
        {
            this.Id = id;//Tiene que ser un id unico
            this.Titulo = nombre;
            this.Fecha = fecha;
            this.Pais = pais;
            this.Usuario = usuario;
            this.slug = usuario.nickname + "-" + fecha.ToString();//TODO ¿?
            this.Imagen = img;
            this.Descripcion = desc;
        }

        public ENStories(ENUsuario usuario, DateTime fecha, string nombre, int pais, string desc, string img)
        {
            this.Id = ENStories.GenerateId(fecha, usuario);
            this.Titulo = nombre;
            this.Fecha = fecha;
            this.Pais = pais;
            this.Usuario = usuario;
            this.slug = usuario.nickname + "-" + fecha.ToString();//TODO ¿?
            this.Imagen = img;
            this.Descripcion = desc;
        }

        public ENStories(ENStories story)
        {
            this.Id = story.Id;
            this.Titulo = story.Titulo;
            this.Fecha = story.Fecha;
            this.Pais = story.Pais;
            this.Usuario = story.Usuario;
            this.slug = story.slug;
            this.Imagen = story.Imagen;
            this.Descripcion = story.Descripcion;
        }

        /**
         * genera la Id correspondiente en base a la fecha de publicación
         * y al usuario que publicó la story
         */
        static int GenerateId(DateTime fecha, ENUsuario usuario)
        {
            return usuario.nickname.GetHashCode() + (int) fecha.Ticks;
        }

        /**
         * crea una story
         * devuelve: true, si se ha creado con exito
         *           false, si no se ha creado
         */
        public bool CreateStory()
        {
            CADStories story = new CADStories();
            bool created = false;

            if (!story.ReadStory(this))
                created = story.CreateStory(this);

            return created;
        }

        /**
         * Obtiene los datos de la story que lo llame
         */
        public bool ReadStory()
        {
            CADStories story = new CADStories();

            return story.ReadStory(this);
        }

        /**
         * Obtiene la primera story del país, o de todos si no se especifica
         */
        public bool ReadFirstStory()
        {
            CADStories story = new CADStories();

            return story.ReadFirstStory(this);
        }

        /**
         * actualiza una story
         */
        public bool UpdateStory()
        {
            CADStories story = new CADStories();
            bool updated = false;
            ENStories aux = new ENStories(this);

            if (story.ReadStory(aux))
                updated = story.UpdateStory(this);

            return updated;
        }

        /**
         * elimina una story
         */
        public bool DeleteStory()
        {
            CADStories story = new CADStories();
            bool deleted = false;

            if (story.ReadStory(this))
                deleted = story.DeleteStory(this);

            return deleted;
        }

        public static bool ReadAllStories(List<ENStories> listStories)
        {
            CADStories story = new CADStories();
            bool correctRead = false;
            if (story.ReadAllStories(listStories))
            {
                correctRead = true;
            }

            return correctRead;
        }

    }
}
