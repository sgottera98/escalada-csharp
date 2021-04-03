using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        /*6) Escreva um programa que armazene (através do método Random) 
        os números de 1 a 25 em uma matriz 5x5 e ao final exiba apenas 
        os valores das diagonais e a soma desses valores:*/
        static void Main(string[] args)
        {
            const int nLin = 5, nCol = 5;
            int[,] matriz = gerarLista(nLin, nCol);
            somaDiagonalPrincipal(nLin, matriz);
            somaDiagonalSecundaria(nLin, matriz);

            Console.ReadKey();
        }

        static int[,] gerarLista(int nLin, int nCol)
        {
            int[,] matriz = new int[nLin, nCol];
            Random numRand = new Random();

            Console.WriteLine("Matriz");
            for (int i = 0; i < nLin; i++)
            {
                for (int j = 0; j < nLin; j++)
                {
                    matriz[i, j] = numRand.Next(1, 26);
                    Console.Write("{0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }

            return matriz;
        } 

        static void somaDiagonalPrincipal(int nLin, int[,] matriz)
        {
            int somaDiagonal = 0;

            Console.WriteLine("\nDiagonal Principal");
            for (int i = 0; i < nLin; i++)
            {
                somaDiagonal += matriz[i, i];
                Console.Write("{0} ", matriz[i, i]);
            }

            Console.Write("\nSoma da diagonal principal: {0} ", somaDiagonal);
        }

         static void somaDiagonalSecundaria(int nLin, int[,] matriz)
        {
            int somaDiagonal = 0;

            Console.WriteLine("\nDiagonal Secundária");
            for (int i = (nLin - 1) ; i >= 0 ; i--)
            {
                somaDiagonal += matriz[i, ((-i) + (nLin - 1))];
                Console.Write("{0} ", matriz[i, ((-i) + (nLin - 1))]);
            }

            Console.Write("\nSoma da diagonal secundária: {0} ", somaDiagonal);
        }
    }
}
