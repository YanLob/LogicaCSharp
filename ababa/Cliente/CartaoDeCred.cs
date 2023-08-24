using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    public class CartaoDeCred
    {

        public int numero;
        public string dataDeValidade;

        public CartaoDeCred(int numero)
        {
            this.numero = numero;
        }

        public CartaoDeCred(int numero, string dataDeValidade) : this(numero)
        {
            this.dataDeValidade = dataDeValidade;
        }
    }
}
