using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Imprimir nome---");

            string msg = "";

            string[] lista = new string[5];

            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write($"Digite o {i+1}° nome: ");
                lista[i] = Console.ReadLine();

                msg += lista[i] + "\n";
                
            }

            Console.WriteLine(msg);
        }
    }
}
