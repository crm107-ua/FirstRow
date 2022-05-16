using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENEmpresa : ENUsuario
    {
        protected string _cif;
        protected string _direccion;
        protected ENPais _pais;
        protected DateTime _fechaCreacion;

        public string cif
        {
            get { return _cif; }
            set { _cif = value; }
        }

        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public ENPais pais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        public DateTime fechaCreacion
        {
            get { return _fechaCreacion; }
            set { _fechaCreacion = value; }
        }

        public ENEmpresa()
        {
            cif = "";
            direccion = "";
            pais = new ENPais();
            fechaCreacion = new DateTime();
        }

        public ENEmpresa(string cif, String direccion, ENPais pais, DateTime fechaCreacion)
        {
            this.cif = cif;
            this.direccion = direccion;
            this.pais = pais;
            this.fechaCreacion = fechaCreacion;
        }

        public bool registerEmpresa()
        {
            CADEmpresa empresa = new CADEmpresa();
            bool creado = false;
            if (!empresa.readEmpresa(this))
            {
                creado = empresa.registerEmpresa(this);
            }
            return creado;
        }

        public bool loginEmpresa()
        {
            CADEmpresa empresa = new CADEmpresa();
            return empresa.loginEmpresa(this);
        }

        public bool updateEmpresa()
        {
            bool actualizado = false;
            CADEmpresa usuario = new CADEmpresa();
            ENEmpresa aux = new ENEmpresa();

            aux.nickname = this.nickname;
            aux.password = this.password;
            aux.email = this.email;
            aux.image = this.image;
            aux.background_image = this.background_image;
            aux.name = this.name;
            aux.firstname = this.firstname;
            aux.secondname = this.secondname;
            aux.facebook = this.facebook;
            aux.twitter = this.twitter;
            aux.cif = this.cif;
            aux.direccion = this.direccion;
            aux.pais = this.pais;
            aux.fechaCreacion = this.fechaCreacion;

            if (usuario.readEmpresa(this))
            {
                actualizado = usuario.updateEmpresa(aux);
                this.nickname = aux.nickname;
                this.password = aux.password;
                this.image = aux.image;
                this.background_image = aux.background_image;
                this.name = aux.name;
                this.firstname = aux.firstname;
                this.secondname = aux.secondname;
                this.facebook = aux.facebook;
                this.twitter = aux.twitter;
                this.cif = aux.cif;
                this.direccion = aux.direccion;
                this.pais = aux.pais;
                this.fechaCreacion = fechaCreacion;
            }

            return actualizado;
        }

        public bool readEmpresa()
        {
            CADEmpresa empresa = new CADEmpresa();
            return empresa.readEmpresa(this);
        }

        public bool deleteEmpresa()
        {
            bool eliminado = false;
            CADUsuario usuario = new CADUsuario();

            if (usuario.readUsuario(this))
            {
                eliminado = usuario.deleteUsuario(this);
            }

            return eliminado;
        }

    }
}
