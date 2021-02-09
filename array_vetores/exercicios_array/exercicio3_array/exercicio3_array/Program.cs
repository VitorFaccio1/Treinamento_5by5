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
            

            Console.WriteLine("Informe 10 valores: ");

            for (int i=0; i < x.Length; i++)
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
            for (int cont = 0; cont < x.Length; cont++)
            {
                Console.Write(x[cont]+"-");
            }         
            Console.ReadKey();
            
        }
    }
}
