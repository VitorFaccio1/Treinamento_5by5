using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio2_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listaTelefonica = new List<Pessoa>();
            Lertxt(listaTelefonica);
            Menu(listaTelefonica);
            Console.ReadKey();
        }
        static void Menu(List<Pessoa> listaTelefonica)
        {
            Pessoa person = new Pessoa();

            string escolha;
            do
            {
                Console.WriteLine("\nInsira o que voce quer fazer?\n" +
                    "1)Inserir\n" +
                    "2)Remover\n" +
                    "3)Localizar\n" +
                    "4)Imprimir contatos\n" +
                    "5)Imprimir SOMENTE um contato\n" +
                    "6)Quantidade de contatos\n" +
                    "0)SAIR\n");
                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        {
                            listaTelefonica = Inserir(listaTelefonica);
                            EscreverTxt(listaTelefonica);
                            break;
                        }
                    case "2":
                        {
                            Remover(listaTelefonica, person);
                            EscreverTxt(listaTelefonica);
                            break;
                        }
                    case "3":
                        {
                            Localizar(listaTelefonica);
                            break;
                        }
                    case "4":
                        {
                            Imprimir(listaTelefonica);
                            break;
                        }
                    case "5":
                        {
                            Print1a1(listaTelefonica);
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine(listaTelefonica.Count());
                            break;
                        }


                }
            } while (escolha != "0");
        }
        static List<Pessoa> Inserir(List<Pessoa> listaTelefonica)
        {

            Pessoa person = new Pessoa();

            string nome, adicionar, tipo, numero, ddd;

            do
            {
                Console.WriteLine("Informe o nome do contato: ");
                nome = Console.ReadLine();
                Console.WriteLine("Qual o DDD? ");
                ddd = Console.ReadLine();
                Console.WriteLine("Qual o Numero? ");
                numero = Console.ReadLine();
                Console.WriteLine("Informe o tipo do contato: ");
                tipo = Console.ReadLine();

                person = new Pessoa
                {
                    Nome = nome,
                    telefone = new Telefone[]
                        {
                            new Telefone
                            {
                                DDD = ddd, Numero = numero, Tipo = tipo
                            }
                        }
                };
                listaTelefonica.Add(person);
                listaTelefonica = listaTelefonica.OrderBy(p => p.Nome).ToList();
                Console.WriteLine("\nContato inserido com sucesso");
                Console.WriteLine("\nVocê quer adicionar mais algum contato? S ou N");
                adicionar = Console.ReadLine().ToUpper();

            } while (adicionar.ToUpper() != "N");
            return listaTelefonica;
        }
        static Pessoa Localizar(List<Pessoa> listaTelefonica)
        {
            string nome;

            Pessoa encontrado = new Pessoa();

            if (listaTelefonica.Count == 0)
            {
                Console.WriteLine("\nInsira contatos antes de tentar localizar!\n");
            }
            else
            {
                Console.WriteLine("Informe o nome do contato que você quer localizar: ");
                nome = Console.ReadLine().ToLower();


                encontrado = listaTelefonica.Find(i => i.Nome.ToLower() == nome.ToLower());

                if (encontrado != null)
                {
                    Console.WriteLine("O contato foi encontrado\n" + encontrado.ToString());
                }
                else
                {
                    Console.WriteLine("Nao foi encontrado nenhum contato com esse nome");
                }
            }
            return encontrado;
        }
        static void Remover(List<Pessoa> listaTelefonica, Pessoa person)
        {

            string resposta;
            if (listaTelefonica.Count == 0)
            {
                Console.WriteLine("\nInsira contatos antes de tentar remover!\n");
            }
            else
            {
                person = Localizar(listaTelefonica);

                Console.WriteLine("\nCerteza que deseja excluir esse contato? S ou N");
                resposta = Console.ReadLine().ToLower();

                if (resposta.ToLower() == "s")
                {
                    listaTelefonica.Remove(person);
                    Console.WriteLine("\nContato removido com sucesso!\n");
                }
                else
                    Console.WriteLine("\nVocê nao possui esse contato\n");
            }
        }
        static void Imprimir(List<Pessoa> listaTelefonica)
        {
            if (listaTelefonica.Count == 0)
            {
                Console.WriteLine("\nSua lista de contatos esta vazia");
            }
            else
                listaTelefonica.ForEach(i => Console.WriteLine(i));

        }
        static void Print1a1(List<Pessoa> listaTelefonica)
        {


            if (listaTelefonica.Count == 0)
            {
                Console.WriteLine("\nVocê nao tem contatos na sua lista!\n");
            }
            else
            {

                for (int i = 0; i < listaTelefonica.Count; i++)
                {
                    string resposta;
                    Console.WriteLine(listaTelefonica[i].ToString());
                    Console.WriteLine("Quer continuar imprimindo?");
                    resposta = Console.ReadLine().ToLower();
                    if (resposta == "n")
                    {
                        break;
                    }
                    else
                    {

                    }

                }

            }

        }
        static void EscreverTxt(List<Pessoa> listaTelefonica)
        {
            using (StreamWriter escreverTxt = new StreamWriter("contatos.txt"))
            {
                for (int i = 0; i < listaTelefonica.Count; i++)
                {
                    escreverTxt.WriteLine("Nome:" + listaTelefonica[i].Nome);
                    foreach (Telefone telefone in listaTelefonica[i].telefone)
                    {
                        escreverTxt.WriteLine("DDD:" + telefone.DDD + "\nNumero:" + telefone.Numero + "\nTipo:" + telefone.Tipo);
                    }
                    escreverTxt.WriteLine("-:");
                }

            }
        }
        static void Lertxt(List<Pessoa> listaTelefonica)
        {
            if (File.Exists("contatos.txt"))
            {
                using (StreamReader stream = new StreamReader("contatos.txt"))
                {
                    string[] campos;
                    string linha;
                    string numero = "", ddd = "", tipo = "";
                    Pessoa person = new Pessoa();

                    while ((linha = stream.ReadLine()) != null)
                    {
                        campos = linha.Split(':');

                        if (campos[0] == "Nome")
                        {
                            person.Nome = campos[1];
                        }
                        else if (campos[0] == "DDD")
                        {
                            ddd = campos[1];
                        }
                        else if (campos[0] == "Numero")
                        {
                            numero = campos[1];
                        }
                        else if (campos[0] == "Tipo")
                        {
                            tipo = campos[1];

                            person.telefone = new Telefone[] { new Telefone() { DDD = ddd, Numero = numero, Tipo = tipo } };
                            listaTelefonica.Add(person);
                        }
                        else if (campos[0] == "-")
                        {
                            person = new Pessoa();
                        }
                    }
                }
            }                                    
        }
    }
}
