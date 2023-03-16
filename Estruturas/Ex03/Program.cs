using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Convert.ToString(Console.ReadLine());

            Console.Write("Digite a primeira primeira nota: ");
            double nota1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a primeira segunda nota: ");
            double nota2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a primeira terceira nota: ");
            double nota3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a primeira quarta nota: ");
            double nota4 = Convert.ToInt32(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 6.0)
            {
                Console.WriteLine($"O aluno {nome} foi APROVADO com a média de {media}");
            }
            else
            {
                Console.WriteLine($"O aluno {nome} foi REPROVADO com a média de {media}");
            }
            Console.ReadKey();
        }
    }
}
