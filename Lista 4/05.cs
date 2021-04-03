using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        /*5) Escreva um programa que leia uma matriz 4 x 5 e ao final exiba a 
        quantidade de números pares, a quantidade de números ímpares, a soma 
        dos números pares, a soma dos números ímpares, a média dos números 
        pares e a média dos números ímpares.*/
        static void Main(string[] args)
        {
            int nLin = 4, nCol = 5;
            int[,] matriz = gerarMatriz(nLin, nCol);
            calculaOperacoes(nLin, nCol, matriz);            
            
            Console.WriteLine();
            Console.ReadKey();
        }

        static int[,] gerarMatriz(int nLin, int nCol) 
        {
            Random rand = new Random();
            int[,] matriz = new int[nLin, nCol];

            for (int i = 0; i < nLin; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    matriz[i, j] = rand.Next(10);
                    Console.Write("{0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }

            return matriz;
        }

        static void calculaOperacoes(int nLin, int nCol, int[,] matriz)
        {
            int qtdPar = 0;
            int qtdImpar = 0;
            int somaPar = 0;
            int somaImpar = 0;
            decimal mediaPar = 0;
            decimal mediaImpar = 0;

            for (int i = 0; i < nLin; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    if (matriz[i, j] % 2 == 0)
                    {
                        qtdPar++;
                        somaPar += matriz[i, j];
                    }
                    else
                    {
                        qtdImpar++;
                        somaImpar += matriz[i, j];
                    }
                }
            }

            mediaPar = Convert.ToDecimal(somaPar) / Convert.ToDecimal(qtdPar);
            mediaImpar = Convert.ToDecimal(somaImpar) / Convert.ToDecimal(qtdImpar);

            Console.WriteLine("Pares:\nQuantidade: {0}\nSoma: {1}\nMédia: {2:f2}", qtdPar, somaPar, mediaPar);
            Console.WriteLine("Ímpares:\nQuantidade: {0}\nSoma: {1}\nMédia: {2:f2}", qtdImpar, somaImpar, mediaImpar);
        }
    }
}
