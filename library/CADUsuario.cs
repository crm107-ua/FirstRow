using System;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADUsuario
    {
        private String constring;

        public CADUsuario()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        public bool registerUsuario(ENUsuario en)
        {
            bool creado = false;
            if(en is ENUsuario)
            {
                // Registro de clientes
            }
            else
            {
                // Registro de empresas
            }
            return creado;
        }

        public bool loginUsuario(ENUsuario en)
        {
            bool creado = false;
            return creado;
        }

        public bool readUsuario(ENUsuario en)
        {
            bool read = false;
            if (en is ENUsuario)
            {
                // Lectura de clientes
            }
            else
            {
                // Lectura de empresas
            }
            return read;
        }

        public bool readUsuarios(ENUsuario en)
        {
            bool read = false;
            if (en is ENUsuario)
            {
                // Lectura de clientes
            }
            else
            {
                // Lectura de empresas
            }
            return read;
        }

        public bool updateUsuario(ENUsuario en)
        {
            bool update = false;
            if (en is ENUsuario)
            {
                // Actualizacion de clientes
            }
            else
            {
                // Actualizacion de empresas
            }
            return update;
        }

        public bool deleteUsuario(ENUsuario en)
        {
            bool delete = false;
            return delete;
        }
    }
}
