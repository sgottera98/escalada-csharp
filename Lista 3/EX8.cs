using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8
{
    class EX8
    {
        static void Main(string[] args)
        {
            Console.Write("CÁLCULO DA HIPOTENUSA\nInforme o valor da base: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor da altura: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor da hipotenusa: {0}", hipotenusa(x, y));
            Console.ReadKey();
        }

        static double hipotenusa(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }
}
