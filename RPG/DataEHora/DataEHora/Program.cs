using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEHora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Cálculo de idade---");
            Console.Write("Digite seu ano de nascimento");
            int ano = Convert.ToInt32(Console.ReadLine());
            int dataNasc = DateTime.Now.Year - ano;

            Console.WriteLine($"Você tem ou vai fazer {dataNasc} anos.");
        }
    }
}
