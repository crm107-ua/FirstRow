using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENWearing
    {
        private int _Id;
        private string _Descripcion;
        private string _Slug;
        private List<string> _Imagenes;
        private ENViajes _Viaje;
        private string _Texto;

        public int Id { get => _Id; set => _Id = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string slug { get => _Slug; set => _Slug = value; }
        public List<string> Imagenes { get => _Imagenes; set => _Imagenes = value; }
        public ENViajes Viaje { get => _Viaje; set => _Viaje = value; }
        public string Texto { get => _Texto; set => _Texto = value; }


        public ENWearing()
        {
            Id = 0;
            Descripcion = "";
            slug = "";
            Imagenes = new List<string>();
            Viaje = new ENViajes();
            Texto = "";
        }

        public ENWearing(string desc, List<string> imgs, ENViajes viaje, string texto)
        {
            this.Id = viaje.GetHashCode(); //posible forma de generarlo, hay que sobrescribirlo
            this.Descripcion = desc;
            this.slug = "";//TODO
            this.Imagenes = imgs;
            this.Viaje = viaje;
            this.Texto = texto;
        }

        public ENWearing(ENWearing wearing)
        {
            this.Id = wearing.Id;
            this.Descripcion = wearing.Descripcion;
            this.slug = wearing.slug;
            this.Imagenes = wearing.Imagenes;
            this.Viaje = wearing.Viaje;
            this.Texto = wearing.Texto;
        }

        /**
         * crea un wearing
         * devuelve: true, si se ha creado con exito
         *           false, si no se ha creado
         */
        public bool CreateWearing()
        {
            CADWearing wearing = new CADWearing();
            bool created = false;

            if (!wearing.ReadWearing(this))
                created = wearing.CreateWearing(this);

            return created;
        }

        /**
         * Obtiene los datos del wearing que lo llame
         */
        public bool ReadWearing()
        {
            CADWearing wearing = new CADWearing();
            bool correctRead = wearing.ReadWearing(this);

            return correctRead;
        }

        /**
         * actualiza un wearing
         */
        public bool UpdateWearing()
        {
            CADWearing wearing = new CADWearing();
            bool updated = false;
            ENWearing aux = new ENWearing(this);

            if (wearing.ReadWearing(aux))
                updated = wearing.UpdateWearing(this);

            return updated;
        }

        /**
         * elimina un wearing
         */
        public bool DeleteWearing()
        {
            CADWearing wearing = new CADWearing();
            bool deleted = false;

            if (wearing.ReadWearing(this))
                deleted = wearing.DeleteWearing(this);

            return deleted;
        }

        public void AgregarImagen(string imagen)
        {
            this.Imagenes.Add(imagen);//??
        }
    }
}
