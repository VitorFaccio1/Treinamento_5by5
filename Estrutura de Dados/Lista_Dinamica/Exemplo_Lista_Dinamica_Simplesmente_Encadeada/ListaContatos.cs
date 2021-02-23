using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PListaDinSimEnc
{
    class ListaContatos
    {
        public Pessoa Head { get; set; }
        public Pessoa Tail { get; set; }

        public bool Vazia()
        {
            if ((Head == null) && (Tail == null))
                return true;
            return false;
        }

        public void Push(Pessoa aux)
        {
            if (Vazia())
            {
                Head = aux;
                Tail = aux;
                Console.WriteLine("Inseriu com Lista Vazia!");
            }
            else
            {
                if (aux.Nome.CompareTo(Tail.Nome) >= 0) // Inserir novo "último" elemento
                {
                    Tail.Proximo = aux;
                    Tail = aux;
                    Console.WriteLine("Inseriu no Final da lista!");
                }
                else
                {
                    if (aux.Nome.CompareTo(Head.Nome) < 0)// Inserir novo "primeiro" elemento
                    {
                        aux.Proximo = Head;
                        Head = aux;
                        Console.WriteLine("Inseriu no Inicio da lista!");
                    }
                    else // Inserir no "meio" da Lista
                    {
                        Pessoa aux1 = Head;
                        do
                        {
                            if (aux.Nome.CompareTo(aux1.Proximo.Nome) < 0)
                            {
                                aux.Proximo = aux1.Proximo;
                                aux1.Proximo = aux;
                                Console.WriteLine("Inseriu no \"meio\" da lista!");
                                break;
                            }
                            aux1 = aux1.Proximo;
                        } while (true);
                    }
                }
            }
        }

        public void Print()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível Imprimir! Lista vazia!");
                Console.ReadKey();
            }
            else
            {
                Pessoa aux = Head;
                Console.WriteLine("\n>>> CONTATOS NA LISTA <<<\n");
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                } while (aux != null);
                Console.WriteLine("\n>>> FIM <<<");
            }
        }
    }
}
