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

            CartaoDeCred cart1 = new CartaoDeCred();
            Agencia agen1 = new Agencia();
            cart1.numero = "1231231231213123-00";
            cart1.dataDeValidade = "12/12/2023";
            agen1.numAgenc = 1825;

            Console.WriteLine("\nCartão: " + cart1.numero);
            Console.WriteLine("Data de validade: " + cart1.dataDeValidade);
            Console.WriteLine("Agencia: " + agen1.numAgenc);

            //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

            CartaoDeCred cart2 = new CartaoDeCred();
            Agencia agen2 = new Agencia();
            cart2.numero = "112543516345123-10";
            cart2.dataDeValidade = "12/12/2025";
            agen2.numAgenc = 9845;

            Console.WriteLine("\nCartão: " + cart2.numero);
            Console.WriteLine("Data de validade: " + cart2.dataDeValidade);
            Console.WriteLine("Agencia: " + agen2.numAgenc);

            Conta c1 = new Conta();
            c1.numero = 1;
            c1.saldo = 99;

            Console.WriteLine("\nNúmero: " + c1.numero);
            Console.WriteLine("Saldo => R$" + c1.saldo);

            Conta c2 = new Conta();
            c2.numero = 2;
            c2.saldo = 56;

            Console.WriteLine("\nNúmero: " + c2.numero);
            Console.WriteLine("Saldo => R$" + c2.saldo);
        }
    }
}
