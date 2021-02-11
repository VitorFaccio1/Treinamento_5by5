using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2_matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[10, 2];
            int valor;
            bool achou = false;

            //PASSAR VALORES PARA MATRIZ
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe o valor da " +(i+1) +"º linha");
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine((j+1)+"º coluna ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //INFORMAR VALOR DE BUSCA
            Console.WriteLine("Informe o valor que voce quer localizar: ");
            valor = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            //AJEITAR MATRIZ 
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.Write(matriz[i,k] + "\t");                    
                   
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            //MOSTRAR RESULTADO DA POSIÇÃO DOS VALORES
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    if (valor == matriz[i, k])
                    { 
                        Console.WriteLine("O valor "+valor+" foi encontrados na posição [" +(i+1)+ ","+ (k+1) +"]" );
                        achou = true;
                    }
                }
            }

            if (!achou)
            {
                Console.WriteLine("O valor nao existe dentro da matriz");
            }

            Console.ReadKey();
        }
    }
}
