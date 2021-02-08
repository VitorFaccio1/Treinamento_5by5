using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1º jeito:   int [] x;
                           x = new int [10];   */

            // 2º jeito:  int [] x = new int [10];

            int[] x = new int[5];
            

            Console.WriteLine("informe 5 valores inteiros: ");
            for (int i = 0; i < 5  ;i++)
            {
                Console.Write("Informe " + (i + 1)  + "º um valor: ");
                x[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Os valores informados são: ");
            for (int i = 0; i < 5; i++)
            {
                /* if(i%2 == 0)
                {
                    Console.WriteLine("x[" + i + "]=" + x[i]);
                }*/
                Console.WriteLine("x[" + i + "]=" + x[i]);
                //Console.WriteLine("x[" + 3 + "]=" + x[3]);

            }


            Console.ReadKey();
            
        }
    }
}
