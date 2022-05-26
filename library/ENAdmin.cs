using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENAdmin
    {
        private string _tituloExperiencia;
        private string _descpExpperiencia;
        private string _tituloGaleria;
        private string _descpGaleria;
        private string _tituloStories;
        private string _descpStories;
        private string _tituloBlog;
        private string _decpBlog;
        private string _tituloSorteos;
        private string _descpSorteos;
        private string _contactoTexto1;
        private string _contactoTexto2;

        public string TituloExperiencia { get => _tituloExperiencia; set => _tituloExperiencia = value; }
        public string DescpExpperiencia { get => _descpExpperiencia; set => _descpExpperiencia = value; }
        public string TituloGaleria { get => _tituloGaleria; set => _tituloGaleria = value; }
        public string DescpGaleria { get => _descpGaleria; set => _descpGaleria = value; }
        public string TituloStories { get => _tituloStories; set => _tituloStories = value; }
        public string DescpStories { get => _descpStories; set => _descpStories = value; }
        public string TituloBlog { get => _tituloBlog; set => _tituloBlog = value; }
        public string DecpBlog { get => _decpBlog; set => _decpBlog = value; }
        public string TituloSorteos { get => _tituloSorteos; set => _tituloSorteos = value; }
        public string DescpSorteos { get => _descpSorteos; set => _descpSorteos = value; }
        public string ContactoTexto1 { get => _contactoTexto1; set => _contactoTexto1 = value; }
        public string ContactoTexto2 { get => _contactoTexto2; set => _contactoTexto2 = value; }

        public ENAdmin()
        {
            TituloExperiencia = "";
            DescpExpperiencia = "";
            TituloGaleria = "";
            DescpGaleria = "";
            TituloStories = "";
            DescpStories = "";
            TituloBlog = "";
            DecpBlog = "";
            TituloSorteos = "";
            DescpSorteos = "";
            ContactoTexto1 = "";
            ContactoTexto2 = "";
        }

        public ENAdmin(string tituloExperiencia, string descpExpperiencia, string tituloGaleria, string descpGaleria, string tituloStories , string descpStories, string tituloBlog, string decpBlog , string tituloSorteos, string descpSorteos , string contactoTexto1 , string contactoTexto2)
        {
            TituloExperiencia = tituloExperiencia;
            DescpExpperiencia = descpExpperiencia;
            TituloGaleria = tituloGaleria;
            DescpGaleria = descpGaleria;
            TituloStories = tituloStories;
            DescpStories = descpStories;
            TituloBlog = tituloBlog;
            DecpBlog = decpBlog;
            TituloSorteos = tituloSorteos;
            DescpSorteos = descpSorteos;
            ContactoTexto1 = contactoTexto1;
            ContactoTexto2 = contactoTexto2;
        }

        public bool modify() 
        {
            bool conseguido = false;
            CADAdmin aux = new CADAdmin();
            conseguido = aux.modify(this);
            return conseguido;
        }

        public bool readAll() 
        {
            bool conseguido = false;
            CADAdmin aux = new CADAdmin();
            conseguido=aux.readAll(this);
            return conseguido;
        }

        public static string read(string slug) 
        {
            CADAdmin aux = new CADAdmin();
            return aux.read(slug);
        }

    }
}
