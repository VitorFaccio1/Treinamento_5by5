using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcao_teoria
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine($"Antes de chamar a função trocar\n a= {a} b={b}");
            trocar_valores(ref a,ref b);
            Console.WriteLine($"DENTRO DO MAIN\nValoers trocados de a e b \n a= {a} b= {b}");
            Console.ReadKey();
        }

        static void trocar_valores(ref int a ,ref int b)
        {
            int aux;
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"DENTRO DA FUNÇÃO\nValoers trocados de a e b \n a= {a} b= {b}");
            return;
        }
    }
}
