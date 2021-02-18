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
            Menu();            
            Console.ReadKey();
        }

        static public Livro Inserir()
        {

            int isbn;
            string titulo, autor;


            Console.WriteLine("Informe o titulo do livro: "); titulo = Console.ReadLine();
            Console.WriteLine("Informe o autor do livro: "); autor = Console.ReadLine();
            Console.WriteLine("Informe o isbn do livro: "); isbn = int.Parse(Console.ReadLine());


            Livro book = new Livro
            {
                Titulo = titulo,
                Autor = autor,
                Isbn = isbn,
            };

            return book;
        }

        static public void Menu()
        {
            Pilha_Dinamica_Livro minha_pilha = new Pilha_Dinamica_Livro();
            Livro[] livros = new Livro[5];

            string escolha;

            int contador = 0;
            do
            {
                Console.WriteLine("Informe o que você quer fazer" +
                                  "\n1- Inserir livro " +
                                  "\n2- Remover Livro" +
                                  "\n3- Imprimir pilha" +
                                  "\n4- Quantidade de elementos na pilha" +
                                  "\n5- Busca de livro na pilha por titulo" +
                                  "\n0- Sair ");

                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        {
                            if (contador < livros.Length)
                            {
                                Console.WriteLine("Insira os dados do livro que você quer adcionar");
                                livros[contador] = Inserir();
                                minha_pilha.Push(livros[contador]);
                                contador++;
                            }
                            else
                            {
                                Console.WriteLine("Voce atingiu o numero maximo de livros que podem ser cadastrados!");
                            }
                            break;

                        }
                    case "2":
                        {
                            minha_pilha.Pop();
                            contador--;
                            break;
                        }
                    case "3":
                        {
                            minha_pilha.Imprimir();
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("\nA quantidade de livros é: " + contador + "\n");
                            break;
                        }
                    case "5":
                        {
                            if (contador == 0)
                            {
                                Console.WriteLine("\nNao existe livros cadastrados\n");
                            }
                            else
                            {
                                minha_pilha.Busca(livros, contador);
                            }
                            break;
                        }
                }



            } while (escolha != "0");
        }


    }
}