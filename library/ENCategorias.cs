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

        public static string Titulo; //CRUD

        public static string desempeño; //CRUD

        public static string imagenes; //Add-Delete


    }
}
