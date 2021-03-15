using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4
{
    class EX4
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o lado 1: ");
            float lado1 = float.Parse(Console.ReadLine());
            Console.Write("Informe o lado 2: ");
            float lado2 = float.Parse(Console.ReadLine());
            Console.Write("Informe o lado 3: ");
            float lado3 = float.Parse(Console.ReadLine());

            if (lado1 < lado2 + lado3 && lado2 < lado3 + lado1 && lado3 < lado1 + lado2)
            {
                if (equilatero(lado1, lado2, lado3))
                {
                    Console.Write("É equilátero.");
                } else if (isosceles(lado1, lado2, lado3))
                {
                    Console.Write("É isósceles.");
                } else
                {
                    Console.Write("É escaleno.");
                }
            } else
            {
                Console.WriteLine("Triângulo fora das dimensões possíveis.");
            }

            Console.ReadKey();
        }

        static bool equilatero (float l1, float l2, float l3)
        {
            bool isTrue = l1 == l2 && l2 == l3 ? true : false;
            return isTrue;
        }

        static bool isosceles(float l1, float l2, float l3)
        {
            bool isTrue = l1 == l2 || l2 == l3 || l3 == l1  ? true : false;
            return isTrue;
        }

        static bool escaleno(float l1, float l2, float l3)
        {
            bool isTrue = l1 == l2 && l2 == l3 ? true : false;
            return isTrue;
        }
    }
}
