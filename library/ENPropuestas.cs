using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENPropuestas
    {
        private int _Id;
        private string _Titulo;
        private string _Descripcion;
        private ENUsuario _usuario;
        private ENEmpresa _empresa;
        private string _slug;
        private ENImagenes _imagenes;

        public int Id //GET-SET
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        public ENUsuario Usuario { get => _usuario; set => _usuario = value; }
        public ENEmpresa Empresa { get => _empresa; set => _empresa = value; }
        public string Slug { get => _slug; set => _slug = value; }
        public ENImagenes Imagenes { get => _imagenes; set => _imagenes = value; }

        public ENPropuestas()
        {
            this.Id = 0;
            this.Titulo = "";
            this.Descripcion = "";
            this.Imagenes = new ENImagenes();
            this.Usuario = new ENUsuario();
            this.Empresa = new ENEmpresa();
            this.Slug = "";

        }

        public ENPropuestas(int Id, string Titulo, string descripcion, ENImagenes imagen, string slug, ENEmpresa empresa, ENUsuario usuario)
        {
            this.Id = Id;
            this.Titulo = Titulo;
            this.Descripcion = descripcion;
            this.Imagenes = imagen;
            this.Slug = slug;
            this.Empresa = empresa;
            this.Usuario = usuario;
        }


        public DataSet readPropuestas()
        {
            CADPropuestas propuesta = new CADPropuestas();
            return propuesta.readPropuestas();
        }


        public bool newPropuesta()
        {
            CADPropuestas propuesta = new CADPropuestas();
            bool creado = false;
            if (!propuesta.readPropuestas(this, true))
            {
                creado = propuesta.newPropuesta(this);
            }
            return creado;
        }


        public bool deletePropuesta()
        {
            bool eliminado = false;
            CADPropuestas propuesta = new CADPropuestas();

            if (!propuesta.readPropuestas(this, true))
            {


                eliminado = propuesta.deletePropuesta(this);
            }

            return eliminado;
        }
        public bool readpropuestasconectado(List<ENPropuestas> lista)
        {
            CADPropuestas propuestas = new CADPropuestas();
            return propuestas.readpropuestasconectado(lista);
        }
    }
}