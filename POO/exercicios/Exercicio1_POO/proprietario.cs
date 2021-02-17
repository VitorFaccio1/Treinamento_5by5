using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_POO
{
    class proprietario
    {
        public double CPF { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string data_nascimento { get; set; }
        public string data_compra { get; set; }
        public veiculo v { get; set; }

        public void Inserir()
        {
            //VEICULO
            Console.WriteLine($"Informe o renavam:");
            v.renavam = double.Parse(Console.ReadLine());
            Console.WriteLine($"Informe o chassis: ");
            v.chassis = string.Format(Console.ReadLine());
            Console.WriteLine($"Informe o placa: ");
            v.placa = string.Format(Console.ReadLine());
            Console.WriteLine($"Informe o marca:");
            v.marca = string.Format(Console.ReadLine());
            Console.WriteLine($"Informe o modelo: ");
            v.modelo = string.Format(Console.ReadLine());
            Console.WriteLine($"Informe o cor: ");
            v.cor = string.Format(Console.ReadLine());
            Console.WriteLine($"Informe o ano:");
            v.ano = int.Parse(Console.ReadLine());

            //PROPRIETARIO
            Console.WriteLine($"Informe o CPF:");
            CPF = double.Parse(Console.ReadLine());
            Console.WriteLine($"Informe o nome:");
            nome = string.Format(Console.ReadLine());
            Console.WriteLine($"Informe o data de nascimento:");
            data_nascimento = string.Format(Console.ReadLine());
            Console.WriteLine($"Informe o endereco:");
            endereco = string.Format(Console.ReadLine());
            Console.WriteLine($"Informe o data de compra:");
            data_compra = string.Format(Console.ReadLine());

        }


        public override string ToString()
        {
            return ($"O cpf é {CPF}\nO nome é {nome}\nO endereco é {endereco} \nA data de nascimento {data_nascimento}" +
                $"\nA data de compra é {data_compra} {v}" );
        }       

    }
}
