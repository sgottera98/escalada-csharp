using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Program
    {
        /*Escreva um programa que leia uma matriz 5x5 números inteiros e exiba ao final:
            a) A soma de todos os elementos da matriz;
            b) A soma dos valores dos elementos de cada linha da matriz.*/
        static void Main(string[] args)
        {
            int nLin = 5, nCol = 5;
            int[,] matriz = gerarLista(nLin, nCol);
            somaMatriz(matriz, nLin);
            somaLinhaMatriz(matriz, nLin);

            Console.ReadKey();
        }

        static int[,] gerarLista(int nLin, int nCol)
        {
            int[,] matriz = new int[nLin, nCol];

            Console.WriteLine("Matriz\n");

            for (int i = 0; i < nLin; i++)
            {
                for (int j = 0; j < nLin; j++)
                {                    
                    matriz[i, j] = numeroAleatorio(j == 0 ? matriz[i, j] : matriz[i, j-1]);
                    Console.Write("{0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }

            return matriz;
        }

        static int numeroAleatorio(int numMatriz)
        {
            Random rand = new Random();
            int numRand = rand.Next(25);
            if (numRand == numMatriz)
            {
                return (numeroAleatorio(numMatriz));
            }
            else
            {
                return numRand;
            }
        }

        static void somaMatriz(int[,] matriz, int nLin)
        {
            int sum = 0;

            for (int i = 0; i < nLin; i++)
            { 
                for (int j = 0; j < nLin; j++)
                {
                    sum += matriz[i, j];                   
                }                
            }

            Console.WriteLine("\nA soma dos números da matriz é de {0}.\n", sum);
        }

        static void somaLinhaMatriz(int[,] matriz, int nLin)
        {

            for (int i = 0; i < nLin; i++)
            {
                int sum = 0;

                for (int j = 0; j < nLin; j++)
                {
                    sum += matriz[i, j];
                }
            Console.WriteLine("A soma dos números de cada linha da matriz é de {0}.\n", sum);
            }
        }
    }
}
