using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "   a b c d e f g h   ";
            Console.WriteLine(a.Length);
            a = a.Trim();

            Console.WriteLine(a.Length);
            a = a.Replace(" ", "");
            Console.WriteLine(a);
        }
    }
}
