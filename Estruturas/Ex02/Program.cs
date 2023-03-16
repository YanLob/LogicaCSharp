using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o terceiro número:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"O maior número é {num1}");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"O maior número é {num2}");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine($"O maior número é {num3}");
            }
            else
            {
                Console.WriteLine("Os valores são iguais");
            }
            Console.ReadLine();
        }
    }
}
