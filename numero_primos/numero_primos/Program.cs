using System;

namespace numero_primos
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0 ;
            int soma = 0;





            for (int i > 0; i <= 500; i++)
            {
                if(i % 2 == 1)&&(i % 3 == 0)
                {
                    Console.WriteLine(i);
                    soma = soma + i;
                }
                Console.WriteLine("oi");
            }

            
            
            Console.ReadKey();

            
        }
    }
}
