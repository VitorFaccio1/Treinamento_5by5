using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int contador = 0, maior = 0;
            do
            {
                Console.WriteLine("Informe um numero (Maior do que zero): ");
                num = int.Parse(Console.ReadLine());
                contador += num;

                if (maior < num)
                {
                    maior = num;
                }

            } while ((num > 0) && (num != -999));
            Console.WriteLine("O maior numero é: " + maior);
            Console.WriteLine("A soma dos numeros é de: " + (contador + 999));




            Console.ReadKey();
        }

    }
}
