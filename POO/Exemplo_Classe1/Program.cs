using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Classe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            Pessoa p2 = new Pessoa
                {
                id = 1,
                Nome = "Guilherme",
                Idade= 12
                };

            p2.endereco = new Endereco {Logradouro = "Rua Humaita", Numero = 12, Localidade =  "Araraquara" };


            Pessoa p3 = new Pessoa
            {
                id = 99,
                Nome = "jose",
                Idade = 400,
                endereco = new Endereco
                {
                    Logradouro = "Rua sao bento",
                    Numero = 123,
                    Localidade = "araraquara"
                }   
            };

            Console.WriteLine(p);
            Console.WriteLine(p.ToString());
            
            Console.WriteLine();
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.endereco.Localidade);
            Console.WriteLine();

            Console.WriteLine("Apos instanciar o objeto ID: {0}", p.GetId());
            Console.WriteLine("Apos instanciar o objeto Nome: {0}", p.Nome);
            Console.WriteLine("Apos instanciar o objeto Idade: {0}", p.Idade);

            Console.WriteLine("-------APOS CHAMAR O METODO-------");

            p.Nome = "Vitor";
            p.SetId(10);
            p.Idade = 18;

            Console.WriteLine("Apos chamar o metodo SetId: {0}", p.GetId());
            Console.WriteLine("Apos chamar o metodo Nome: {0}", p.Nome);
            Console.WriteLine("Apos chamar o metodo idade: {0}", p.Idade);

            Console.WriteLine();

            Console.WriteLine(p.ToString());
            if (p.Maior())
            {
                Console.WriteLine($"{p.Nome} é maior de idade");
            }
            else
            {
                Console.WriteLine($"{p.Nome} é menor de idade");
            }
            Console.ReadKey();
        }
    }
}
