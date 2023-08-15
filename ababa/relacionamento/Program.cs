using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agencia agencia = new Agencia();
            agencia.numero = 1825;
            agencia.nome = "Abababab";

            Conta c = new Conta();
            c.numeroDaConta = 1239175123;
            c.agencia = agencia;
            c.agencia = agencia;

            Console.WriteLine(c.agencia.numero);
            Console.WriteLine(c.agencia.nome);
        }
    }
}
