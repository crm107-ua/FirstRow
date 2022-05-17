using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENSorteos
    {
        /// <summary>
        /// Identificador
        /// </summary>
        private int _Id;
        /// <summary>
        /// Cantidad monetaria del premio
        /// </summary>
        private ENViajes _Premio;
        /// <summary>
        /// Nombre del sorteo
        /// </summary>
        private string _Nombre;
        /// <summary>
        /// Slug
        /// </summary>
        private int _Slug;
        /// <summary>
        /// Descripcion del sorteo
        /// </summary>
        private string _Descripcion;
        /// <summary>
        /// Imagen del sorteo
        /// </summary>
        private string _Imagen;
        /// <summary>
        /// Inicio del sorteo
        /// </summary>
        private DateTime _FechaInicio;
        /// <summary>
        /// Finalizacion del sorteo
        /// </summary>
        private DateTime _FechaFinal;
        /// <summary>
        /// Array de participantes del sorteo
        /// </summary>
        private ENUsuario[] _Participantes;

        public int Id { get => _Id; set => _Id = value; }
        public ENViajes Premio { get => _Premio; set => _Premio = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int Slug { get => _Slug; set => _Slug = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Imagen { get => _Imagen; set => _Imagen = value; }
        public DateTime FechaInicio { get => _FechaInicio; set => _FechaInicio = value; }
        public DateTime FechaFinal { get => _FechaFinal; set => _FechaFinal = value; }
        public ENUsuario[] Participantes { get => _Participantes; set => _Participantes = value; }
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ENSorteos()
        {
            _Id = 0;
            _Premio = new ENViajes();
            _Nombre = "";
            _Slug = 0;
            _Descripcion = "";
            _Imagen = "";
            _FechaInicio = new DateTime();
            _FechaFinal = new DateTime();
            _Participantes = null;
        }
        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <param name="premio">Premio monetario</param>
        /// <param name="nombre">Nombre del sorteo</param>
        /// <param name="slug">Slug</param>
        /// <param name="descripcion"></param>
        /// <param name="imagen"></param>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaFinal"></param>
        /// <param name="participantes"></param>
        public ENSorteos(int id, ENViajes premio, string nombre, int slug, string descripcion, string imagen, DateTime fechaInicio, DateTime fechaFinal, ENUsuario[] participantes)
        {
            _Id = id;
            _Premio = premio;
            _Nombre = nombre;
            _Slug = slug;
            _Descripcion = descripcion;
            _Imagen = imagen;
            _FechaInicio = fechaInicio;
            _FechaFinal = fechaFinal;
            _Participantes = participantes;
        }
       
        public bool addParticipante()
        {
            CADSorteos par = new CADSorteos();
            bool ok = par.addParticipante(this);
            return ok;
        }
        public bool deleteParticipante()
        {
            CADSorteos par = new CADSorteos();
            bool ok = par.deleteParticipante(this);
            return ok;
        }
        public bool raffle()
        {
            CADSorteos par = new CADSorteos();
            bool ok = par.raffle(this);
            return ok;
        }
        public bool getlistadesconectado(List<ENSorteos> lista)
        {
            CADSorteos sorteos = new CADSorteos();
            return sorteos.getlistadesconectado(lista);
        }
        public bool readsorteo()
        {
            CADSorteos sorteos = new CADSorteos();
            return sorteos.readsorteo(this);
        }
    }
}
