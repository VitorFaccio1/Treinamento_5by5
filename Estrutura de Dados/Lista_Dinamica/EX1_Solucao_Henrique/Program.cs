using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucao_Henrique
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaContatos meusContatos = new ListaContatos();
            string escolha;
            string nome = "";
            do
            {

                Console.WriteLine("Insira o que voce quer fazer?\n" +
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
                        Contato contato = InserirContato();
                        meusContatos.Inserir(contato);
                        break;

                    case "2":
                        Console.WriteLine("Informe o nome do contato que você quer excluir");
                        nome = Console.ReadLine();
                        meusContatos.Remover(nome);
                        break;

                    case "3":
                        if (meusContatos.EhVazia)
                        {
                            Console.WriteLine("\nInsira alguem na lista primeiro para depois procurar\n");
                        }
                        else
                        {
                            Console.WriteLine("Qual nome do contato que voce quer buscar: ");
                            nome = Console.ReadLine();
                            meusContatos.Localizar(nome);
                        }
                        
                        break;

                    case "4":
                        meusContatos.ImprimirListaCompleta();
                        break;

                    case "5":
                        meusContatos.ImprimirUmAUm();
                        break;

                    case "6":
                        Console.WriteLine($"Sua lista de contatos possui {meusContatos.Quantidade} contatos");
                        break;

                }

                Console.WriteLine("");
                Console.WriteLine("#################################");
                Console.WriteLine("");

            } while (escolha != "0");
        }

        private static Contato InserirContato()
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
            return new Contato
            {
                Nome = nome,
                Telefones = new Telefone[]
                {
                   new Telefone
                   {
                       DDD = ddd,
                       Numero = numero,
                       Tipo = tipo
                   }
                }
            };
        }
    }
}
