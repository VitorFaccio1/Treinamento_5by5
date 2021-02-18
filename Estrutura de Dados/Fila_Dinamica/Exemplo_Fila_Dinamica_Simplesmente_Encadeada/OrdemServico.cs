using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Fila_Dinamica_Simplesmente_Encadeada
{
    class OrdemServico
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data_Criacao { get; set; }
        public int Prazo { get; set; }
        public OrdemServico Proximo { get; set; }

        public override string ToString()
        {
            return $"\n----------DADOS DA ORDEM DE SERVIÇO----------" +
                   $"\nNumero da Ordem: {Numero}" +
                   $"\nTipo: {Tipo}" +
                   $"\nDescrição: {Descricao}" +
                   $"\nData de criação: {Data_Criacao}" +
                   $"\nPrazo: {Prazo} dias";
        }
    }
}
