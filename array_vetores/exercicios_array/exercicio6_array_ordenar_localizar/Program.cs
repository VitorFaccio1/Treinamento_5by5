using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6_array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x = new double[10];
            int valor;
            bool achou = false;
            

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Informe o " + (i+1) + "º valor: ");
                x[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = (i+1); j < x.Length; j++)
                {
                    if (x[i] > x[j])
                    {
                        double aux = x[i];
                        x[i] = x[j];
                        x[j] = aux;
                    }                 
                }                      
            }

            Console.WriteLine();
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] +"-"); //imprimindo valor ordenado
            }

            Console.WriteLine();

            Console.WriteLine("Informe um valor para ser localizado: ");
            valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == valor)
                {
                    Console.WriteLine("Valor encontrado é: " + x[i] + " na posição " + i);
                    achou = true;
                }               
            }
            if(!achou) // achou == false
            {
                Console.WriteLine("Nenhum valor foi encontrado");
            }      

            Console.ReadKey();
        }
    }
}
