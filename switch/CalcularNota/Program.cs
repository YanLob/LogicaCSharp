using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Calculos de nota---");

            char conceito = ' ';
            string situ;

            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a nota do 1° Bimentre: ");
            int nota1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota do 2° Bimentre: ");
            int nota2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota do 3° Bimentre: ");
            int nota3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota do 4° Bimentre: ");
            int nota4 = Convert.ToInt32(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 90)
            {
                conceito = 'A';

            }
            else if (media >= 80)
            {
                conceito = 'B';

            }
            else if (media >= 60)
            {
                conceito = 'C';

            }
            else if (media >= 40)
            {
                conceito = 'D';

            }
            else if (media >= 20)
            {
                conceito = 'E';

            }

            switch (conceito) { 
            
                case 'A': situ = "APROVADO A";
                    break;
                case 'B':
                    situ = "APROVADO B";
                    break;
                case 'C':
                    situ = "APROVADO C";
                    break;
                case 'D':
                    situ = "RECUPERAÇÃO D";
                    break;
                case 'E':
                    situ = "EXAME E";
                    break;
                default:
                    situ = "REPROVADO";
                    break;
            }

            Console.WriteLine($"O aluno {nome} e esta na seguinte situação: {situ}");

        }
    }
}
