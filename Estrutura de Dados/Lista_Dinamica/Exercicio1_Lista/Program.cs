using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PListaDinSimEnc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ListaContatos meus_contatos = new ListaContatos { Head = null, Tail = null };

            Menu_Principal();
            
            Console.ReadKey();
        }

        static void Menu_Principal()
        {
            ListaContatos meus_contatos = new ListaContatos { Head = null, Tail = null };
            Pessoa p = new Pessoa();
            string escolha;
            int contador = 0;
            do
            {
                Console.WriteLine("\nInsira o que voce quer fazer?\n" +
                    "1)Inserir\n" +
                    "2)Remover\n" +
                    "3)Localizar\n" +
                    "4)Imprimir contatos\n" +
                    "5)Imprimir SOMENTE um contato\n" +
                    "6)Quantidade de contatos\n" +
                    "0)SAIR\n");
                escolha = Console.ReadLine();

                switch (escolha)
                { 
                    case "1":                        
                        meus_contatos.Push(Contato_inserir());
                        contador++;
                        break;

                    case "2":                        
                        if (meus_contatos.Vazia())
                        {
                            Console.WriteLine("\nSua lista ta vazia\n");
                        }
                        else
                        {
                            string nome;
                            Console.WriteLine("Informe o nome que voce quer exlucir");
                            nome = Console.ReadLine();
                            meus_contatos.Pop(nome);
                            contador--;
                        }

                        
                        break;

                    case "3":
                        if (meus_contatos.Vazia())
                        {
                            Console.WriteLine("\nInsira um contato antes de procurar!\n");
                        }
                        else
                        {
                            string nome;
                            Console.WriteLine("\nQual nome do contato que voce quer buscar: ");
                            nome = Console.ReadLine();
                            meus_contatos.Localizar(ref nome);                            
                           
                        }
                        break;

                    case "4":
                        meus_contatos.Print();
                        break;

                    case "5":
                        if (meus_contatos.Vazia())
                        {
                            Console.WriteLine("\nInsira um contato antes de imprimir\n");
                        }
                        else
                        {
                            meus_contatos.Imprimir_Contato_1por1(p);
                        }                                            
                        break;

                    case "6":
                        Console.WriteLine("Você tem " + contador + " contatos");
                        break;

                }
            } while (escolha != "0");
        }

        static Pessoa Contato_inserir()
        {
            string nome, tipo;
            int ddd;
            long numero;
            long[] phone = new long[10];

            Console.WriteLine("Informe o nome do contato: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe o tipo do contato: ");
            tipo = Console.ReadLine();

            Console.WriteLine("Informe o DDD do contato: ");
            ddd = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o numero do contato: ");
            numero = long.Parse(Console.ReadLine());


            Pessoa lista = new Pessoa
            {
                Nome = nome,
                telefone = new Telefone[]
                {
                   new Telefone
                   {
                       DDD = ddd,
                       Numero = numero,
                       Tipo = tipo
                   }
                }
            };

            return lista;
        }
    }
}
