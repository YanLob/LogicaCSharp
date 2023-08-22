using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    public class Conta
    {
        public int numero = 0;
        public double saldo = 0;
        public double limite = 100;
        public int id;

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Sacar (double valor)
        {
            saldo -= valor;
        }

        public double ConsultarSaldo()
        {
            return saldo + limite;
        }

        public void Transferir(Conta contaDest, double transferencia)
        {
            if ( saldo > transferencia )
            {
                Depositar(transferencia);
                contaDest.saldo += transferencia;
            }
        }

        public void ImprimirExtrato()
        {
            DateTime dt = DateTime.Now;
            string data = dt.ToShortDateString();
            string hora = dt.ToShortTimeString();
            Console.WriteLine("\n\t\t---Extrato detalhado---");

            Console.WriteLine("\nData: " + data);
            Console.WriteLine("\nHora: " + hora);
            Console.WriteLine($"Saldo: {saldo}");
            Console.WriteLine($"Limite: {this.limite}");
        }
    }
}
