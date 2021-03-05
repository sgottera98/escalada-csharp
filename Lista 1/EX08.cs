using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o numero para a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Informe o numero para b: ");
            int b = int.Parse(Console.ReadLine());
            int c = b;

            b = a;
            a = c;
                  
            Console.WriteLine("a agora é {0} e b agora é {1}", a, b );
            Console.ReadKey();
        }
    }
}
