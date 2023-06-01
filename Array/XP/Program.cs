using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] X = new int[10];
            int numero;

            string id;
            bool resp = true;

            for (int i = 0; i < X.Length; i++)
            {
                Console.Write($"digite o {i+1}° valor: ");
                X[i] = Convert.ToInt32(Console.ReadLine());
            }

            do
            {
                Console.Write("Tente encontrar um valor usando de um número de 0 a 9: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 0 || numero > 9)
                {
                    Console.WriteLine("Digite um valor certo!");
                }
                else
                {
                    Console.WriteLine($"O valor na posição que foi informada é {X[numero]}");
                }
                Console.WriteLine("Deseja continuar? [S]/[N]");
                id = Console.ReadLine().ToUpper();

                if (id.Equals("N"))
                {
                    resp = false;
                }

                Console.Clear();

            } while (resp == true);

            Console.WriteLine("Programa Finalizado!");

        }
    }
}
