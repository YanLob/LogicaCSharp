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
            double litros, km;

            Console.Write("Digite a quantidade de quilometros: ");
            km = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade de litros: ");
            litros = Convert.ToInt32(Console.ReadLine());

            double kmFeito = km/litros;

            Console.WriteLine($"O veiculo esta fazendo {kmFeito}km com um litro de combustivel!");
        }
    }
}
