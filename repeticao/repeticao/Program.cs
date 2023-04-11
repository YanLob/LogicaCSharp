using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 1;
            while(op == 1)
            {
                Console.WriteLine("---Calculadora com While---");

                Console.Write("Digite um valor para sua tabuada: ");
                int num = Convert.ToInt32(Console.ReadLine());

                int cont = 0;

                while (cont <= 10)
                {
                    Console.WriteLine($"{num} x {cont} = {num * cont}");
                    cont++;
                }
                Console.WriteLine("Deseja continuar?[1 para SIM | 2 para NÃO]");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("Programa finalizado");
        }
    }
}
