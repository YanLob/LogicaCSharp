using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Verificar se um número é PAR ou IMPAR---");
            Console.Write("Informe um número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Número é PAR");
            }
            else
            {
                Console.WriteLine("Esse número é IMPAR");
            }
            Console.ReadKey();
        }
    }
}
