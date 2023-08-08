using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_complementares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\t\t---Informações do Aluno---\n");

            #region aluno
            Aluno aluno1 = new Aluno();
            aluno1.nome = "Matias";
            aluno1.rg = 123902197;
            aluno1.dtNasc = "12/06/2004";

            Console.WriteLine($"\nNome => {aluno1.nome}");
            Console.WriteLine($"RG => {aluno1.rg}");
            Console.WriteLine($"Data de nascimento => {aluno1.dtNasc}\n");

            Aluno aluno2 = new Aluno();
            aluno2.nome = "Elias";
            aluno2.rg = 129312332;
            aluno2.dtNasc = "04/12/2005";

            Console.WriteLine($"Nome => {aluno2.nome}");
            Console.WriteLine($"RG => {aluno2.rg}");
            Console.WriteLine($"Data de nascimento => {aluno2.dtNasc}\n");
            #endregion

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            #region funcionarios
            Funcionario func1 = new Funcionario();
            func1.nome = "Eduardo";
            func1.cargo = "professor";
            func1.salarFunc = 8000;

            Console.WriteLine($"\nNome => {func1.nome}");
            Console.WriteLine($"Cargo => {func1.cargo}");
            Console.WriteLine($"Salário => {func1.salarFunc}");

            Funcionario func2 = new Funcionario();
            func2.nome = "João";
            func2.cargo = "Diretor";
            func2.salarFunc = 6000;

            Console.WriteLine($"\nNome => {func2.nome}");
            Console.WriteLine($"Cargo => {func2.cargo}");
            Console.WriteLine($"Salário => {func2.salarFunc}\n");
            #endregion

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            #region turma
            Turma turma1 = new Turma();
            turma1.periodo = "Verpertino";
            turma1.serie = 9;
            turma1.sigla = "9°C";
            turma1.ensino = "Integral";

            Console.WriteLine($"\nPeríodo => {turma1.periodo}");
            Console.WriteLine($"série => {turma1.serie}");
            Console.WriteLine($"Sígla => {turma1.sigla}");
            Console.WriteLine($"Ensino => {turma1.ensino}");

            Turma turma2 = new Turma();
            turma2.periodo = "Matutino";
            turma2.serie = 9;
            turma2.sigla = "9°C";
            turma2.ensino = "Integral";

            Console.WriteLine($"\nPeríodo => {turma2.periodo}");
            Console.WriteLine($"série => {turma2.serie}");
            Console.WriteLine($"Sígla => {turma2.sigla}");
            Console.WriteLine($"Ensino => {turma2.ensino}\n");
            #endregion
        }
    }
}
