using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, fim, contador, tabuada, resultado, soma = 0;

            Console.WriteLine("Informe o inicio");
            inicio = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Informe o final");
                fim = int.Parse(Console.ReadLine());
            } while (fim < inicio);
            
            Console.WriteLine("Informe o tabuada");
            tabuada = int.Parse(Console.ReadLine());


            for (contador = inicio; contador <= fim; contador++)
            {
                resultado = tabuada * contador;
                Console.WriteLine($"{tabuada} x {contador} = {resultado} ");
                soma += resultado;
            }



            Console.WriteLine(soma);
            Console.ReadKey();


        }
    }
}
