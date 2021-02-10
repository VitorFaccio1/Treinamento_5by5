using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3_funcao_fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int fatorial = 1;

            do
            {
                Console.WriteLine("Escreva um numero inteiro e positivo: ");
                num1 = int.Parse(Console.ReadLine());
            } while (num1 < 0);


            for (int i = num1; i > 1; i--)
            {
                Console.Write(i + "*");
            }
            Console.WriteLine(" = " + calculo(num1, fatorial));

            Console.ReadKey();
        }

        static int calculo(int num1, int fatorial)
        {
            for (int i = num1; i > 1; i--)
            {
                fatorial *= i;
            }
            return fatorial;

        }
    }
}
