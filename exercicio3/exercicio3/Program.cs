using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, razao, a1, an, soma = 0;



            // an = a1 + (n-1)xr

            Console.Write("Informe o A1: ");
            a1 = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Informe quantos elementos terá sua PA (n): ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);

            Console.Write("Informe a razao: ");
            razao = int.Parse(Console.ReadLine());

            an = a1 + ((n - 1) * razao);


            if (razao > 0)
            {
                for (int contador = a1; contador <= an; contador += razao)
                {
                    
                    Console.Write(contador + ",");
                    soma += contador;
                }
                Console.WriteLine("\nA soma dos termos é de: " + soma);
            }

            else if (razao == 0)
            {
                int x = 0;
                for (int i = a1; x < n; x++)
                {
                    Console.Write(i + ",");
                    soma += i;
                }
                Console.WriteLine("\nA soma dos termos é de: " + soma);
            }
            else if (razao < 0)
            {


                for (int contador = a1; contador >= an; contador += razao)
                {

                    Console.Write(contador + ",");
                    soma += contador;
                }

                Console.WriteLine("\nA soma dos termos é de: " + soma);
            }






            Console.ReadKey();

        }
    }
}
