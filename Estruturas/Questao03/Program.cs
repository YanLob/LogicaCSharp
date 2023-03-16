using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite [1]Para feminino | [2]Para Masculino: ");
            int sexo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            if (sexo == 1)
            {
                double calculo = (72.7 * altura) - 58;

                Console.WriteLine($"Seu peso ideal é {calculo}Kgs!");
            }
            
            else if(sexo == 2) {
                double calculo = (62.1 * altura) - 44.7;
                Console.WriteLine($"Seu peso ideal é {calculo}Kgs!");
            }

            else
            {
                Console.WriteLine("Sexo invalido!");
            }
            Console.ReadKey();
        }
    }
}
