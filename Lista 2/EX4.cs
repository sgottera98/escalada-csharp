using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04
{
    class EX04
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número mínimo: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Informe o número máximo: ");
            int max = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = max; i >= min; i--)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
