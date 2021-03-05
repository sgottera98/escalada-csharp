using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX9
{
    class EX9
    {
        static void Main(string[] args)
        {
            int countImp = 0;
            int countPar = 0;
            int countPos = 0;
            int countNeg = 0;
            String op;
            bool test = true;

            while (test)
            {
                Console.Write("Informe um número: ");
                double n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    countPar++;
                }
                else
                {
                    countImp++;
                }
                if (n >= 0)
                {
                    countPos++;
                }
                else
                {
                    countNeg++;
                }

                Console.WriteLine("Deseja encerrar o programa? S/N");
                op = (Console.ReadLine());

                test = op == "s" || op == "S" ? false : true;
            }
            Console.WriteLine("Números pares {0}\nNúmeros ímpares {1}\nNúmeros positivos {2}\nNúmeros negativos {3}", countPar, countImp, countPos, countNeg);
            Console.ReadKey();
        }
    }
}
