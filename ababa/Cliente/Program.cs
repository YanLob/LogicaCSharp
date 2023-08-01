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
            Conta matias = new Conta();
            matias.nome = "Matias";
            matias.codigo = 12312;

            Conta eduardo = new Conta();
            eduardo.nome = "Eduard";
            eduardo.codigo = 25432;

            Conta elias = new Conta();
            elias.nome = "Elias moreira";
            elias.codigo = 39485;

            Console.WriteLine("---Imprimindo dados do Objeto---");

            Console.WriteLine("\nCódigo: " + matias.codigo);
            Console.WriteLine("Nome: " + matias.nome);

            Console.WriteLine("\nCódigo: " + eduardo.codigo);
            Console.WriteLine("Nome: " + eduardo.nome);

            Console.WriteLine("\nCódigo: " + elias.codigo);
            Console.WriteLine("Nome: " + elias.nome);

        }
    }
}
