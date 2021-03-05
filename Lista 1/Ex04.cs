using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Ex04
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Informe o número b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Informe o número c: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("a² * 5 - c / (b - a % 4) = {0}", (Math.Pow(a,2) * 5 - c / (b - a % 4)));
            Console.ReadKey();        }
    }
}
