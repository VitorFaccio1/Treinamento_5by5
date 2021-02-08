using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace exercicio2_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];
            int valor;
            //int contador = 0;
            bool achou = false;


            Console.WriteLine("Informe 10 valores: ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Informe o " + (i + 1) + "º valor: ");
                x[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Informe um valor para ser localizado: ");
            valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == valor)
                {
                    Console.WriteLine("Valor localizado! Posição " + (i + 1));
                    //contador++;
                    achou = true;
                }
            }
            //if (contador == 0)
            if(!achou) //if(achou == false)
            {
                Console.WriteLine("Valor não foi localizado!");
            }
            Console.ReadKey();

        }
    }
}
