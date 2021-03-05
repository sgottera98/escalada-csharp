using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8
{
    class EX8
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número: ");
            int num = int.Parse(Console.ReadLine());

            int total = num;

            for (int i = num - 1; i >= 1; i--)
            {
                total *= i;
            }
            Console.Write("Fatorial de {0} é {1}", num, total);
            Console.ReadKey();
        }
    }
}
