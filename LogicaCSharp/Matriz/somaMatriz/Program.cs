using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definindo a matriz 4x5
            int[,] matriz = new int[4, 5];

            // Lendo os valores da matriz
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("Digite o valor para a posição [{0},{1}]: ", i, j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Calculando a soma dos elementos de cada coluna
            int[] somaColunas = new int[5];

            for (int j = 0; j < 5; j++)
            {
                int soma = 0;
                for (int i = 0; i < 4; i++)
                {
                    soma += matriz[i, j];
                }
                somaColunas[j] = soma;
            }

            // Exibindo o resultado
            Console.WriteLine("\nSoma dos elementos de cada coluna:");

            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Coluna {0}: {1}", j + 1, somaColunas[j]);
            }
        }
    }
}
