using System;

namespace projetoIntroducao
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente(){
                Id = 1,
                Nome = "Vitor",
                Idade= 18
            };

            Console.WriteLine("Entre com sua idade: ");
            c.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Idade: " + c.Idade);
        }
    }
}
