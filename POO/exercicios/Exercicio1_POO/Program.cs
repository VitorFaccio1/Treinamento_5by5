using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            proprietario p = new proprietario();
            p.v = new veiculo();

            do
            {
                Console.WriteLine("Informe o que você deseja: \n1)Informar todos os dados" +
                "\n2)Imprimir dados que ja possui \n3)Finalizar programa!");
                escolha = int.Parse(Console.ReadLine());
                if (escolha == 2)
                {
                    Console.WriteLine("Informe primeiro todos os valores para depois imprimi-los\n");
                }
                if (escolha == 3)
                {
                    Console.ReadKey();
                }
            } while (escolha != 1);


            switch (escolha)
            {
                case 1:
                    {
                        p.Inserir();                     
                        break;
                    }


                case 3:
                    {
                        break;
                    }
            }

            Console.WriteLine();

            do
            {
                Console.WriteLine("Informe o que você deseja: \n1)Informar todos os dados" +
                "\n2)Imprimir dados que ja possui \n3)Finalizar programa!");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Voce ja informou os valores antes!");
                    Console.WriteLine();
                }

                else if (escolha == 3)
                {
                    Console.ReadKey();
                }

            } while (escolha != 2);


            if (escolha == 2)
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
          
        }
    }
}



