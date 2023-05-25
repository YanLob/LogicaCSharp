using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] {1,2,22,4,20,6,7,99,92,100};

            Console.WriteLine(numeros.Contains(100));
        }
    }
}
