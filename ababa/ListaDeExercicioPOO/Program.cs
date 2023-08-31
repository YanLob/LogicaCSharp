using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bola bl = new Bola("Azul", "60cm", "plastico");
            Console.WriteLine(bl.GetCor());
            bl.SetCor("Vermelho");
            Console.WriteLine(bl.GetCor());

            Console.WriteLine();

            Quadrado quadr = new Quadrado(10);
            Console.WriteLine(quadr.getLados());
            quadr.setLados(20);
            Console.WriteLine(quadr.getLados());
            Console.WriteLine(quadr.CalcularPerimetro());
            Console.WriteLine(quadr.CalcularArea());

            Console.WriteLine();

            Retangulo retan = new Retangulo(10, 20);
            Console.WriteLine(retan.calcularPerimetro());
            retan.MudarRetangulo(100, 20);
            Console.WriteLine(retan.calcularArea());


        }
    }
}
