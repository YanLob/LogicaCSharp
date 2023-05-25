using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe sua data de nascimento: ");
            DateTime dtNascimento = DateTime.Parse(Console.ReadLine());

            CalcularIdadeDetalhada(dtNascimento);
            Console.ReadKey();
    
        }
        static void CalcularIdadeDetalhada(DateTime dtNascimento)
        {
            DateTime dtAtual = DateTime.Now;
            TimeSpan diferença = dtAtual - dtNascimento;
            DateTime idade = DateTime.MinValue + diferença;

            int anos = idade.Year - 1;
            int meses = idade.Month - 1;
            int dias = idade.Day - 1;

            Console.WriteLine("{0} Anos\n {1} Meses\n {2} Dias", anos, meses, dias);
        }
    }
}
