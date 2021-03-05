using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Ex09
    {
        static void Main(string[] args)
        {
            Console.Write("Informe W: ");
            int w = int.Parse(Console.ReadLine());
            Console.Write("Informe X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Informe Y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Informe Z: ");
            int z = int.Parse(Console.ReadLine());
            
            Console.WriteLine(" {0} ", ((x >= y) && (z <= x)) || ((x == w) && (y == z)) || (!(x != w)));
            Console.ReadKey();
        }
    }
}
