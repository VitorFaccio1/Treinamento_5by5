using System;

namespace exercicio3_matriz_verRepetição
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[10, 5];

            //PASSAR VALORES PARA MATRIZ
            
            Leitura(matriz);

            Calcular(matriz);

            Imprimir(matriz);

            Soma(matriz);         

            Console.ReadKey();

        }
        
        static void Leitura(int [,] mat)
        {
            Console.WriteLine("Informe o valores: ");
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.WriteLine("informe valor da " + (j + 1) + "º coluna ");
                mat[0, j] = int.Parse(Console.ReadLine());
            }

            return;
        }

        static void Calcular(int[,] mat)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                for (int i = 1; i < mat.GetLength(0); i++)
                {
                    mat[i, j] = mat[0, j] * (i + 1);
                }
            }
            return;
        }

        static void Imprimir(int [,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int x = 0; x < mat.GetLength(1); x++)
                {
                    Console.Write(mat[i, x] + "-");
                }
                Console.WriteLine();
            }
        }

        static void Soma(int[,]mat)
        {
            int soma = 0;
            for (int i = 0; i < mat.GetLength(1); i++)
            {
                soma += mat[9, i];
            }
            Console.WriteLine(soma);
        }
    }
}
