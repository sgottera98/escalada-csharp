using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Ex06
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a cotação do dólar($): ");
            float cotation = float.Parse(Console.ReadLine());
            Console.Write("Informe o valor em reais(R$): ");
            float real = float.Parse(Console.ReadLine());

            Console.WriteLine("Valor convertido em dólares: {0}", (real / cotation));
            Console.ReadKey();
        }
    }
}
