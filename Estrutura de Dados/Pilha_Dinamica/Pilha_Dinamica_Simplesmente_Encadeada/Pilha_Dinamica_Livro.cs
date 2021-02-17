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
            /* if (vazia()) //Verifica se a pilha esta vazia!
             {
                 Topo = aux;
             }
             *///else
               //{
            aux.anterior = Topo;
            Topo = aux;
            //}
            Console.WriteLine("Elemento inserido com sucesso!");
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
                Console.WriteLine("A pilha está vazia! Impossivel imprimir!");
                Console.ReadKey();
            }
            else
            {
                Livro aux = Topo;
                Console.WriteLine("\nOs elementos na pilha são: ");
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.anterior;
                } while (aux!= null);
                Console.WriteLine(">>>FIM<<<");
            }
        }

        public void Pop ()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossivel Remover! Pilha vazia!");
                Console.ReadKey();
            }
            else
            {
                Topo = Topo.anterior;
                Console.WriteLine("Elemento removido!");
            }
        }

    }
}
