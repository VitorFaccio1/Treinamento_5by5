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
        #region teste
        /*public void Pop(Pessoa aux, ref string nome_exlcui)
        {
            /*if (Vazia())
            {
                Console.WriteLine("\nImpossivel remover! Lista está vazia!\n");                          
            }
            
            if(!Vazia())
            {
                string resposta;

                Localizar(ref nome_exlcui);

                Console.WriteLine("\nVoce deseja excluir esse contato? Sim (S) Nao(N)");
                resposta = Console.ReadLine().ToLower();

                if(resposta == "s")
                {
                    
                }
                
            }
        }*/
        #endregion
        public void Pop(string nome)
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível remover, lista vazia!");
            }
            else
            {
                Pessoa aux1 = Head;
                if (nome == aux1.Nome)
                {
                    if (Head.Proximo != null)
                    {                       
                        Head = Head.Proximo;
                    }
                    else
                    {
                        Head = null;
                        Tail = null;
                    }
                }
                else
                {
                    while (aux1.Proximo != null)
                    {
                        if (aux1.Proximo.Nome == nome)
                        {
                            if (aux1.Proximo != Tail)
                            {
                                aux1.Proximo = aux1.Proximo.Proximo;
                                break;
                            }
                            else if (aux1.Proximo == Tail)
                            {
                                aux1.Proximo = null;
                                break;
                            }
                        }
                        aux1 = aux1.Proximo;
                    }
                }

            }
        }
        public void Localizar(ref string nome)
        {
            bool achou = false;
            for (int i = 0; i < 10; i++)
            {
                if (nome.ToLower() == Head.Nome.ToLower())
                {
                    achou = true;
                }
                else
                {
                    Head = Head.Proximo;
                }

                if (Head == null)
                {
                    break;
                }
            }
            if (achou)
            {
                Console.WriteLine("\nvoce tem contato com esse nome\n" + Head.ToString());
            }
            else
                Console.WriteLine("\nVoce nao tem contato com esse nome\n");


            return;
        }
        public void Imprimir_Contato_1por1(Pessoa aux)
        {
            string resposta;

            aux = Head;

            Console.WriteLine(aux);
            do
            {
                Console.WriteLine("Quer continuar S ou N?\n");
                resposta = Console.ReadLine().ToLower();
                if (aux.Proximo == null)
                {
                    Console.WriteLine("\nSua lista acabou!\n");
                    break;
                }
                if (resposta == "S".ToLower())
                {
                    aux = aux.Proximo;
                    Console.WriteLine(aux);
                }

            } while (resposta != "N".ToLower());
            return;
        }




    }
}
