using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int comeco, final, contador, soma;
			soma = 0;

			Console.WriteLine("Informe um começo: ");
			comeco = int.Parse(Console.ReadLine());

			do
			{
				Console.WriteLine("Informe um final: ");
				final = int.Parse(Console.ReadLine());
			} while (final<comeco);

			for (contador=comeco;contador<=final ;contador++ ) {
				if(contador % 2 == 0) {
					soma = soma + contador;
					
				}
			}
			Console.Write(soma);
		}
	}
}
