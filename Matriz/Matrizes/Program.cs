using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            float [ , ] x = new float [7,3]; //[LINHA , COLUNAS] [|, --] //NAO PODE MISTURAR TIPO DE DADOS
            float soma = 0;

            Console.WriteLine("Informe os valores da matriz [7,3]");
            for (int l = 0; l < 7; l++)      //lINHAS FICA FIXA
            {                                  //POSSO INVERTER ESSA ORDEM ( O LAÇO QUE FOR INTERNO VAI SER OQ VAI ANDAR E O DE FORA FICA FIXO)
                Console.WriteLine("Informe os valoers da linha [" + (l+1) + "]:" );
                for (int c = 0; c < 3; c++) // COLUNAS MUDAM
                {
                    Console.Write("Coluna [" + (c+1) + "] = ");
                    x[l, c] = float.Parse(Console.ReadLine());
                }
            }

            for (int l = 0; l < 7; l++)
            {             
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(x[l, c]+"\t");
                    soma += x[l, c];
                }
                Console.WriteLine("");
            }


            Console.WriteLine();
            Console.WriteLine("A soma é: " + soma);
            Console.ReadKey();
        }
    }
}
