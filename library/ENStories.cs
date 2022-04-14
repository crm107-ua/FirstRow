using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENStories
    {
        private uint _Id;
        private string _Nombre;
        private DateTime _Fecha;
        private int _Pais;
        private ENUsuario _Usuario;

        public uint Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        public int Pais
        {
            get { return _Pais; }
            set { _Pais = value; }
        }
        public ENUsuario Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        public ENStories()
        {
            Id = 0;
            Nombre = "";
            Fecha = new DateTime(); //fecha: 01-01-0001 00:00:00
            Pais = 0; //supongo que el país por defecto es 0, posibles cambios
            Usuario = new ENUsuario();
        }

        public ENStories(int id, ENUsuario usuario, string nombre, int pais)
        {
            //this.Id = id;//Tiene que ser un id unico, idealmente generado en base a la fecha y el usuario
            this.Nombre = nombre;
            this.Fecha = new DateTime();
            this.Fecha = DateTime.Now; 
            this.Pais = pais;
            this.Usuario = usuario;
            this.Id = uint.Parse(/*usuario.Id.ToString() + */(this.Fecha.Ticks).ToString()); //utilizar también el usuario
        }

        /**
         * crea una story
         * devuelve: true, si se ha creado con exito
         *           false, si no se ha creado
         */
        public bool createStory()
        {
            CADStories story = new CADStories();
            bool created = false;

            if (!story.readStory(this))
                created = story.createStory(this);

            return created;
        }

    }
}
