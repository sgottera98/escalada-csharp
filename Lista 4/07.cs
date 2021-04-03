using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Linha = 2, Coluna = 3;
            string[] alunos = new string[Linha];
            double[,] notas = new double[Linha, Coluna];
            double[] media = new double[Linha];
            double[] somaNotas = new double[Linha];
            int i, l, c;

            //Nome dos Alunos
            for (i = 0; i < Linha; i++)
            {
                Console.Write("Digite o nome do {0}° aluno: ", i + 1);
                alunos[i] = Console.ReadLine();
            }

            Console.WriteLine();
            //Notas dos alunos
            for (l = 0; l < Linha; l++)
            {
                Console.WriteLine("\nNOTAS DO {0}° ALUNO ", l + 1);
                for (c = 0; c < Coluna; c++)
                {
                    Console.Write("Digite a nota da P{0}: ", c + 1);
                    notas[l, c] = double.Parse(Console.ReadLine());
                    somaNotas[l] += notas[l, c];
                }
                media[l] = somaNotas[l] / Coluna;
                for (i = 0; i < Linha; i++)
                {
                    if (media[i] >= 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                }

            }

            Console.WriteLine();
            Console.WriteLine("\nAlunos \t\tNota1 \t\tNota2 \t\tNota3 \t\tMédia \n");
            for (l = 0; l < Linha; l++)
            {
                Console.Write(alunos[l]);
                for (c = 0; c < Coluna; c++)
                {
                    Console.Write("\t\t{0} ", notas[l, c]);
                }
                Console.Write("\t\t{0:N1} ", media[l]);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
