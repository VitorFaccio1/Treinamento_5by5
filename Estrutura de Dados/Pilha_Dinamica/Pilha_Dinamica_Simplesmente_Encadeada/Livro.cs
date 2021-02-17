using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_Dinamica_Simplesmente_Encadeada
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Isbn { get; set; }

        public Livro anterior { get; set; }

        public override string ToString()
        {
            return "\n>>>>DADOS DO LIVRO<<<<\n" +
                    $"Titulo: {Titulo}\n" +
                    $"Autor: {Autor}\n" +
                    $"Isbn: {Isbn}";
        }

    }
}
