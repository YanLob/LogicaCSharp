using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cloneReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];
            int[] y = new int[10];

            Console.WriteLine("---Imprimir Array copiado e revertido---");

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"Digite o {i+1}° valor: ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            y = (int[])x.Clone();
            Array.Reverse(y);

            Console.WriteLine("\n---Imprimindo array Y que foi clonado e revertido pelo Array X---\n");

            Console.Write("{ ");
            foreach (int lista in y)
            {
                Console.Write(lista + "  ");
            }
            Console.WriteLine("}");
        }
    }
}
