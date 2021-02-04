using System;

namespace todos_laços_de_repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada, saida, soma;
            soma = 0;

            Console.Write("Informe a entrada: ");
            entrada = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Informe o final : ");
                saida = int.Parse(Console.ReadLine());
            } while (saida <= entrada);



            while (entrada < saida)
            {
                entrada++;
                Console.WriteLine(entrada);
                soma = soma + entrada;

            }

            Console.WriteLine(soma);


           
            


        }
    }
}
