using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucao_Henrique
{
    public class ListaContatos
    {
        public Contato Primeiro { get; private set; }
        public Contato Ultimo { get; private set; }
        public int Quantidade { get; private set; }
        public bool EhVazia => Quantidade == 0;

        public void Inserir(Contato contato)
        {
            if (EhVazia)
            {
                // Insere no inicio da lista
                Primeiro = contato;
                Ultimo = contato;
            }
            else
            {
                if (contato.Nome.CompareTo(Ultimo.Nome) >= 0)
                {
                    // Insere no final da lista
                    Ultimo.Proximo = contato;
                    Ultimo = contato;
                }
                else
                {
                    if (contato.Nome.CompareTo(Primeiro.Nome) < 0)
                    {
                        // Insere no inicio da lista                        
                        contato.Proximo = Primeiro;
                        Primeiro = contato;
                    }
                    else
                    {
                        // Insere no meio da lista
                        Contato aux = Primeiro;
                        do
                        {
                            if (contato.Nome.CompareTo(aux.Proximo.Nome) < 0)
                            {
                                contato.Proximo = aux.Proximo;
                                aux.Proximo = contato;
                                break;
                            }

                            aux = aux.Proximo;
                        }
                        while (true);
                    }
                }
            }

            Console.WriteLine($"{contato.Nome} inserido com sucesso");
            Quantidade++;
        }

        public void Remover(string nome)
        {
            if (EhVazia)
            {
                Console.WriteLine("Você não possui contatos para remover.");
            }
            else
            {
                Localizar(nome);

                Console.WriteLine("");
                Console.Write($"Confirma a exclusão do contato: {nome}? (S/N)");
                string excluir = Console.ReadLine().ToUpper();

                if (excluir == "S")
                {

                    Contato contato = Primeiro;
                    //Verificar se é o primeiro contato

                    if (Primeiro.Nome.ToLower() == nome.ToLower())
                        Primeiro = Primeiro.Proximo;
                    else
                    {
                        do
                        {
                            if (contato.Proximo != null && contato.Proximo.Nome.ToLower() == nome.ToLower())
                            {
                                Contato aux = contato.Proximo;
                                contato.Proximo = aux.Proximo;

                                break;
                            }

                            contato = contato.Proximo;
                        }
                        while (true);
                    }

                    Quantidade--;
                }
            }
        }

        public void Localizar(string nome)
        {
            bool achou = false;
            Contato encontrado = Primeiro;
            do
            {
                if (encontrado.Nome.ToLower() == nome.ToLower())
                {
                    achou = true;
                    break;
                }

                if (encontrado.Proximo == null)
                    break;

                encontrado = encontrado.Proximo;
            }
            while (!achou);

            if (achou)
            {
                Console.WriteLine($"Contato encontrado: {encontrado}");
            }
            else
            {
                Console.WriteLine("Não foi encontrado esse contato.");
            }
        }

        public void ImprimirListaCompleta()
        {
            if (EhVazia)
            {
                Console.WriteLine("Você não possui contatos para imprimir.");
            }
            else
            {
                Contato contato = Primeiro;
                do
                {
                    Console.WriteLine(contato);

                    contato = contato.Proximo;
                }
                while (contato != null);
            }
        }

        public void ImprimirUmAUm()
        {
            if (EhVazia)
            {
                Console.WriteLine("Você não possui contatos para imprimir.");
            }
            else
            {
                string imprimeProximo = "N";
                Contato contato = Primeiro;

                do
                {
                    if (contato == null)
                        break;

                    Console.WriteLine(contato);
                    contato = contato.Proximo;

                    Console.WriteLine("");
                    Console.Write("Deseja imprimir o próximo contato (S/N): ");
                    imprimeProximo = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                while (imprimeProximo == "S");
            }
        }
    }

}
