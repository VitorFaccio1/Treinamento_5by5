using System;

namespace numero_primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int divisores = 0;

            Console.WriteLine("informe um numero: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if(numero % i == 0)
                {
                    divisores++;
                }
            }
            if(divisores == 2)
            {
                Console.WriteLine("É um numero primo!");
            }
            else
            {
                Console.WriteLine("Não é um numero primo!");
            }
        }
    }
}
