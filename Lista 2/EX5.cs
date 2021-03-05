using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class EX5
    {
        static void Main(string[] args)
        {
            int num1 = 0;

            for (int i = 1; i <= 15; i++)
            {
                Console.Write("Informe o {0}° número: ", i);
                int num2 = int.Parse(Console.ReadLine());

                if (num2 > num1)
                {
                    num1 = num2;
                }
            }
            Console.Write("O maior número digitado foi o {0}.", num1);
            Console.ReadKey();
        }
    }
}
