using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5
{
    class EX5
    {
        /*Escreva um programa que exiba o seguinte menu e 
        crie um método para realizar os cálculos de cada 
        item deste menu:
        1 – Soma
        2 – Subtração 
        3 – Divisão
        4 – Multiplicação
        5 – Resto da Divisão 
        6 – Dobro
        7 – Quadrado
        8 – Cubo
        9 – Raiz Quadrada 
        0 – Sair*/

        static void Main(string[] args)
        {
            Console.WriteLine("1 – Soma\n2 – Subtração\n3 – Divisão\n4 – Multiplicação\n5 – Resto da Divisão\n6 – Dobro\n7 – Quadrado\n8 – Cubo\n9 – Raiz Quadrada\n0 – Sair\nInforme a operação a ser realizada: ");
            int operation = int.Parse(Console.ReadLine());
            Console.Write("Informe o 1° número do cálculo: ");
            float number1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o 2° número do cálculo: ");
            float number2 = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.Write("O resultado foi de {0}.", soma(number1, number2));
                    break;
                case 2:
                    Console.Write("O resultado foi de {0}.", sub(number1, number2));
                    break;
                case 3:
                    Console.Write("O resultado foi de {0}.", div(number1, number2));
                    break;
                case 4:
                    Console.Write("O resultado foi de {0}.", multi(number1, number2));
                    break;
                case 5:
                    Console.Write("O resultado foi de {0}.", resto(number1, number2));
                    break;
                case 6:
                    Console.Write("O resultado foi de {0}.", dobro(number1));
                    break;
                case 7:
                    Console.Write("O resultado foi de {0}.", quad(number1));
                    break;
                case 8:
                    Console.Write("O resultado foi de {0}.", cubo(number1));
                    break;
                case 9:
                    Console.Write("O resultado foi de {0}.", raiz(number1));
                    break;
                case 0:
                    break;
            }

            Console.ReadKey();
        }

        static float soma (float n1, float n2)
        {
            return n1 + n2;
        }
        static float sub(float n1, float n2)
        {
            return n1 - n2;
        }
        static float div(float n1, float n2)
        {
            return (n2 == 0 ? n1 / n2 : 0);
        }
        static float multi(float n1, float n2)
        {
            return n1 * n2;
        }
        static float resto(float n1, float n2)
        {
            return n1 % n2;
        }
        static float dobro(float n1)
        {
            return n1 * 2;
        }
        static float quad(float n1)
        {
            return (float)Math.Pow( n1 , 2 );
        }
        static float cubo(float n1)
        {
            return (float)Math.Pow(n1, 3);
        }
        static float raiz(float n1)
        {
            return (float)Math.Sqrt(n1);
        }

    }
}
