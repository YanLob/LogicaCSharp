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
            Console.WriteLine("---Continues---");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Digite um número: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num<=16 || num>=20) {
                    continue;
                }
                Console.WriteLine("Número entre 10 e 20!!!");
                if (num==15)
                {
                    Console.WriteLine("Esse numero é 15!");
                    break;
                }
                else
                {

                    Console.WriteLine("numero: "+ num);
                }
            }
            Console.WriteLine("Encerrado.");
        }
    }
}
