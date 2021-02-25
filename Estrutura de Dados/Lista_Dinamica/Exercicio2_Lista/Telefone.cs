using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_Lista
{
    class Telefone
    {
        public string DDD { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }

        public override string ToString()
        {
            return $"O DDD:{DDD}\nNumero:{Numero}\nTipo:{Tipo}";
        }
    }
}
