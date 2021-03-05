using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Ex05
    {
        static void Main(string[] args)
        {
            Console.Write("Informe sua idade: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", (year >= 18 ? "Maior de idade" : "Menor de idade"));
            Console.ReadKey();

        }
    }
}
