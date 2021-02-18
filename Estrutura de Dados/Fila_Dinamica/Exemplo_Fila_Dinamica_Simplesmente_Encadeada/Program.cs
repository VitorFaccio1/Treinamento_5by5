using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Fila_Dinamica_Simplesmente_Encadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            FilaOrdemServico filaos = new FilaOrdemServico
            {
                Head = null,
                Tail = null
            };

            OrdemServico os = new OrdemServico
            {
                Numero = 1,
                Tipo = "Usinagem",
                Descricao = "Fazer 100 unidades de pedaleira de moto",
                //Data_Criacao = DateTime.Parse("20/02/2020"), DATA QUE VOCE QUISER
                Data_Criacao = DateTime.Now, //DATA DO SISTEMA
                Prazo = 10,
                Proximo = null

            };
            filaos.Push(os);
            //Console.WriteLine(os.ToString());

            os = new OrdemServico
            {
                Numero = 2,
                Tipo = "Pintura",
                Descricao = "Pintar 20 quadros de BMW1200",
                //Data_Criacao = DateTime.Parse("20/02/2020"), DATA QUE VOCE QUISER
                Data_Criacao = DateTime.Now, //DATA DO SISTEMA
                Prazo = 15,
                Proximo = null
            };
            filaos.Push(os);            

            os = new OrdemServico
            {
                Numero = 3,
                Tipo = "Montar moto",
                Descricao = "Montar 10 unidades de biz 150",
                //Data_Criacao = DateTime.Parse("20/02/2020"), DATA QUE VOCE QUISER
                Data_Criacao = DateTime.Now, //DATA DO SISTEMA
                Prazo = 25,
                Proximo = null
            };
            filaos.Push(os);

            filaos.Pop();
            filaos.Pop();


            filaos.Imprimir();

            Console.ReadKey();
        }

       
    }
}
