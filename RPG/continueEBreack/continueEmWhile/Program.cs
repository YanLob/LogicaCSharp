using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continueEmWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite um numero: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if(num<=10 || num >= 20)
                {
                    continue;
                }
                else
                {
                    if(num==15){
                        break;
                    }
                    Console.WriteLine("Numero: "+num);
                }
            }
        }
    }
}
