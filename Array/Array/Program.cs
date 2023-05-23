using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mult = 0;

            int[] nuns = new int[100];
            for (int i = 0; i < 100; i++)
            {
                nuns[i] = i * 2;
                Console.WriteLine(nuns[i]);
            }
        }
    }
}
