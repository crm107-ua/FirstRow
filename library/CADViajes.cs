using System;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADViajes
    {
        private String constring;

        public CADViajes()
        {
            constring = ConfigurationManager.ConnectionStrings["DataBase"].ToString();
        }

        internal bool addImagen(ENViajes eNViajes)
        {
            throw new NotImplementedException();
        }

        internal bool readImagen(ENViajes eNViajes)
        {
            throw new NotImplementedException();
        }

        internal bool updateImagen(ENViajes eNViajes)
        {
            throw new NotImplementedException();
        }
        internal bool deleteImagen(ENViajes eNViajes)
        {
            throw new NotImplementedException();
        }
        internal bool createIncluido(ENViajes eNViajes)
        {
            throw new NotImplementedException();
        }
        internal bool readIncluido(ENViajes eNViajes)
        {
            throw new NotImplementedException();
        }
        internal bool updateIncluido(ENViajes eNViajes)
        {
            throw new NotImplementedException();
        }
        internal bool deleteIncluido(ENViajes eNViajes)
        {
            throw new NotImplementedException();
        }


    }
}
