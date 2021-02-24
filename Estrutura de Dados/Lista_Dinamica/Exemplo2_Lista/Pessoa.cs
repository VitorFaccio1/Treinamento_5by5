using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2_Lista
{
    class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public override string ToString()
        {
            return "\n\n" + Nome + "\n" + Idade;
        }
    }
}
