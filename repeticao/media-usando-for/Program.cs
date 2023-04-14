using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota = 0, cont = 1, contAluno = 0, mediaAluno = 0, mediaTurma = 0;

            Console.Write("Digite a quantidade de alunos na turma: ");
            int alunos = Convert.ToInt32(Console.ReadLine());

            while (cont <= alunos)
            {
                contAluno++;
                for (int n = 1; n <= 4; n++)
                {
                    Console.Write($"Digite a nota do aluno {contAluno}° do {n}° Bimestre: ");
                    nota += Convert.ToInt32(Console.ReadLine());
                    mediaAluno = nota / n;
                }
                mediaTurma += mediaAluno / alunos;

                Console.WriteLine($"A média desse aluno é {mediaAluno}");
                Console.WriteLine("-------------------------");

                mediaAluno = 0;
                nota = 0;
                cont++;
            }
            Console.WriteLine(mediaTurma);
        }
    }
}
