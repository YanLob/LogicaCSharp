using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ababavaba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Abba", 20, 70, 1.75);

            Console.WriteLine(pessoa.altura);
            Console.WriteLine(pessoa.idade);
            pessoa.crecer(0.20);
            pessoa.envelhecer(3);
            Console.WriteLine(pessoa.altura);
            Console.WriteLine(pessoa.idade);
            pessoa.envelhecer(5);
            Console.WriteLine(pessoa.altura);
            Console.WriteLine(pessoa.idade);

            Console.WriteLine("-------------------------");

            Console.WriteLine(pessoa.peso);
            pessoa.engordar(0.50);
            Console.WriteLine(pessoa.peso);
            pessoa.emagrecer(0.50);
            Console.WriteLine(pessoa.peso);
        }
    }
}
