using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class EX6
    {
        static void Main(string[] args)
        {
            int count = 1;
            double total = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Informe a {0}ª nota: ", i);
                double nota = double.Parse(Console.ReadLine());

                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("Nota incorretamente informada, por favor, digite uma nota válida entre 0 e 10.");
                }
                else
                {
                    total += nota;
                    count++;
                }
            }
            Console.Write("Média total das notas válidas: {0}.", (total / count));
            Console.ReadKey();
        }
    }
}
