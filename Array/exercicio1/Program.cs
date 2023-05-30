using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elementos = new int[5];

            string resp = "";

            do
            {
                for (int x = 0; x < elementos.Length; x++)
                {
                    Console.Write($"Digite o {x+1}° valor: ");
                    elementos[x] = Convert.ToInt32(Console.ReadLine());

                    if (elementos[x]>=10 || elementos[x]<=50)
                    {
                        Console.WriteLine("Tente novamente!");
                        continue;
                    }
                }
                Console.Write("Você deseja continuar? [s/n]");
                resp = Console.ReadLine().ToLower();

            } while (resp.Equals("s"));

            foreach (int vetor in elementos)
            {
                Console.WriteLine(vetor);
            }
        }
    }
}
