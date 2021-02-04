using System;

namespace Estrutura_SE
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, op;

            Console.WriteLine("numero 1: "); x = int.Parse(Console.ReadLine());
            Console.WriteLine("numero 2: "); y = int.Parse(Console.ReadLine());
            Console.WriteLine("operação 1 soma, 2 subtração, 3 multiplicação, 4 divisao "); op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine($"a soma de {x} + {y} = {x+y}");
                    break;

                case 2:
                    Console.WriteLine($"A subtração de {x} - {y} = {x - y}");
                    break;

                case 3:
                    Console.WriteLine($"a multiplicação de {x} * {y} = {x * y}");
                    break;

                case 4:
                    if (y == 0)
                    {
                        Console.WriteLine("Divisão impossivel");
                    }
                    else
                    {
                        Console.WriteLine($"A divisão de {x} / {y} = {x / y}");
                    }                    
                    break;
            }





        }
    }
}
