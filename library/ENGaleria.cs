using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENGaleria
    {
        private int _id;
        private string _ciudad;
        private ENPais _pais;
        private string _slug;
        private string _titulo;
        private string _descripcion;
        private List<string> _imagenes;
        private ENViajes _viaje;

        public int id 
        {
            set => _id = value;
            get => _id;
        }
        public string ciudad 
        { 
            set => _ciudad = value;
            get => _ciudad;
        }

        public ENPais pais 
        {
            set => _pais = value;
            get => _pais;
        }

        public string slug
        {
            set => _slug = value;
            get => _slug;
        }

        public string titulo
        {
            set => titulo = value;
            get => _titulo;
        }

        public string descripcion
        {
            set => _descripcion = value;
            get => _descripcion;
        }

        public List<string> imagenes
        {
            set => _imagenes = value;
            get => _imagenes;
        }

        public ENViajes viaje
        {
            set => _viaje = value;
            get => _viaje;
        }

        //Consrtuctor por defecto
        public ENGaleria() 
        {
            id=0;
            ciudad="";
            pais = new ENPais();
            slug="";
            titulo= "";
            descripcion="";
            List<string> imagenes= new List<string>();
            viaje= new ENViajes();
        }

        public ENGaleria(int id, string ciudad, ENPais pais, string slug, string titulo, string descripcion, List<string> imagenes, ENViajes vaije) 
        {
            this.id = id;
            this.ciudad = ciudad;
            this.pais = pais; ;
            this.slug = slug;
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.imagenes = imagenes;
            this.viaje = viaje;
        }

        public bool createGaleria() 
        {
            CADGaleria galeria = new CADGaleria();
            return galeria.createGaleria(this);
        }

        public bool readGaleria() 
        {
            CADGaleria galeria=new CADGaleria();
            return galeria.readGaleria(this);
        }

        public bool deleteGaleria() 
        {
            CADGaleria galeria = new CADGaleria();
            return galeria.deleteGaleria(this);
        }

        public bool updateGaleria() 
        {
            CADGaleria galeria = new CADGaleria();
            return galeria.updateGaleria(this);
        }

        public bool readAllGaleri(List<ENGaleria> lista) {
            CADGaleria galeria = new CADGaleria();
            return galeria.readAllGaleri(lista);
        }

        public bool addImage(string img) 
        {
            imagenes.Add(img);
            return true;
        }

        public bool deleteImage(string img) 
        {
            imagenes.Remove(img);
            return true;
        }
        public int GenerateId() 
        {
            return 1;
        }
        public String GenerateSlug() 
        {
            return pais.name.Trim() + "/" + titulo;
        }
    }
}
