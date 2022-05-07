using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENCategorias
    {
        private int _id;
        private string _nombre;
        private string _descripcion;
        private string _slug;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public string slug
        {
            get { return _slug; }
            set { _slug = value; }
        }

        public ENCategorias()
        {
            id = 0;
            nombre = "";
            descripcion = "";

        }

        public ENCategorias(int id, string nombre, string descripcion, string slug)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.slug = slug;
        }

        public DataSet readCategorias()
        {
            CADCategorias categorias = new CADCategorias();
            return categorias.readCategorias();
        }

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

            aux.id = this.id;
            aux.nombre = this.nombre;
            aux.descripcion = this.descripcion;


            if (categoria.readCategoria(this))
            {
                actualizado = categoria.updateCategoria(aux);
                this.id = aux.id;
                this.nombre = aux.nombre;
                this.descripcion = aux.descripcion;
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