using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, num2;

            Console.Write("Digite um valor: ");
            num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite outro valor: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{num} + {num2} = {num + num2}");
            Console.WriteLine($"{num} - {num2} = {num - num2}");
            Console.WriteLine($"{num} x {num2} = {num * num2}");
            Console.WriteLine($"{num} / {num2} = {num / num2}");

        }
    }
}
