using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[50];
            int n;
            int neg = 0;
            int par = 0;
            

            do
            {
                Console.WriteLine("Informe tamanho no maximo 50");
                n = int.Parse(Console.ReadLine());
            } while (n > 50 && n < 1);

            for (int i = 0; i < n; i++)
            {   
                Console.WriteLine("Digite " +(i+1) + "º numero: " );
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (vetor[i] < 0)
                {
                    neg++;
                    if (vetor[i] % 2 == 0)
                    {
                        par++;
                    }
                }
                else if (vetor[i] % 2 ==0)
                {
                    par++;
                }              
            }

            Console.WriteLine("Total de numeros positivos: " + (n - neg));
            Console.WriteLine("Total de numeros negativos: " + neg);
            Console.WriteLine("Total de numeros pares: " + par);

            Console.ReadKey();




        }
    }
}

