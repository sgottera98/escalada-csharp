using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        //3) Escreva um programa que leia o nome e o preço de 10 produtos.
        //Logo após realizar o cadastro dos produtos, pedir para o usuário 
        //digitar um valor.Deverá ser realizada uma pesquisa nos valores 
        //dos produtos deverão ser exibidos apenas os produtos que possuem 
        //preço até o valor digitado pelo usuário.
        static void Main(string[] args)
        {            
            const int nLinha = 10, nColuna = 2;
            string[,] produtos = gerarProdutos(nLinha, nColuna);
            filtraPrecos(produtos, nLinha);
            Console.ReadKey();
        }

        static string[,] gerarProdutos(int nLinha, int nColuna)
        {
            string[,] produtos = new string[nLinha, nColuna];
            
            for (int i = 0; i < nLinha ; i++)
            {              
                Console.Write("Informe o nome do {0}° produto: ", (i + 1));
                string produto = Console.ReadLine();
                Console.Write("Informe o preço do {0}° produto: ", (i + 1));
                string preco = Console.ReadLine();
                Console.WriteLine();
                produtos[i, 0] = produto;
                produtos[i, 1] = preco;
            }

            return produtos;
        }

        static void filtraPrecos(string[,] produtos, int nLinha)
        {
            Console.Write("Informe o preço limite para pesquisa: ");
            double precoLimite = Double.Parse(Console.ReadLine());

            Console.Write("\nProdutos mais baratos do que o valor informado: \n");
            for (int i = 0; i < nLinha; i++)
            {
                if (Convert.ToDouble(produtos[i, 1]) <= precoLimite)
                {
                    Console.WriteLine("{0} - {1}", produtos[i, 0], produtos[i, 1]);
                }
            }
        }
    }
}
