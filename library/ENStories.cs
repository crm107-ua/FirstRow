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
        private string _nombre;
        private DateTime _Fecha;
        private string _slug;
        private int _pais;
        private ENUsuario _usuario;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public int Pais { get => _pais; set => _pais = value; }
        public ENUsuario Usuario { get => _usuario; set => _usuario = value; }
        public string Slug { get => _slug; set => _slug = value; }

        public ENStories()
        {
            Id = 0;
            Nombre = "";
            Fecha = new DateTime(); //fecha: 01-01-0001 00:00:00
            Pais = 0; //supongo que el país por defecto es 0, posibles cambios
            Usuario = new ENUsuario();
            Slug = "";
        }

        public ENStories(int id, ENUsuario usuario, DateTime fecha, string nombre, int pais)
        {
            this.Id = id;//Tiene que ser un id unico
            this.Nombre = nombre;
            this.Fecha = fecha;
            this.Pais = pais;
            this.Usuario = usuario;
            this.Slug = "";//TODO
        }

        public ENStories(ENUsuario usuario, DateTime fecha, string nombre, int pais)
        {
            this.Id = ENStories.GenerateId(fecha, usuario);
            this.Nombre = nombre;
            this.Fecha = fecha;
            this.Pais = pais;
            this.Usuario = usuario;
            this.Slug = "";//TODO
        }

        public ENStories(ENStories story)
        {
            this.Id = story.Id;
            this.Nombre = story.Nombre;
            this.Fecha = story.Fecha;
            this.Pais = story.Pais;
            this.Usuario = story.Usuario;
            this.Slug = story.Slug;
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
            bool correctRead = story.ReadStory(this);

            return correctRead;
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

    }
}
