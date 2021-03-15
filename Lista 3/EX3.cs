using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    class EX3
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o número 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("A diferença entre os números {0} e {1} é de {2}", num1, num2, diferenca(num1, num2));

            Console.ReadKey();
        }

        static int diferenca( int n1, int n2)
        {
            return System.Math.Abs(n1 - n2);
        }
    }
}
