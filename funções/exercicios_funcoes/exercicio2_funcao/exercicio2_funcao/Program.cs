using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2_funcao
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nota1 = new double[10];
            double[] nota2 = new double[10];
            double media;

            Console.WriteLine("Informe as  primeiras notas: ");
            for (int i = 0; i < 10; i++)
            {
                nota1[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Informe as segundas notas: ");
            for (int i = 0; i < 10; i++)
            {
                nota2[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                media = ((nota2[i] + nota1[i]) / 2);
                Console.WriteLine($"aluno {i} nota1: {nota1[i]} e nota2: {nota2[i]} tem media: {media} e esta: {situacao(media,nota1[i],nota2[i])}");
            }
            Console.ReadKey();
        }

        static string situacao(double media, double nota1, double nota2)
        {
            string text;
            double mediaa;

            mediaa = (nota1 + nota2) / 2;

            if (media < 2)
            {
                text = "reprovado";
            }
            else if (mediaa >= 2 && mediaa < 7)
            {
                text = "de exame";
            }
            else
            {
                text = "aprovado";
            }
            return text;
        }


    }
}
