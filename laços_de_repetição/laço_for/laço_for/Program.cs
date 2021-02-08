using System;

namespace laço_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador, num1, num2;

            Console.WriteLine("numero 1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("numero 2:");
            num2= int.Parse(Console.ReadLine());

            for(contador = num1; contador <= num2; contador++)
            {
                Console.WriteLine(contador);
            }

        }
    }
}
