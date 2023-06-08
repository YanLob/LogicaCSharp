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
            int[,] array = new int[4, 5];
            int soma = 0, num;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("--------------------");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("digite um valor: ");
                    num = Convert.ToInt32(Console.ReadLine());

                    soma = soma + num;
                }
                
            }

            Console.WriteLine("A soma das colunas sao" + soma);
        }
    }
}
