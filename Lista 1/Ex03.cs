using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Ex03
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("o quadrado de {0} é {1}", number, Math.Pow(number,2));
            Console.ReadKey();
        }
    }
}
