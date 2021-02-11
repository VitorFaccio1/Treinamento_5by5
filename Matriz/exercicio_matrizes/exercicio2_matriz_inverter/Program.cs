using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2_matriz_inverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[6, 2];
            int[,] invertida = new int[6, 2];

            Console.WriteLine("Informe os valores da matriz [7,3]");
            for (int l = 0; l < 6; l++)      
            {
                Console.WriteLine("Informe os valoers da linha [" + (l + 1) + "]:");
                for (int c = 0; c < 2; c++) 
                {
                    Console.Write("Coluna [" + (c + 1) + "] = ");
                    matriz[l, c] = int.Parse(Console.ReadLine());
                    invertida[l, c] = matriz[l, c];
                }
            }

            Console.WriteLine();
            for (int l = 0; l < 6; l++)
            {
                for (int c = 0; c < 2; c++)
                {
                    Console.Write(matriz[l, c] + "\t");                    
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Matriz invertida agora \n");

            for (int l = 0, l2 = (matriz.GetLength(0) - 1); l < 6; l++,l2--)
            {
                for (int c = 0, c2= (matriz.GetLength(1)-1); c < 2; c++,c2--)
                {
                    invertida[l, c] = matriz[l2, c2];
                }
            }
           

            for (int l = 0; l < 6; l++)
            {
                for (int c = 0; c < 2; c++)
                {
                    Console.Write(invertida[l, c] + "\t");
                }
                Console.WriteLine("");
            }
            


            Console.ReadKey();


        }
    }
}
