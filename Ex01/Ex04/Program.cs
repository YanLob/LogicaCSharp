using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largura, profund, altura, caixa;

            Console.Write("Digite a largura: ");
            largura = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a profundidade: ");
            profund = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a altura: ");
            altura = Convert.ToInt32(Console.ReadLine());

            caixa = largura*profund*altura;

            Console.WriteLine($"Calculando o volume da caixa = {caixa}m²");
        }
    }
}
