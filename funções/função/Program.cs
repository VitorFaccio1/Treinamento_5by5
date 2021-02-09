using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace função
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a primeira nota");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota");
            double n3 = double.Parse(Console.ReadLine());
            //double resp;


            // resp = media(n1, n2, n3);
            //Console.WriteLine("A media dos valores é de: " + resp);
            Console.WriteLine("A media dos valores é de: " + media(n1,n2,n3));
            Console.ReadKey();
        }      

        static double media(double n1, double n2 , double n3)
        {
            //double med = (n1 + n2 + n3) / 3;
            //return (med);
            return ((n1 + n2 + n3 )/ 3);
        }
      


    }
}
