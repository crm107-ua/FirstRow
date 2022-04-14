using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENUsuario
    {

        private string _nickname;
        private string _email;
        private string _password;
        private string _image;
        private string _background_image;
        private string _name;
        private string _firstname;
        private string _secondname;
        private string _facebook;
        private string _twitter;

        public ENUsuario()
        {
            nickname = "";
            email = "";
            password = "";
            image = "";
            background_image = "";
            name = "";
            firstname = "";
            secondname = "";
            facebook = "";
            twitter = "";
        }

        public ENUsuario(string nickname, string email, string password, string image, string background_image, string name, string firstname, string secondname, string facebook, string twitter)
        {
            this.nickname = nickname;
            this.email = email;
            this.password = password;
            this.image = image;
            this.background_image = background_image;
            this.name = name;
            this.firstname = firstname;
            this.secondname = secondname;
            this.facebook = facebook;
            this.twitter = twitter;
        }

        public string nickname
        {
            get { return _nickname;  }
            set { _nickname = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string image
        {
            get { return _image; }
            set { _image = value; }
        }

        public string background_image
        {
            get { return _background_image; }
            set { _background_image = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string secondname
        {
            get { return _secondname; }
            set { _secondname = value; }
        }

        public string facebook
        {
            get { return _facebook; }
            set { _facebook = value; }
        }

        public string twitter
        {
            get { return _twitter; }
            set { _twitter = value; }
        }

        public bool registerUsuario()
        {
            CADUsuario usuario = new CADUsuario();
            bool creado = false;
            if (!usuario.readUsuario(this))
            {
                creado = usuario.registerUsuario(this);
            }
            return creado;
        }

        public bool loginUsuario()
        {
            CADUsuario usuario = new CADUsuario();
            bool creado = false;
            if (!usuario.readUsuario(this))
            {
                creado = usuario.loginUsuario(this);
            }
            return creado;
        }

        public bool updateUsuario()
        {
            bool actualizado = false;
            CADUsuario usuario = new CADUsuario();
            ENUsuario aux = new ENUsuario();

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
            }

            return actualizado;
        }

        public bool readUsuario()
        {
            CADUsuario usuario = new CADUsuario();
            bool creado = false;
            if (!usuario.readUsuario(this))
            {
                creado = usuario.readUsuario(this);
            }
            return creado;
        }

        public bool deleteUsuario()
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
