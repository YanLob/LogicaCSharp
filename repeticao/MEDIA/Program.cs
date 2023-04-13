using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int cont = 1;
            int bimestre = 1;
            int mediaAluno = 0;
            int mediaTurma = 0;
            int nota = 0;
            Console.Write("Digite o total de alunos na turma: ");
            int alunos = Convert.ToInt32(Console.ReadLine());

            while (cont <= alunos)
            {
                while(bimestre <= 4)
                {
                    Console.Write($"Digite a nota {cont}° do aluno no {bimestre }°: ");
                    nota += Convert.ToInt32(Console.ReadLine());
                    bimestre++;

                }
                if (bimestre > 4)
                {   
                    mediaAluno = nota / 4;
                    Console.WriteLine($"A média do {cont}° é {mediaAluno}");

                    mediaTurma += mediaAluno;
                    bimestre = 1;
                    nota = 0;
                    mediaAluno = 0;
                }
                cont++;
            }

            Console.WriteLine($"A media da turma é: {mediaTurma / alunos}");
            
        }
    }
}
