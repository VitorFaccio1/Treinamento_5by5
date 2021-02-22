using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Dinamica_Simplesmente_Encadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaContatos lista_meus_contatos = new ListaContatos
            {
                Tail = null,
                Head = null,
            };
            Pessoa person = new Pessoa
            {
                Nome = "joao",
                telefone = new Telefone[]
                {
                    DDD = 16,
                    Numero = 996280697, //Parou aqui
                    Tipo = "Celular",
                }
            };


            Console.ReadKey();
        }
    }
}
