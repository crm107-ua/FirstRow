using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADGaleria
    {
        private String constring;

        public CADGaleria()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        public bool createGaleria(ENGaleria galeria) 
        {
            bool consegido=false;
            CADGaleria aux = new CADGaleria();

            if (!aux.readGaleria(galeria)) 
            {
                //Se inserta en la base de datos
                consegido= true;
            }

            return consegido;
        }

        public bool readGaleria(ENGaleria galeria) 
        {
            //Buscar en la BDD
            return false;
        }

        public bool deleteGaleria(ENGaleria galeria) 
        {
            bool consegido = false;
            CADGaleria aux = new CADGaleria();

            if (!aux.readGaleria(galeria))
            {
                //Se Borra en la base de datos
                consegido = true;
            }

            return consegido;
        }

        public bool updateGaleria(ENGaleria galeria) 
        {
            bool consegido = false;

            if (!this.readGaleria(galeria))
            {
                //Se modifica solo el titulo ciudad y descripcion en la base de datos
                consegido = true;
            }

            return consegido;
        }

        public bool readAllGaleri(List <ENGaleria> lista) 
        {
            bool conseguido = false;

            //Si hay alguna galeria
            if (true) { }

            return conseguido;
        }


    }
}
