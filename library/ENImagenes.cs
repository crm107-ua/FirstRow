using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENImagenes
    {
        private int _Id;
        private string _Name;
        private int _Mode;

        public int Id { get => _Id; set => _Id = value; }
        public string Name { get => _Name; set => _Name = value; }
        public int Mode { get => _Mode; set => _Mode = value; }

        public ENImagenes()
        {
            Id = 0;
            Name = "";
            Mode = 0;
        }
        public ENImagenes(string name)
        {
            Id = 0;
            Name = name;
            Mode = 0;
        }
        public ENImagenes(int id, string name, int mode)
        {
            Id = id;
            Name = name;
            Mode = mode;
        }
    }
}
