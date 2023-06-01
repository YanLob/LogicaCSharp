using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Digite o {i+1}° valor: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Digite um valor para ver se ele existe no array: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            if (A.Contains(valor))
            {
                Console.WriteLine("ACHEI");
            }
            else {Console.WriteLine("NÃO ACHEI");}
        }
    }
}
