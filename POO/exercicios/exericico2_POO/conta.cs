using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exericico2_POO
{
    class conta
    {
        public int agencia { get; set; }

        public int numero { get; set; }

        public double saldo { get; private set; }

        public conta()
        {
            saldo = 0;
        }

        public void Deposito(double valor)
        {
            saldo += valor;
        }

        public bool Saque(double valor)
        {
            bool tentar = true;
            string resposta;
            do
            {

                if (valor > saldo)
                {
                    Console.WriteLine("Você não possui saldo suficiente!");
                    Console.WriteLine("Seu saldo é de: " + saldo);

                    Console.WriteLine("Voce deseja tentar novamente? não(n), sim(s): ");
                    resposta = Console.ReadLine();
                    if (resposta == "n")
                    {
                        tentar = false;
                    }
                    else
                    {
                        Console.WriteLine("Qual valor você quer tentar novamente?  ");
                        valor = double.Parse(Console.ReadLine());                        
                    }
                }
                else
                {
                    saldo -= valor;
                    tentar = false;
                    Console.WriteLine("Seu saldo agora é: " + saldo);
                    return true;
                }

            } while (tentar);

            return false;

        }

        public void Transferencia(cliente p)
        {
            int numero_da_conta;
            string resposta;
            double valor;

            Console.WriteLine("----TRANSFERENCIA----");
            Console.WriteLine("Informe o numero da conta: ");
            numero_da_conta = int.Parse(Console.ReadLine());

            if (numero_da_conta == p.account.numero)
            {
                Console.WriteLine($"A agencia para quem voce quer transferir é {p.account.agencia} para o cliente {p.nome}" +
                    $" Se sim digite s, se for nao digite n");
                resposta = Console.ReadLine();
                if(resposta == "s")
                {
                    Console.WriteLine("Informe o valor da transferencia"); 
                    valor = double.Parse(Console.ReadLine());
                    if (Saque(valor))
                    {
                        p.account.Deposito(valor);
                    }
                    else
                    {
                        Console.WriteLine("Cancelando operação!");
                    }
                }
            }
        }

        



        public override string ToString()
        {
            return ($"Sua agencia é {agencia} \nNumero: {numero} \nSaldo {saldo}");
        }
    }
}
