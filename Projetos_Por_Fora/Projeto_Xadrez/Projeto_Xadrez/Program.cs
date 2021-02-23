using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            string quem_comeca;
            string[,] tabuleiro_xadrez = new string[8, 8];

            Console.WriteLine("Quem vai começar a partida? Jogador 1(1) ou jogador 2(2)" +
                "\nSempre começa pela parte de baixo");
            quem_comeca = Console.ReadLine();
            Instrucoes(ref quem_comeca);
            
            Inicia_Tabuleiro(tabuleiro_xadrez);
            Imprime_tabuleiro(tabuleiro_xadrez);
            Mover_peca(tabuleiro_xadrez, ref quem_comeca);

            Console.ReadKey();
        }

        static void Instrucoes(ref string quem_comeca) 
        {
            
            Console.WriteLine("\nJOGO DE XADREZ" +
                "INSTRUÇÕES:\n" +
                "1)T = TORRE\n" +
                "2)C = CAVALO\n" +
                "3)B = BISPO\n" +
                "4)Q = RAINHA\n" +
                "5)R = REI\n" +
                "6)P = PEÕES\n");

            Console.ReadLine();            

            if(quem_comeca == "1")
            {
                Console.Clear();
                Console.WriteLine("\t--------------JOGADOR 1 (BRANCAS)--------------");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\t--------------JOGADOR 2 (BRANCAS)--------------");
            }
            
        }
        static void Inicia_Tabuleiro(string[,] tabuleiro_xadrez)
        {
            for (int linha = 0; linha < tabuleiro_xadrez.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < tabuleiro_xadrez.GetLength(1); coluna++)
                {
                    tabuleiro_xadrez[linha, coluna] = ".";
                }
            }
            posicoes_inicias_de_pecas(tabuleiro_xadrez);
            Console.WriteLine("");
        }
        static void posicoes_inicias_de_pecas(string[,] tabuleiro_xadrez)
        {

            //TORRES
            tabuleiro_xadrez[0, 0] = "T";
            tabuleiro_xadrez[0, 7] = "T";
            tabuleiro_xadrez[7, 0] = "T";
            tabuleiro_xadrez[7, 7] = "T";
            //REI
            tabuleiro_xadrez[0, 4] = "R";
            tabuleiro_xadrez[7, 4] = "R";
            //Rainha
            tabuleiro_xadrez[0, 3] = "Q";
            tabuleiro_xadrez[7, 3] = "Q";
            //Bispo
            tabuleiro_xadrez[0, 5] = "B";
            tabuleiro_xadrez[0, 2] = "B";
            tabuleiro_xadrez[7, 2] = "B";
            tabuleiro_xadrez[7, 5] = "B";
            //Cavalo
            tabuleiro_xadrez[0, 1] = "C";
            tabuleiro_xadrez[0, 6] = "C";
            tabuleiro_xadrez[7, 6] = "C";
            tabuleiro_xadrez[7, 1] = "C";
            //Peoes
            for (int l = 1; l < 2; l++)
            {
                for (int c = 0; c < tabuleiro_xadrez.GetLength(1); c++)
                {
                    tabuleiro_xadrez[l, c] = "P";
                }
            }
            for (int l = 6; l < 7; l++)
            {
                for (int c = 0; c < tabuleiro_xadrez.GetLength(1); c++)
                {
                    tabuleiro_xadrez[l, c] = "P";

                }
            }


        }
        static void Imprime_tabuleiro(string[,] tabuleiro_xadrez)
        {
            for (int linha = 0; linha < tabuleiro_xadrez.GetLength(0); linha++)
            {
                Console.WriteLine();
                Console.WriteLine();
                for (int coluna = 0; coluna < tabuleiro_xadrez.GetLength(1); coluna++)
                {
                    if (coluna == 0)
                    {
                        Console.Write("\t   " + tabuleiro_xadrez[linha, coluna]);
                    }
                    else
                    {
                        Console.Write("  |  " + tabuleiro_xadrez[linha, coluna]);
                    }
                }
            }
        }

        static void Mover_peca(string[,] tabuleiro_xadrez, ref string quem_comeca)
        {
            string peca;            
            peca = Console.ReadLine();

            if(quem_comeca == "1")
            {
                Console.WriteLine("\tJogador 1\nInforme a peça que você quer mover");
            }

        }

    }
}
