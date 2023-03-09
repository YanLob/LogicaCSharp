using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int percentualGanho;
            double salarioFixo, totalVendas;

            Console.Write("Nome para idenficação: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu salario fixo: R$");
            salarioFixo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Total de vendas (em R$): R$");
            totalVendas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o percentual de ganho: ");
            percentualGanho = Convert.ToInt32(Console.ReadLine());

            double salario = salarioFixo + (totalVendas * percentualGanho/100);

            Console.WriteLine($"O Funcionario {nome}, que tinha como salario R${salarioFixo} agora esta com R${salario}");
        }
    }
}
