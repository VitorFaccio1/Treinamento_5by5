using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int soma = 0;
            int prod = 1;


            do
            {
                do
                {
                    Console.WriteLine("informe um numero maior do que zero (OBS: ZERO SAI DO PROGRAMA):");
                    num1 = int.Parse(Console.ReadLine());

                    if (num1 < 0)
                    {
                        Console.WriteLine("Tem que ser maior do que zero");
                    }

                } while (num1 < 0);

                if (num1 % 2 == 0)
                {
                    soma += num1;
                }

                else
                {
                    prod *= num1;
                }

            } while (num1 != 0);
            Console.WriteLine(soma);
            Console.WriteLine(prod);
            Console.ReadKey();

        }

    }
}
