using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[30];
            int para;
            vetor[0] = 0;
            vetor[1] = 1;

            do	{

                Console.WriteLine("Informe um valor de parada (maior que 2 e menor que 30): ");
                para = int.Parse(Console.ReadLine());
         	} while (para<2 || para>30);

            Console.WriteLine(vetor[0]);
            Console.WriteLine(vetor[1]);
            for (int i = 2; i < para; i++)
            {
                vetor[i] = (vetor[i - 1]) + (vetor[i - 2]);         
                Console.WriteLine(vetor[i]);
            }

            Console.ReadKey();

        }
    }
}
