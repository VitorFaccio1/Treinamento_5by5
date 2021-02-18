using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Fila_Dinamica_Simplesmente_Encadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();
        }

        

        static public void Menu()
        {
            FilaOrdemServico filaos = new FilaOrdemServico();
            OrdemServico[] os = new OrdemServico[5];

            string escolha;
            int contador = 0;

            do
            {
                Console.WriteLine("Informe o que você quer fazer" +
                                      "\n1- Inserir serviços " +
                                      "\n2- Remover serviços" +
                                      "\n3- Imprimir serviços" +
                                      "\n4- Quantidade de elementos na fila" +
                                      "\n5- Busca de serivço na fila por ID" +
                                      "\n0- Sair "); escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        {
                            Console.WriteLine("\nInsira os dados do serviço que você quer adcionar: ");
                            os[contador] = filaos.Inserir();
                            filaos.Push(os[contador]);
                            contador++;
                            break;
                        }
                    case "2":
                        {
                            filaos.Pop(contador);                            
                            break;
                        }
                    case "3":
                        {
                            filaos.Imprimir();                       
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("\nA quantidade de serviços que ta na fila é: " + contador + "\n");
                            break;
                        }
                    case "5":
                        {
                            int id;
                            
                            if (!filaos.Vazia())
                            {
                                Console.WriteLine("Qual o numero do elemento na lista");
                                id = int.Parse(Console.ReadLine());
                                filaos.Buscar(os, contador, id);
                            }
                            else
                            {
                                Console.WriteLine("\nInsira um serviço antes de procurar por algum!\n");
                            }
                            
                            break;
                        }
                }

            } while (escolha != "0");
        }


    }
}