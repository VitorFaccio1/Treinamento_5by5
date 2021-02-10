using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5_array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x = new double[5];
            

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Informe o " + (i+1) + "º valor: ");
                x[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i]+"-");
            }
            
            for (int i = 0, j = (x.Length-1); i < j; i++, j--)
            {
                double aux = x[i]; // aux pega o valor de xI
                x[i] = x[j];       // xi pega o valor de xj
                x[j] = aux;        // xj pega o valor de aux(que na verdade é o x1)  
            }

            Console.WriteLine();
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i]+"-");
            }

            Console.ReadKey();
        }
    }
}
