using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    class EX2
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Fatorial de {0}: {1}", numero, calcularFatorial(numero));
            Console.ReadKey();
        }

        static int calcularFatorial(int n)
        {
            int total = n;

            for (int i = n - 1; i >= 1; i--)
            {
                total *= i;
            }

            return total;
        }
    }
}
