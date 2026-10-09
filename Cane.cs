using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05102026_07102026
{
    internal class Cane : Animale
    {
        public Cane(string nome, int age) : base(nome, age)
        {
        }

        public override string Verso()
        {
            return "Bau";
        }
    }
}
