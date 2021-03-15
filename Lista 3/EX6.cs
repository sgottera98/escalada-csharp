using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6
{
    class EX6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CÁLCULO PARA PESO IDEAL.");
            Console.Write("Informe seu sexo (F/M): ");
            String gender = Console.ReadLine().ToUpper();
            Console.Write("Informe sua altura: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("O peso ideal para você é de {0:N}kg", calcularPesoIdeal(gender, height));

            Console.ReadKey();
        }

        static double calcularPesoIdeal(String gender, double height)
        {
            double total = gender == "F" ?
                (62.1 * height) - 44.7
                :
                (72.7 * height) - 58;

            return total;
        }
    }
}
