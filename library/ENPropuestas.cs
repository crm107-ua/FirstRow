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
        private string _Descripcion;
        private string _Imagen;
        internal object id;
        internal object descripcion;
        internal object titulo;
        internal object texto;

        public int Id //GET-SET
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public string Imagen //GET-SET
        {
            get { return _Imagen; }
            set { _Imagen = value; }
        }

        public ENPropuestas()
        {
            this.Id = 0;
            this.Descripcion = "";
            this.Imagen = "";

        }

        public ENPropuestas(int Id, string descripcion, string Imagen)
        {
            this.Id = Id;
            this.Descripcion = descripcion;
            this.Imagen = Imagen;

        }

        public DataSet readPropuestas()
        {
            CADPropuestas propuesta = new CADPropuestas();
            return propuesta.readPropuestas();
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
    }
}
