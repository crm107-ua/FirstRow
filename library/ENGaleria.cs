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
        private ENPais _pais;
        private string _slug;
        private string _titulo;
        private string _descripcion;
        private List<ENImagenes> _imagenes;
        private ENViajes _viaje;
        public int Id { get => _id; set => _id = value; }
        public ENPais Pais { get => _pais; set => _pais = value; }
        public string Slug { get => _slug; set => _slug = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public List<ENImagenes> Imagenes { get => _imagenes; set => _imagenes = value; }
        public ENViajes Viaje { get => _viaje; set => _viaje = value; }

        public ENGaleria()
        {
            _id = 0;
            _pais = new ENPais();
            _slug = "";
            _titulo = "";
            _descripcion = "";
            _imagenes = new List<ENImagenes>();
            _viaje = new ENViajes();
        }

        public ENGaleria(int id, ENPais pais, string slug, string titulo, string descripcion, List<ENImagenes> imagenes, ENViajes viaje)
        {
            _id = id;
            _pais = pais;
            _slug = slug;
            _titulo = titulo;
            _descripcion = descripcion;
            _imagenes = imagenes;
            _viaje = viaje;
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

        public bool addImage(ENImagenes img) 
        {
            Imagenes.Add(img);
            return true;
        }

        public bool deleteImage(ENImagenes img) 
        {
            Imagenes.Remove(img);
            return true;
        }
        public int GenerateId() 
        {
            return 1;
        }
    }
}
