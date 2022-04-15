using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENEmpresa : ENUsuario
    {
        private int _cif;
        private string _direccion;
        private ENPais _pais;
        private DateTime _fechaCreacion;

        public int cif
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
            cif = 0;
            direccion = "";
            pais = new ENPais();
            fechaCreacion = new DateTime();
        }

        public ENEmpresa(int cif, String direccion, ENPais pais, DateTime fechaCreacion)
        {
            this.cif = cif;
            this.direccion = direccion;
            this.pais = pais;
            this.fechaCreacion = fechaCreacion;
        }

        public bool registerEmpresa()
        {
            CADUsuario usuario = new CADUsuario();
            bool creado = false;
            if (!usuario.readUsuario(this))
            {
                creado = usuario.registerUsuario(this);
            }
            return creado;
        }

        public bool loginEmpresa()
        {
            CADUsuario usuario = new CADUsuario();
            bool creado = false;
            if (!usuario.readUsuario(this))
            {
                creado = usuario.loginUsuario(this);
            }
            return creado;
        }

        public bool updateEmpresa()
        {
            bool actualizado = false;
            CADUsuario usuario = new CADUsuario();
            ENEmpresa aux = new ENEmpresa();

            aux.nickname = this.nickname;
            aux.email = this.email;
            aux.password = this.password;
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

            if (usuario.readUsuario(this))
            {
                actualizado = usuario.updateUsuario(aux);
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
            CADUsuario usuario = new CADUsuario();
            bool creado = false;
            if (!usuario.readUsuario(this))
            {
                creado = usuario.readUsuario(this);
            }
            return creado;
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
