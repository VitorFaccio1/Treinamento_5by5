using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int[] invertido = new int[10];

            //definir valores para o vetor
            Console.WriteLine("Informe 10 valores\n");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine($"informe {(i + 1)}valor: ");
                vet[i] = int.Parse(Console.ReadLine());
                
            }

            //mostrar vetor
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i]+"-");
            }

            //inverter valores
            for (int i = 0, j = (vet.Length -1); i < vet.Length; i++, j--)
            {                
                invertido[j] = vet[i];
            }

            Console.WriteLine();
            //mostrar resultado invertido
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(invertido[i] + "-");
            }


            Console.ReadKey();
            
        }
    }
}
