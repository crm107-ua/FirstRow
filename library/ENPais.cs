using System;
using System.Collections.Generic;
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

        public List<ENPais> readPaises(List<ENPais> listaPaises)
        {
            CADPaises paises = new CADPaises();
            return paises.readPaises(listaPaises);
        }

    }
}
