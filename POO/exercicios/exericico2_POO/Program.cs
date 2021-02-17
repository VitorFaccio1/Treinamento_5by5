using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exericico2_POO
{
    class Program
    {
        static void Main(string[] args)
        {   
            string escolha;
            cliente c = new cliente();
            c.account = new conta();
            cliente joao = new cliente
            {
                CPF = 481239129312,
                nome = "joao",
                endereco = "Avenida sla",
                account = new conta
                {
                    agencia = 1,
                    numero = 1,
                }
            };


            do
            {
                do
                {
                    Console.WriteLine("\nMenu:\n" +
                              "1)Mostra os dados necessarios para conta ser criada\n" +
                              "2)Deposito\n" +
                              "3)Saque\n" +
                              "4)Transferencia\n" +
                              "5)Imprimia o saldo\n" +
                              "6)Sair do programa");
                    escolha = Console.ReadLine();

                    if (escolha == "2" || escolha == "3" || escolha == "4" || escolha == "5")
                    {
                        Console.WriteLine("\nPrimeiro Crie Sua conta para depois fazer as outras coisa");
                    }
                } while (escolha != "1" && escolha != "6");
               

                switch (escolha)
                {
                    case "1":
                        {
                            c.Inserir();
                            break;
                        }
                    case "2":
                        {
                            double valor;

                            Console.WriteLine("----FAZER DEPÓSITO----");
                            Console.WriteLine("Qual valor que você quer depositar: ");
                            valor = double.Parse(Console.ReadLine());
                            c.account.Deposito(valor);
                            break;
                        }
                    case "3":
                        {
                            double valor;

                            Console.WriteLine("----FAZER SAQUE----");
                            Console.WriteLine("Qual valor que você quer sacar: ");
                            valor = long.Parse(Console.ReadLine());
                            c.account.Saque(valor);
                            break;
                        }
                    case "4":
                        {
                            c.account.Transferencia(joao);
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("Seu saldo é de: " + c.account.saldo);
                            break;
                        }
                    case "6":
                        {
                            break;
                        }
                }
            } while (escolha != "6");


            Console.ReadKey();
        }
    }
}
