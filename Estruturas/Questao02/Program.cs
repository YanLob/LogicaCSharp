using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira medida: ");
            int lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a primeira medida: ");
            int lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a primeira medida: ");
            int lado3 = Convert.ToInt32(Console.ReadLine());

            if ((lado1 + lado2) > lado3 && (lado2 + lado3) > lado1 && (lado3 + lado1) > lado2)
            {
                if(lado1 == lado2 && lado1 == lado3)
                {
                    Console.WriteLine("Triângulo Equilatero tendo todos os lados iguais!");
                }

                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("Triângulo Isóscele tendo apenas 2 lados iguais!");
                }

                else
                {
                    Console.WriteLine("Triângulo Escaleno tendo todos os lados diferentes!");
                }
            }

            else
            {
                Console.WriteLine("Triangulo não está com as medidas certas!");
            }

            Console.ReadKey();
        }
    }
}
