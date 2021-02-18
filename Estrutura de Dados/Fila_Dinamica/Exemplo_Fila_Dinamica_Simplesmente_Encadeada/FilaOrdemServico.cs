using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Fila_Dinamica_Simplesmente_Encadeada
{
    class FilaOrdemServico
    {
        public OrdemServico Head { get; set; }
        public OrdemServico Tail { get; set; }

        public bool Vazia()
        {
            if (Head == null && Tail == null)
            {
                Console.WriteLine("\nA fila esta vazia\n");
                return true;
            }
            return false;
        }

        public void Push(OrdemServico aux)
        {
            if (Vazia())
            {
                Head = aux;
                Tail = aux;
            }
            else
            {
                Tail.Proximo = aux; //Encadeamento da nova ordem de serviço
                Tail = aux; //atualizo o tail               
            }
            Console.WriteLine("\nElemento inserido com sucesso!!!\n");
        }

        public void Imprimir()
        {
            if (Vazia())
            {
                Console.WriteLine("\nA fila esta vazia!!!\n");
            }
            else
            {
               
                OrdemServico aux = Head;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                } while (aux != null);
                Console.WriteLine("----------------------FIM----------------------");                
            }
        }

        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("A fila está vazia!!!\n");
            }
            else
            {
                Head = Head.Proximo;
                if (Head == null)
                {
                    Tail = null;                   
                }
                Console.WriteLine("\nElemento apagado com sucesso!!!\n");
            }
        }



    }
}
