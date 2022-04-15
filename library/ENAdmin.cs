using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class ENAdmin
    {
        private const int maxImgHome = 3;
        private string[] _imagenes_home;
        private string _texto_home_1;
        private string _texto_home_2;
        private string _texto_home_3;
        private string _desripcionViajes;
        private string _desripcionStories;
        private string _desripcionSorteos;
        private string _desripcionWearing;
        private string _tituloContacto;
        private string _DescripcionContacto;

        public string[] imagenes_home { get => _imagenes_home; set => _imagenes_home = value; }
        public string texto_home_1 { get => _texto_home_1; set => _texto_home_1 = value; }
        public string texto_home_2 { get => _texto_home_2; set => _texto_home_2 = value; }
        public string texto_home_3 { get => _texto_home_3; set => _texto_home_3 = value; }
        public string desripcionViajes { get => _desripcionViajes; set => _desripcionViajes = value; }
        public string desripcionStories { get => _desripcionStories; set => _desripcionStories = value; }
        public string desripcionSorteos { get => _desripcionSorteos; set => _desripcionSorteos = value; }
        public string desripcionWearing { get => _desripcionWearing; set => _desripcionWearing = value; }
        public string tituloContacto { get => _tituloContacto; set => _tituloContacto = value; }
        public string descripcionContacto { get => _DescripcionContacto; set => _DescripcionContacto = value; }

        public ENAdmin()
        {
            this.imagenes_home = new string[3];
            this.texto_home_1 = "";
            this.texto_home_2 = "";
            this.texto_home_3 = "";
            this.desripcionViajes = "";
            this.desripcionStories = "";
            this.desripcionSorteos = "";
            this.desripcionWearing = "";
            this.tituloContacto = "";
            this.descripcionContacto = "";
        }

        public ENAdmin(string[] imagenes_home, string texto_home_1, string texto_home_2, string texto_home_3, string desripcionViajes, string desripcionStories, string desripcionSorteos, string desripcionWearing, string tituloContacto, string descripcionContacto)
        {
            this.imagenes_home = imagenes_home;
            this.texto_home_1 = texto_home_1;
            this.texto_home_2 = texto_home_2;
            this.texto_home_3 = texto_home_3;
            this.desripcionViajes = desripcionViajes;
            this.desripcionStories = desripcionStories;
            this.desripcionSorteos = desripcionSorteos;
            this.desripcionWearing = desripcionWearing;
            this.tituloContacto = tituloContacto;
            this.descripcionContacto = descripcionContacto;
        }

        public bool setTemplate()
        {
            CADAdmin admin = new CADAdmin();
            bool creado = false;
            if (!admin.obtenerPlantilla(this))
            {
                creado = admin.crearPlantilla(this);
            }
            return creado;
        }

        public bool modifyTemplate()
        {

            bool actualizado = false;
            CADAdmin admin = new CADAdmin();
            ENAdmin aux = new ENAdmin();

            aux.imagenes_home = this.imagenes_home;
            aux.texto_home_1 = this.texto_home_1;
            aux.texto_home_2 = this.texto_home_2;
            aux.texto_home_3 = this.texto_home_3;
            aux.desripcionViajes = this.desripcionViajes;
            aux.desripcionStories = this.desripcionStories;
            aux.desripcionSorteos = this.desripcionSorteos;
            aux.desripcionWearing = this.desripcionWearing;
            aux.tituloContacto = this.tituloContacto;
            aux.descripcionContacto = this.descripcionContacto;

            if (admin.obtenerPlantilla(this))
            {
                actualizado = admin.modificarPlantilla(this);
                this.imagenes_home = aux.imagenes_home;
                this.texto_home_1 = aux.texto_home_1;
                this.texto_home_2 = aux.texto_home_2;
                this.texto_home_3 = aux.texto_home_3;
                this.desripcionViajes = aux.desripcionViajes;
                this.desripcionStories = aux.desripcionStories;
                this.desripcionSorteos = aux.desripcionSorteos;
                this.desripcionWearing = aux.desripcionWearing;
                this.tituloContacto = aux.tituloContacto;
                this.descripcionContacto = aux.descripcionContacto;
            }

            return actualizado;
        }

        public bool deleteTemplate()
        {
            CADAdmin admin = new CADAdmin();
            bool creado = false;
            if (!admin.obtenerPlantilla(this))
            {
                creado = admin.eliminarPlantilla(this);
            }
            return creado;
        }

    }
}
