using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region TesteNome
            Cliente matias = new Cliente();
            matias.nome = "Matias";
            matias.codigo = 12312;

            Cliente eduardo = new Cliente();
            eduardo.nome = "Eduard";
            eduardo.codigo = 25432;

            Cliente elias = new Cliente();
            elias.nome = "Elias moreira";
            elias.codigo = 39485;

            Console.WriteLine("---Imprimindo dados do Objeto---");

            Console.WriteLine("\nCódigo: " + matias.codigo);
            Console.WriteLine("Nome: " + matias.nome);

            Console.WriteLine("\nCódigo: " + eduardo.codigo);
            Console.WriteLine("Nome: " + eduardo.nome);

            Console.WriteLine("\nCódigo: " + elias.codigo);
            Console.WriteLine("Nome: " + elias.nome);
            #endregion

            CartaoDeCred cart1 = new CartaoDeCred(1825);
            Agencia agen1 = new Agencia(4560);
            cart1.dataDeValidade = "09/01/2004";

            Console.WriteLine("\nCartão: " + cart1.numero);
            Console.WriteLine("Data de validade: " + cart1.dataDeValidade);
            Console.WriteLine("Agencia: " + agen1.numAgenc);

            //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

            CartaoDeCred cart2 = new CartaoDeCred(2026, "12/12/2023");
            Agencia agen2 = new Agencia(9043);

            Console.WriteLine("\nCartão: " + cart2.numero);
            Console.WriteLine("Data de validade: " + cart2.dataDeValidade);
            Console.WriteLine("Agencia: " + agen2.numAgenc);


            Funcionario func1 = new Funcionario();
            func1.nome = "Matias";
            func1.salario = 1080;
            func1.AumentarSalario(10);
            func1.ImprimirDados();

            Gerente geren = new Gerente();
            geren.salario = 1000;
            geren.AumentoSalarial();
            geren.ImprimirDados();

            Conta c1 = new Conta(agen1);
            Conta c2 = new Conta(agen2);
            c1.saldo = 2000;
            c2.saldo = 2000;
            c1.Transferir(c2, 1000);
            c1.ImprimirExtrato();
            c2.ImprimirExtrato();
        }
    }
}
