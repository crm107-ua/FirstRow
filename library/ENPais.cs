using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENPais
    {
        private int _id;
        private string _name;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public ENPais()
        {
            id = 0;
            name = "";
        }
        public ENPais(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        /// <summary>
        /// Obtiene una lista de los países en la BD
        /// </summary>
        /// <param name="listaPaises"></param>
        /// <returns>true: si se ha leido correctamente;
        /// false: si no</returns>
        public bool readPaises(List<ENPais> listaPaises)
        {
            CADPaises paises = new CADPaises();
            return paises.readPaises(listaPaises);
        }

        /// <summary>
        /// Lee un país de la BD
        /// </summary>
        /// <returns>true: si se ha leido correctamente;
        /// false: si no</returns>
        public bool ReadPais()
        {
            CADPaises paises = new CADPaises();
            return paises.ReadPais(this);
        }

        /*
        public static int CompareCountriesByName(ENPais x, ENPais y)
        {
            return String.Compare(x.name, y.name);
        }
        */

        /// <summary>
        /// Lee los países de la BD y los devuelve como DataSet
        /// </summary>
        /// <param name="ds"></param>
        /// <returns>true: si se ha leido correctamente;
        /// false: si no</returns>
        public static bool ReadPaisesDataSet(DataSet ds)
        {
            CADPaises paises = new CADPaises();
            return paises.ReadPaisesDataSet(ds);
        }

        /// <summary>
        /// Obtiene una lista de los países con una 
        /// lectura desconectada a la BD
        /// </summary>
        /// <param name="listaPaises"></param>
        /// <returns>true: si se ha leido correctamente;
        /// false: si no</returns>
        public bool getListPaisesDesconectado(List<ENPais> listaPaises)
        {
            CADPaises paises = new CADPaises();
            return paises.getListPaisesDesconectado(listaPaises);
        }


    }
}
