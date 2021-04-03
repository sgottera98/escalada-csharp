using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    //1) Escreva um programa que leia um vetor de 15 números inteiros e exiba ao 
    //final apenas os números que estão armazenados nas posições pares do vetor.
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = new int[15];
            gerarLista(lista);
            indicesPares(lista);
           
            Console.ReadKey();
        }

        static int[] gerarLista(int[] lista)
        {
            Random randNum = new Random();

            
            for(int i = 0; i < lista.Length; i++)
            {
                lista[i] = randNum.Next(100);
                Console.WriteLine("{0}) {1} ", (i + 1), lista[i]);
            }

            return lista;
        }

        static void indicesPares(int[] lista)
        {
            Console.WriteLine("Valores nos índices pares");
            for (int i = 0; i < lista.Length; i++)
            {
                if((i + 1) % 2 == 0)
                {
                    Console.WriteLine("{0}) {1} ", (i + 1), lista[i]);
                }
            }
        }
    }
}
