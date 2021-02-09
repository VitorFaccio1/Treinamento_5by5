using System;

namespace condicional_SE
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,op ;

            Console.Write("numero 1: "); num1 = int.Parse(Console.ReadLine());
            Console.Write("numero 2: "); num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite 1 para soma, 2 para subtração, 3 para multiplicação, 4 para divisao: "); op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine($"A soma de {num1} + {num2} é de {num1+num2} ");
            }
            else
            {
                if (op == 2)
                {
                    Console.WriteLine($"A subtração de {num1} - {num2} é de {num1- num2} ");

                }
                else 
                {
                    if (op == 3)
                    {
                        Console.WriteLine($"A multiplicação de {num1} * {num2} é de {num1 * num2} ");

                    }
                    else
                    {
                        if (op == 4)
                        {
                            if(num2 == 0)
                            {
                                Console.Write("impossivel dividir por zero");
                            }
                            else
                            {
                                Console.WriteLine($"A divisão de {num1} / {num2} é de {num1 / num2} ");
                            }                          
                        }
                    }
                }
            }




        }
    }
}
