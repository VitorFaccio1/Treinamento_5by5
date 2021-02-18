using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_Dinamica_Simplesmente_Encadeada
{
    class Pilha_Dinamica_Livro
    {
        public Livro Topo { get; set; }
        //pop voce remove e push voce adciona!

        public void Push(Livro aux)
        {
            aux.anterior = Topo;
            Topo = aux;
            Console.WriteLine("\nElemento inserido com sucesso!\n");
            return;
        }

        private bool Vazia()
        {
            if (Topo == null)
                return true;
            return false;
        }     

        public void Imprimir()
        {
            if (Vazia())
            {
                Console.WriteLine("\nA pilha está vazia! Impossivel imprimir!\n");
            }
            else
            {
                Livro aux = Topo;
                Console.WriteLine("\nOs elementos na pilha são: ");
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.anterior;
                } while (aux != null);
                Console.WriteLine(">>>FIM<<<\n");
            }
        }

        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("\nImpossivel Remover! Pilha vazia!\n");
            }
            else
            {
                Topo = Topo.anterior;
                Console.WriteLine("Elemento removido!");
            }
        }

        public void Busca(Livro[] livros, int contador)
        {
            bool achou = true;
            string titulo;
            Console.WriteLine("Qual titulo você quer buscar: ");
            titulo = Console.ReadLine().Trim(' ').ToLower();

            for (int i = 0; i < contador; i++)
            {
                if(livros[i].Titulo == titulo)
                {
                    Console.WriteLine("\nTem esse livro! E ele esta na posição: " + i + "\n");
                    achou = false;
                }               
            }         
            if (achou)
            {
                Console.WriteLine("\nNao temos esse livro\n");
            }
            return;
        }


    }
}