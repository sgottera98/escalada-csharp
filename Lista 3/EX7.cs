using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX7
{
    class EX7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quadrantes.");
            Console.Write("Informe o eixo x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Informe o eixo y: ");
            double y = double.Parse(Console.ReadLine());

            int quad = 0;

            Console.WriteLine("Quadrante {0}", verificaQuadrante(x, y, quad));
            Console.ReadKey();
        }

        static int verificaQuadrante(double x, double y, int quad)
        {
            if (x >= 0 && y >=0)
            {
                quad = 1;
            } else if (x >= 0 && y < 0)
            {
                quad = 4;
            } else if (x < 0 && y < 0)
            {
                quad = 3;
            } else if (x < 0 && y >= 0)
            {
                quad = 2;
            }

            return quad;
        }
    }
}
