using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {//Escreva um algoritimo que encontre o quinto numero maior que 1000, cuja divisao por 11 tenha resto 5.
            int num = 1000, contador = 0, qual;

            do
            {
                Console.Write("Encontre qual numero maior que 1000 (Mil): ");
                qual = int.Parse(Console.ReadLine());
            } while (num < 0);

            while (contador < qual)
            {
                if (num % 11 == 5)
                {
                    contador += 1;
                }
                num += 1;
            }
            Console.WriteLine(num);
            Console.ReadKey();




        }
    }
}
