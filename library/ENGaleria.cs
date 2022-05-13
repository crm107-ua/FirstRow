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
        private ENUsuario _usuario;
        public int Id { get => _id; set => _id = value; }
        public ENPais Pais { get => _pais; set => _pais = value; }
        public string Slug { get => _slug; set => _slug = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public List<ENImagenes> Imagenes { get => _imagenes; set => _imagenes = value; }
        public ENUsuario Usuario { get => _usuario; set => _usuario = value; }

        public ENGaleria()
        {
            Id = 0;
            Pais = new ENPais();
            Slug = "";
            Titulo = "";
            Descripcion = "";
            Imagenes = new List<ENImagenes>();
            Usuario = new ENUsuario();
        }

        public ENGaleria(int id, ENPais pais, string slug, string titulo, string descripcion, List<ENImagenes> imagenes)
        {
            Id = id;
            Pais = pais;
            Slug = slug;
            Titulo = titulo;
            Descripcion = descripcion;
            Imagenes = imagenes;
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
