using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucao_Henrique
{
    public class Contato
    {
        public string Nome { get; set; }
        public Telefone[] Telefones { get; set; }
        public Contato Proximo { get; set; }

        public override string ToString()
        {
            string telefones = "";
            foreach (Telefone t in Telefones)
                telefones += t.ToString()+"\n";
            return ">>> DADOS DO CONTATO <<<" +                
                "Nome: " + Nome + "\n" +
                "Telefones: " + telefones + "\n";
                ;
        }
    }

}
