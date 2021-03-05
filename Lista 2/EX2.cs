using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class EX2
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número máximo: ");
            int max = int.Parse(Console.ReadLine());
            Console.Write("Informe o número mínimo: ");
            int min = int.Parse(Console.ReadLine());

            for (int i = max; i >= min; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
