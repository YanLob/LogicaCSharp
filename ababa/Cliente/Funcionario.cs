using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    public class Funcionario
    {
        public string nome;
        public double salario;

        public void AumentarSalario(double valor)
        {
            salario = salario + (salario * (valor / 100));
        }

        public void ImprimirDados()
        {
            Console.WriteLine("\n---Imprimindo Dados Do Funcionario---");
            DateTime dt = DateTime.Now;
            string data = dt.ToShortDateString();
            string hora = dt.ToShortTimeString();

            Console.WriteLine("\nData: " + data);
            Console.WriteLine("Hora: " + hora);
            Console.WriteLine($"Nome do funcionario: {nome}");
            Console.WriteLine($"Saldo: {salario:c2}");

        }
    }
}
