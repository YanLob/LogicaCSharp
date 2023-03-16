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
            Console.Write("Digite um nome: ");
            string nome = Convert.ToString(Console.ReadLine());

            Console.Write("Digite outro nome: ");
            string nome2 = Convert.ToString(Console.ReadLine());

            if (nome.Length > nome2.Length)
            {
                Console.WriteLine($"O nome maior é {nome}");
            }
            else
            {
                Console.WriteLine($"O nome maior é {nome2}");
            }
            
        }
    }
}
