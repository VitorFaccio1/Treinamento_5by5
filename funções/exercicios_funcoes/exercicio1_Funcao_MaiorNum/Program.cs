using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFuncao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro numero inteiro: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero inteiro: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o teceiro numero inteiro: ");
            int num3 = int.Parse(Console.ReadLine());


            Console.WriteLine(Maior(num1, num2, num3));
            Console.ReadKey();
        }

        static string Maior(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return ("O primeiro numero é o maior");
            }
            else if (num2 > num1 && num2 > num3)
            {
                return ("O segundo valor é o maior");
            }
            else
            {
                return ("O terceiro valor é o maior");
            }
        }
    }
}
