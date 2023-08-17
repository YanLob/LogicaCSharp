using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta cc1 = new Conta();
            cc1.setDepositar(1000); 

            Console.WriteLine(cc1.getDepositar());
        }
    }
}
