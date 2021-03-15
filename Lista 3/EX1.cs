using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Ex1
    {
        static void Main(string[] args)
        {
            Console.Write("Informe seu nome: ");
            String nome = Console.ReadLine();
            Console.Write("Informe sua 1ª nota: ");
            float nota1 = lerNota();
            Console.Write("Informe sua 2ª nota: ");
            float nota2 = lerNota();

            Console.WriteLine("{0}, sua média das notas {1} e {2} é de {3}.", nome, nota1, nota2, calcularMedia(nota1, nota2));

            Console.ReadKey();
        }

        static float lerNota()
        {
            return float.Parse(Console.ReadLine()); 
        }

        static float calcularMedia(float nota1, float nota2)
        {
            return (nota1 + nota2) / 2;
        }
    }
}
