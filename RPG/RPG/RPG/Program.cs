using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dano = 0, vMonstro = 10, vHerio = 10;

            Random random = new Random();
            do
            {
                dano = random.Next(1, 10);
                vMonstro -= dano;

                if (vMonstro < 0)
                {
                    vMonstro = 0;
                }
                Console.WriteLine($"O MONSTRO foi danificado e perdeu {dano} de saúde e agora tem {vMonstro} HP");

                if (vMonstro > 0)
                {
                    dano = random.Next(1, 10);
                    vHerio -= dano;

                    if (vHerio < 0)
                    {
                        vHerio = 0;
                    }
                    Console.WriteLine($"O HEROI foi danificado e perdeu {dano} de saúde e agora tem {vHerio} HP");
                }


            } while (vHerio > 0 && vMonstro > 0);

            if (vHerio > 0)
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
                Console.WriteLine($"O HEROI venceu com {vHerio} de HP!");
            }
            else
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
                Console.WriteLine($"O MONSTRO venceu com {vMonstro} de HP!");
            }

            Console.ReadKey();

        }
    }
}