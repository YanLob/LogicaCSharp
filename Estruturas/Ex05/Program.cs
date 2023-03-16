using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu salário atual: ");
            double salarioAtual = Convert.ToDouble(Console.ReadLine());

            if (salarioAtual >= 0 && salarioAtual <= 1500)
            {
                double reajuste = salarioAtual + (salarioAtual * 0.23);
                Console.WriteLine($"O seu salário era R${salarioAtual} e agora é {reajuste.ToString("c2")}");
            }
            else
            {
                double reajuste = salarioAtual + (salarioAtual * 0.18);
                Console.WriteLine($"O seu salário era R${salarioAtual} e agora é R${reajuste.ToString("c2")}");
            }
            Console.ReadKey();
        }
    }
}
