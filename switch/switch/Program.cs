using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Aumento Salarial---");
            Console.Write("Digite o cargo: [1]Gerente [2]Engenheiro [3]Tecnico: ");
            int cargo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe seu salário: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            double novoSalario = 0;

            switch(cargo)
            {
                case 1:
                    novoSalario = salario + (salario * 0.1);
                    break;
                case 2:
                    novoSalario = salario + (salario * 0.2);
                    break;
                case 3:
                    novoSalario = salario + (salario * 0.3);
                    break;

                default:
                    novoSalario = salario + (salario * 0.4);
                    break;
            }

            double diferenca = novoSalario - salario;

            Console.WriteLine($"O salario era {salario.ToString("c")}, com aumento fica {novoSalario.ToString("c")}\n" +
                $"{diferenca.ToString("c")} de diferença.");

            Console.ReadKey();

        }
    }
}
