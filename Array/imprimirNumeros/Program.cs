using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imprimirNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Imprimir números---");

            int[] numeros = new int[100];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i+1;
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
