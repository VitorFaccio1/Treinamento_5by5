using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaString = new List<string>();
            string nome;
            Console.WriteLine("Capacidade: " + listaString.Capacity);
            do
            {
                Console.WriteLine("Digite um nome para inserir na lista: ");
                nome = Console.ReadLine();
                listaString.Add(nome); //adicionar elementos
            } while (nome != "");

            Console.WriteLine("A lista tem " + listaString.Count + " elementos"); //Contador de elementos

            listaString.ForEach(i => Console.WriteLine(i)); //Imprimi cada item da lista

            Console.WriteLine("A lista ordenada: ");
            listaString.Sort(); //ORDENAR A LISTA
            listaString.ForEach(i => Console.WriteLine(i)); //imprime a lista

            Console.WriteLine("O elemento da posição 3 é: " + listaString[3]);//Acessa uma posição especifica

            listaString[3] = "\nJoaquim\n"; //Troca um posição

            listaString.Insert(1, "Tiririca");//ADICIONAR EM UMA POSIÇAO ESPECIFICA

            Console.WriteLine("A lista modificada");
            listaString.ForEach(i => Console.WriteLine(i));
            Console.WriteLine("Capacidade: " + listaString.Capacity);

            if (listaString.Remove("Tiririca"))//Remover Elemento que existe, se nao existir cai no else!
            Console.WriteLine("Elemento removido com sucesso");
            else
                Console.WriteLine("Elemento nao localizado");
            listaString.ForEach(i => Console.WriteLine(i));
            Console.ReadKey();
        }
    }
}
