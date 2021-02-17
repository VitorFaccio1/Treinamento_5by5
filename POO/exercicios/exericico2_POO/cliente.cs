using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exericico2_POO
{
    class cliente
    {
        public long CPF { get; set; }
        public string  nome { get; set; }
        public string  endereco { get; set; }

        public conta account { get; set; }

        public void Inserir()
        {
            Console.WriteLine("----ABERTURA DE CONTA----");
            Console.WriteLine("Informe seu CPF: ");
            CPF = long.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu nome: ");
            nome = string.Format(Console.ReadLine());
            Console.WriteLine("Informe seu endereço: ");
            endereco = string.Format(Console.ReadLine());
            Console.WriteLine("Informe seu numero de conta: ");
            account.numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua agencia: ");
            account.agencia = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return ($"CPF: {CPF} \nNome:: {nome} \nEndereco: {endereco}");
        }

    }
}
