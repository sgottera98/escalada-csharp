using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        //2) Escreva um programa que leia um vetor de 15 notas de alunos de uma 
        //   turma e ao final calcule e exiba a média e a quantidade de alunos 
        //   que estão com nota acima da média e a quantidade de alunos que
        //   estão com nota abaixo e acima da média.
        static void Main(string[] args)
        {
            double[] lista = new double[15];
            int countPlus = 0;
            int countMinus = 0;

            lista = gerarLista(lista);

            double media = lista.Sum() / lista.Length;
            Console.WriteLine("Média das notas: {0:F2}", media);

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] > media)
                {
                    countPlus++; 
                } else
                {
                    countMinus++;
                }
            }

            Console.WriteLine("Quantidade de notas acima da média: {0}", countPlus);
            Console.WriteLine("Quantidade de notas abaixo da média: {0}", countMinus);

            Console.ReadKey();
        }

        static double[] gerarLista(double[] lista)
        {
            Random randNum = new Random();

            Console.WriteLine("Notas:");
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = randNum.Next(10);
                Console.WriteLine("{0}) {1} ", (i + 1), lista[i]);
            }
            return lista;
        }

 
    }
}
