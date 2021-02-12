using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4_matriz_localizar_repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var matriz = new int[5, 2];

                PopularMatriz(matriz);
                CompararMatriz(matriz);

                Console.ReadKey();
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
                            
        }

        private static void PopularMatriz(int[,] matriz)
        {
            for (int l = 0; l < matriz.GetLength(0); l++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.WriteLine($"Digite o valor para matriz[{l},{c}]: ");
                    matriz[l, c] = int.Parse(Console.ReadLine());
                }
            }

            return;
        }
        private static void CompararMatriz(int[,] matriz)
        {
            bool valorEncontrado = false;

            for (int l = 0; l < matriz.GetLength(0); l++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    bool existe = ExisteNaMatriz(matriz, matriz[l, c], l, c);
                    if (existe)
                    {
                        valorEncontrado = true;
                    }
                }
            }

            if (!valorEncontrado)
            {
                Console.WriteLine("Nenhum valor foi encontrado!");
            }
            return;
        }
        private static bool ExisteNaMatriz(int[,] matriz, int valor, int linhaOrigem, int colunaOrigem)
        {
            bool valorEncontrado = false;
            for (int l = 0; l < matriz.GetLength(0); l++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    string posicao = $"{l},{c}";
                    string posicao2 = $"{linhaOrigem},{colunaOrigem}";

                    if (posicao != posicao2 && matriz[l,c] == valor)
                    {
                        Console.WriteLine($" O valor da {valor} existe na posição [{l},{c}]");
                        valorEncontrado = true;
                    }
                }
            }

            return valorEncontrado;
        }


    }
}
