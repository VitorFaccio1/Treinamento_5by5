using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Dinamica_Simplesmente_Encadeada
{
    class Pessoa
    {
        public Telefone[] telefone { get; set; }
        public string Nome { get; set; }
        public Pessoa Proximo { get; set; }

        public override string ToString()
        {
            return $"------DADOS DO CONTATO------\n" +
                $"Nome: {Nome}" +
                $"telefone: {telefone} ";
        }
    }
}
