using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENReserva
    {
        private int _id;
        private string _nombre; //nombre del usuario
        private string _descripcion;
<<<<<<< HEAD
        private ENUsuario _usuario;
=======
        private ENUsuario _usuario; 
>>>>>>> 54207285B CADReserva y ENReserva listos para implementarse en la bd
        private int _telefono;
        private int _personas;

        private ENViajes _experiencia;
        private DateTime _fechaEntrada;
        private DateTime _fechaSalida;
        private double _precio;


        public DateTime fechaEntrada{
            get { return _fechaEntrada; }
            set { _fechaEntrada = value; }
        }
        public DateTime fechaSalida
        {

            get { return _fechaSalida; }
            set { _fechaSalida = value; }

        }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public int personas
        {
            get { return _personas; }
            set { _personas = value; }
        }
        public double precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public ENUsuario usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public ENViajes experiencia
        {
            get { return _experiencia; }
            set { _experiencia = value; }
        }

<<<<<<< HEAD
        public ENReserva() 
=======
        public ENReserva()
>>>>>>> 54207285B CADReserva y ENReserva listos para implementarse en la bd
        {
            this.id = 0;
            this.telefono = 0;
            this.personas = 0;
            this.precio = 0;
<<<<<<< HEAD
            this.descripcion = descripcion;
=======
            this.nombre = "";
            this.descripcion =  "";
>>>>>>> 54207285B CADReserva y ENReserva listos para implementarse en la bd
            this.usuario = new ENUsuario();
            this.experiencia = new ENViajes();
            this.fechaEntrada = new DateTime();
            this.fechaSalida = new DateTime();
<<<<<<< HEAD
        }

        public ENReserva(int id, int telefono, int personas, double precio, string descripcion, ENUsuario usuario, ENViajes experiencia, DateTime fechaEntrada, DateTime fechaSalida)
=======


        }

        public ENReserva(int id, int telefono, int personas, int precio,  string descripcion, ENUsuario usuario, ENViajes experiencia, DateTime fechaEntrada, DateTime fechaSalida)
>>>>>>> 54207285B CADReserva y ENReserva listos para implementarse en la bd
        {
            this.id = id;
            this.telefono = telefono;
            this.personas = personas;
            this.precio = precio;
<<<<<<< HEAD
=======
            this.nombre = usuario.name;
>>>>>>> 54207285B CADReserva y ENReserva listos para implementarse en la bd
            this.descripcion = descripcion;
            this.usuario = usuario;
            this.experiencia = experiencia;
            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;
        }

        public DataSet readReservas()
        {
            CADReserva reservas = new CADReserva();
            return reservas.readReservas();
        }

        public bool readReserva(bool mode)
        {
            CADReserva categoria = new CADReserva();
            return categoria.readReserva(this, mode);
        }

        public bool registerReserva()
        {
            CADReserva categoria = new CADReserva();
            bool creado = false;
            if (!categoria.readReserva(this, true))
            {
                creado = categoria.registerReserva(this);
            }
            return creado;
        }

        public bool deleteReserva()
        {
            bool eliminado = false;
            CADReserva categoria = new CADReserva();

            if (!categoria.readReserva(this, true))
            {
                eliminado = categoria.deleteReserva(this);
            }

            return eliminado;
        }


    }
}
