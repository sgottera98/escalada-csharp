using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class EX3
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, (num * i));
            }
            Console.ReadKey();
        }
    }
}
