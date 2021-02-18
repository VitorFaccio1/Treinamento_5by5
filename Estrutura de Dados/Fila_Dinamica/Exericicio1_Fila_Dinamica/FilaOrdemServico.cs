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
                Console.WriteLine("----------------------FIM----------------------\n");
            }
        }

        public void Pop(int contador)
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
                    contador--;
                }
                Console.WriteLine("\nElemento apagado com sucesso!!!\n");
            }
        }

        public OrdemServico Inserir()
        {

            int numero, prazo;
            string descricao, tipo;

            Console.Write("Informe o id: ");
            numero = int.Parse(Console.ReadLine());

            Console.Write("Informe o tipo do serviço: ");
            tipo = Console.ReadLine();

            Console.Write("Informe a descrição do serviço: ");
            descricao = Console.ReadLine();

            Console.Write("Informe o prazo: ");
            prazo = int.Parse(Console.ReadLine());

            OrdemServico servico = new OrdemServico
            {     
                Numero = numero,
                Tipo = tipo,
                Descricao = descricao,
                Data_Criacao = DateTime.Now,
                Prazo = prazo
            };

            return servico;


        }

        public void Buscar(OrdemServico[] os, int contador, int id)
        {
            bool achou = false;

            for (int i = 0; i < contador; i++)
            {
                if (os[i].Numero == id)
                {
                    Console.WriteLine("\nAchei um serviço com esse ID\n" + os[i] + "\n");
                    achou = true;                   
                }               
            }            
            if (!achou)
            {
                Console.WriteLine("\nNao achei nenhum serviço com essa ID\n");
            }
           
        }

      



    }
}