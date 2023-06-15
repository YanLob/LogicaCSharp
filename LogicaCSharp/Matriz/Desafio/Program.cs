using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] enfermaria = new int[4, 5];
            int[] media = new int[4];
            int soma = 0, mediaPacien = 0;

            for (int pacien = 0; pacien < 4; pacien++)
            {
                Console.Clear();
                for (int pulso = 0; pulso < 5; pulso++)
                {
                    Console.Write($"Digite o pulso {pulso+1}° do {pacien+1}°: ");
                    enfermaria[pacien, pulso] = Convert.ToInt32(Console.ReadLine());
                    soma += enfermaria[pacien, pulso];

                    mediaPacien = soma / 5;
                }
                
                media[pacien] = mediaPacien;
                soma = 0;
            }
            Console.WriteLine("Média dos pacientes");
            foreach (int medias in media)
            {              
                Console.Write(medias + "  ");
            }
        }
    }
}
