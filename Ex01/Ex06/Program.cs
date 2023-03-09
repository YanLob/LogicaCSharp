using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano = 365, mes = 30, semana = 7;

            Console.Write("Digite a quantidade de dias: ");
            int dias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"dias {dias} é {dias/ano} anos, {dias/mes} meses e são {dias/semana} semanas");
        }
    }
}
