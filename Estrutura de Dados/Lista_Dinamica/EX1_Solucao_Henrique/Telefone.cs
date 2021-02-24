using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucao_Henrique
{
    public class Telefone
    {
        public int DDD { get; set; }
        public long Numero { get; set; }
        public string Tipo { get; set; }
        public override string ToString()
        {
            return $"DDD: {DDD}\n" +
                $"Numero: {Numero}\n" +
                $"Tipo: {Tipo}";
        }
    }
}
