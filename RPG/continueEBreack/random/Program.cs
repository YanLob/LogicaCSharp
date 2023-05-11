using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int cont = 0;
            while (true)
            {
                int num = gerador.Next(1,1500);
                Console.WriteLine(num);
                cont++;
                if (num == 1)
                {
                    Console.WriteLine("Num caiu em 1376");
                    Console.WriteLine($"Foram {cont} numeros para chegar no numero 1376!!!");
                    break;
                }
            }
            Console.WriteLine("Encerrado.");
            Console.ReadLine();
        }
    }
}
