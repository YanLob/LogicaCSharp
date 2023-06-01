using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Descobrindo indice---");

            int[] A = new int[10];

            int valor;

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Digite o {i+1}° valor: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Digite um valor: ");
            valor = Convert.ToInt32(Console.ReadLine());

            int ind = Array.IndexOf(A, valor);

            if (A.Contains(valor))
            {
                Console.WriteLine($"O índice do valor é {ind}!");
            }
            else
            {
                Console.WriteLine("Esse valor não existe no Array!");
            }
        }
    }
}
