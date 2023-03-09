using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vlrprest, qntprest, prestPag, valoraPago;

            Console.Write("Quantidade de prestação: ");
            qntprest = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quantidade de prestações pagas: ");
            prestPag = Convert.ToDouble(Console.ReadLine());

            Console.Write("Valor da prestaçao: R$");
            vlrprest = Convert.ToDouble(Console.ReadLine());

            double saldo = (qntprest - prestPag) * vlrprest;
            valoraPago = qntprest * vlrprest - saldo;

            Console.WriteLine($"O valor que ja foi pago é R${saldo} e o valor que resta a ser pago é R${valoraPago}");

        }
    }
}
