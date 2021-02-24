using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listaPessoa = new List<Pessoa>();
            string nome;
            int idade;
            Console.WriteLine("Capacidade: " + listaPessoa.Capacity);
            do
            {
                Console.WriteLine("Digite um nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());
                if(nome != "")
                {
                    listaPessoa.Add(new Pessoa { Nome = nome, Idade = idade });
                }
            } while (nome != "");


            Console.WriteLine("A lista tem " + listaPessoa.Count + " elementos");

            listaPessoa.ForEach(i => Console.WriteLine(i.ToString()));

            Console.WriteLine("\nA lista ordenada por nome: ");
            listaPessoa = listaPessoa.OrderBy(lp => lp.Nome).ToList();
            listaPessoa.ForEach(i => Console.WriteLine(i.ToString()));

            Console.WriteLine("\nA lista ordenada por idade: ");
            listaPessoa = listaPessoa.OrderBy(lp => lp.Idade).ToList();
            listaPessoa.ForEach(i => Console.WriteLine(i.ToString()));



            Console.ReadKey();
        }
    }
}
