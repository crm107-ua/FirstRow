using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class CADAdmin
    {
        private String constring;

        public CADAdmin()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        public bool obtenerPlantilla(ENAdmin en)
        {
            bool creado = false;
            return creado;
        }

        public bool crearPlantilla(ENAdmin en)
        {
            bool creado = false;
            return creado;
        }

        public bool modificarPlantilla(ENAdmin en)
        {
            bool modificado = false;
            return modificado;
        }

        public bool eliminarPlantilla(ENAdmin en)
        {
            bool eliminado = false;
            return eliminado;
        }

    }
}
