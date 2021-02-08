using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int[] x = new int[10];
            int soma = 0;
            int num;
     
            Console.WriteLine("informe 10 valores pares: ");            
            do
            {
                Console.Write("Informe " + (contador + 1) + "º um valor: ");
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    x[contador] = num;
                    contador++;
                }

            } while (contador < x.Length);

            Console.WriteLine("\nOs valores maiores que 10 são: ");

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > 10)
                {
                    Console.WriteLine(x[i]);
                }

                soma += x[i];
            }
            Console.WriteLine("\nA soma de todos os numeros é de: " + soma);
            Console.ReadKey();


            /* RESOLUÇÃO DO PROFESSOR
             
             int [] vet = new int [10];
             int soma = 0;

            Console.WriteLine("Informe 10 valores pares: ");
            for(int i=0; i<vet.Length; i++)
            {
                do
                {
                    Console.WriteLine((i + 1) + "o. valor = ");
                    vet[i] = int.Parse(Console.ReadLine());

                }while(vet[i] % 2 != 0);
            }

            Console.WriteLine("Os valores maiores do que 10 informado são: ");
            for (int i = 0; i<vet.Length; i++) 
            {
                if(vet[i]>10)
                    Console.WriteLine(vet[i]");                
                soma += vet[i];
            }
            Console.WriteLine("A soma dos valores é de: " + soma)
            Console.ReadKey();         
             */

        }
    }
}
