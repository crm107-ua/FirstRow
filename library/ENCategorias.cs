using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENCategorias
    {
        internal int idViaje;
        internal int nombreUsuario;
        internal int TourViaje;
        internal string _Categorianame;
        internal string _desempeño;
        internal string imagenes;

        // ----- Funciones Set-Get ----
        public int id
        {
            get { return idViaje; }
            private set { idViaje = value; }
        }

        public int Ciudad_pais
        {
            get { return Ciudad_pais; }
            private set { idViaje = value; }
        }

        public int Tour_Viaje
        {
            get { return Tour_Viaje; }
            private set { idViaje = value; }
        }

        public ENCategorias()
        {
            Categorianame = "";
            desempeño = "";
            
        }

        public ENCategorias(string Categorianame, string desempeño)
        {
            this.Categorianame = Categorianame;
            this.desempeño = desempeño;
        }

        public string Categorianame
        {
            get { return _Categorianame; }
            set { _Categorianame = value; }
        }

         public string desempeño
        {
            get { return _desempeño; }
            set { _desempeño = value; }
        }


        // CRUD CATEGORIA

        // CREAR CATEGORIA
         public bool registerCategoria()
        {
            CADCategorias categoria = new CADCategorias();
            bool creado = false;
            if (!categoria.readCategoria(this))
            {
                creado = categoria.registerCategoria(this);
            }
            return creado;
        }

        // LEER CATEGORIA
         public bool readCategoria()
        {
            CADCategorias categoria = new CADCategorias();
            bool creado = false;
            if (!categoria.readCategoria(this))
            {
                creado = categoria.readCategoria(this);
            }
            return creado;
        }

       // ACTUALIZAR CATEGORIA
        public bool updateCategoria()
        {
            bool actualizado = false;
            CADCategorias categoria = new CADCategorias();
            ENCategorias aux = new ENCategorias();

            aux.Categorianame= this.Categorianame;
        

            if (categoria.readCategoria(this))
            {
                actualizado = categoria.updateCategoria(aux);
                this.Categorianame= aux.Categorianame;
              
            }

            return actualizado;
        }

       // ELIMIAR CATEGORIA
       public bool deleteCategoria()
        {
            bool eliminado = false;
            CADCategorias categoria = new CADCategorias();

            if (categoria.readCategoria(this))
            {
                eliminado = categoria.deleteCategoria(this);
            }

            return eliminado;
        }

    }

}
