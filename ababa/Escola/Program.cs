using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Turma turma = new Turma(); // instancia
            turma.sigla = "9°C";
            Aluno aluno = new Aluno();
            aluno.nome = "Ababab";
            aluno.turma = turma; // vinculo

            Console.WriteLine($"Turma do aluno {aluno.nome} é a turma {aluno.turma.sigla}");

            Endereco end = new Endereco();
            end.endereco = "Rua abba de bababa 2534";
            Cliente cliente = new Cliente();
            cliente.nome = "Ababa";
            cliente.endereco = end;

            Console.WriteLine(cliente.endereco.endereco);
        }
    }
}
