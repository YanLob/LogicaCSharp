using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continueEBreack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma=0;
            Random gerador = new Random();

            Console.WriteLine("---Continues---");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Digite o {i}° numero: ");
                int num = (int)(gerador.NextDouble()*6+1);
                Console.WriteLine("numero: "+num);
                if (num % 2 != 0)
                {
                    continue;
                }
                soma += num;
                Console.WriteLine("soma: " + soma);
                Console.WriteLine("ABBA");

                if(soma>10) {
                    Console.WriteLine("contunue deu certo");
                    break;
                }
            }
            Console.WriteLine("Encerrado.");
        }
    }
}
