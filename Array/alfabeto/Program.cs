﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alfabeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alfabeto = new char[26];

            for (int i = 0; i < 26; i++)
            {
                alfabeto[i] = (char)('A' + i);
                Console.Write(alfabeto[i] + " ");
            }
        }
    }
}
