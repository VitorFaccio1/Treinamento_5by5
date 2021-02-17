using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_Dinamica_Simplesmente_Encadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha_Dinamica_Livro minha_pilha = new Pilha_Dinamica_Livro();

            minha_pilha.Imprimir();
            Console.ReadKey();

            Livro book = new Livro
            {
                Titulo = "Segredos da mente milionaria",
                Autor = "T. Harv Eker",
                Isbn = 1234567,
                anterior = null
            };

            minha_pilha.Push(book);

            minha_pilha.Push(new Livro { 
            Titulo = "Seja Foda!",
            Autor = "Caio Carneiro",
            Isbn = 123456
            });            

            minha_pilha.Imprimir();
            minha_pilha.Pop();
            minha_pilha.Imprimir();
            minha_pilha.Pop();
            minha_pilha.Imprimir();
            minha_pilha.Pop();
            Console.ReadKey();
        }
    }
}
