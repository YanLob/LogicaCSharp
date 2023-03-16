using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso(kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine($"O seu IMC é {imc.ToString("n2")}");

            if (imc < 16.9)
            {
                Console.WriteLine("Muito abaixo do peso");
            }
            else if (imc >= 17 && imc <= 18.4)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Acima do peso");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("Obesidade I");
            }
            else if (imc >= 35 && imc <= 40)
            {
                Console.WriteLine("Obesidade II");
            }
            else if (imc > 40)
            {
                Console.WriteLine("Obesidade III");
            }

            Console.ReadKey();
        }
    }
}
