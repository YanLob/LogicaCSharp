using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    public class Gerente
    {
        public string nome;
        public double salario;

        public void AumentoSalarial()
        {
            AumentoSalarial(10);
        }

        public void AumentoSalarial(int novaTaxa)
        {
            salario = salario + (salario * novaTaxa / 100);
        }

        public void ImprimirDados()
        {
            Console.WriteLine($"\n{this.salario:c2}");
        }

    }
}
