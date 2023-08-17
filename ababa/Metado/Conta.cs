using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metado
{
    public class Conta
    {
        public double saldo = 0;

        public void setDepositar(double novoValor)
        {
            this.saldo += novoValor;
        }

        public double getDepositar()
        {

            return this.saldo;
        }
    }
}
