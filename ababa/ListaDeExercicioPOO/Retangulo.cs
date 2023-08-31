using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Retangulo
    {
        public int ladoA, ladoB;

        public Retangulo(int ladoA, int ladoB)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
        }

        public void MudarRetangulo(int novoLadoA, int novoLadoB)
        {
            this.ladoA = novoLadoA;
            this.ladoB = novoLadoB;
        }

        public double calcularArea()
        {
            return ladoA * ladoB;
        }

        public double calcularPerimetro()
        {
            return (ladoA * 2) + (ladoB * 2);
        }
    }
}
