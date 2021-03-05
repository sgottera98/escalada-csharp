using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Ex07
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um primeiro nome: ");
            String name1 = (Console.ReadLine());
            Console.Write("Informe um segundo nome: ");
            String name2 = (Console.ReadLine());

            Console.WriteLine("{0} {1}", name1.ToUpper(), name2.ToUpper());

            Console.WriteLine("{0} {1}", name1.Length, name2.Length);

            Console.WriteLine("{0} {1}", name1.Substring(0, 3), name2.Substring(0, 3));
            Console.ReadKey();
        }
    }
}
