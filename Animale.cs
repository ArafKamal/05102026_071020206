using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05102026_07102026
{
    internal abstract class Animale : IVerso
    {
        private string _nome;
        private int _age;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Animale(string nome, int age)
        {
            _nome = nome;
            _age = age;
        }

        public Animale()
        {
            _nome = "Bob";
            _age = 1;
        }

        public abstract string Verso();
    }
}
