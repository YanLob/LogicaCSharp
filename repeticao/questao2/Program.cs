using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("---Conta Corrente---\n");
            Console.Write("Digite [1] para depositar\n" +
                "Digite [2] para sacar\n" +
                "Digite [3] para exibir saldo\n" +
                "Digite [4] para sair: ");
            int acao = Convert.ToInt32(Console.ReadLine());
            int saldo = 0;

            while (acao !=4)
            {
                Console.Clear();
                if (acao == 1)
                {
                    Console.Write("Digite o quanto você quer depositar: ");
                    int depos = Convert.ToInt32(Console.ReadLine());
                    if(depos > 0)
                    {
                        Console.WriteLine("Deposito feito com sucesso!");
                        saldo += depos;
                    }
                    else
                    {
                        Console.WriteLine("Digite um valor valido!");
                    }
                }

                else if (acao == 2)
                {
                    Console.Write("Digite o tanto que você quer sacar: ");
                    int sacar = Convert.ToInt32(Console.ReadLine());

                    if (saldo >= sacar)
                    {
                        Console.WriteLine("Valor sacado com sucesso");
                        saldo -= sacar;
                    }
                    else
                    {
                        Console.WriteLine("Digite um valor valido!");
                    }

                }

                else if (acao == 3)
                {
                    Console.WriteLine($"O seu saldo é de {saldo}");

                }
                else if(acao > 4 || acao < 1)
                {
                    Console.WriteLine("Digite uma ação valida!");
                }

                
                Console.Write("Digite [1] para depositar\n" +
                "Digite [2] para sacar\n" +
                "Digite [3] para exibir saldo\n" +
                "Digite [4] para sair: ");
                Console.Write("\nDigite uma acão: ");
                acao = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Programa finalizado!");

        }
    }
}
