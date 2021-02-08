using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            // pergunte ao usuario quantos alunos tem na sala dele. atreves de um laço com as notas validas, um por vez. calcule a media aritimetica da turma;
            //A nota se tiver casa decimal = separar por virgulo 8,53
            int total, contador = 0;
            double notas, media, soma = 0;
            do
            {
                Console.WriteLine("Quantos alunos tem na sala: ");
                total = int.Parse(Console.ReadLine());
            } while (total <= 0);
            
            do
            {
                contador++;
                Console.WriteLine("Digite a nota de cada aluno: ");
                notas = double.Parse(Console.ReadLine());
                soma += notas;
            } while (contador < total);        

           
                
               
            

            media = (soma / total);

            Console.WriteLine("A média da sala é de: " + media) ;


            Console.ReadKey();


        }
    }
}
