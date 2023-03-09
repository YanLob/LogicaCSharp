using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroTeste
{
    internal class CarroTeste
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();//instancia
            Console.WriteLine(c1.velocidadeMaxima());
        }
    }
}
