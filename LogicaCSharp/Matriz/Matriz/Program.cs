using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] notas = new int[3, 4];
            int aluno = 1, total = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Digite a nota do {j+1}° bimestre do {aluno}° aluno: ");
                    notas[i, j] = Convert.ToInt32(Console.ReadLine());

                    total += notas[i, j];
                }
                aluno++;
                Console.Clear();
            }

            int media = total / 12;
            Console.WriteLine("A média da turma é -> " + media);
            Console.ReadKey();
        }
    }
}
