using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] x = new int [10];
            int aux;
            int i = 0;

            Console.WriteLine("Informe 10 valores: ");

            for (; i < x.Length; i++)
            {
                Console.WriteLine("Informe o " + (i+1) + "º valor: ");
                x[i] = int.Parse(Console.ReadLine());

                for (int j = 0; j < x.Length; j++)
                {

                    if (x[i] < x[j])
                    {
                        aux = x[i];
                        x[i] = x[j];
                        x[j] = aux;
                    }
                }
            }
            for (int k = 0; k < x.Length; k++)
            {
                Console.Write(x[k]+"-");
            }         
            Console.ReadKey();
            
        }
    }
}
