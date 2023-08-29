using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Quadrado
    {
        public int lados;

        public Quadrado(int lados)
        {
            this.lados = lados;
        }

        public int getLados()
        {
            return lados;
        }

        public void setLados(int novoLado)
        {
            lados = novoLado;
        }

        public double CalcularPerimetro()
        {
            return lados + lados;
        }

        public double CalcularArea()
        {
            return lados * lados;
        }
    }
}
