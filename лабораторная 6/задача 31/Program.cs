﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            if (0 >= s || s >= 20) { Console.WriteLine("Значение W должно быть в интервале [0, 20]"); return; }
            for(int i=0;i<=s;i++)
            {
                Console.Write("a");
            }
            Console.WriteLine();
            for (int i = 0; i <= s; i++)
            {
                Console.Write("b");
            }
            Console.WriteLine();
            for (int i = 0; i <= s; i++)
            {
                Console.Write("c");
            }
            Console.WriteLine();
            for (int i = 0; i <= s; i++)
            {
                Console.Write("d");
            }
            Console.WriteLine();
            for (int i = 0; i <= s; i++)
            {
                Console.Write("e");
            }
            Console.WriteLine();
            for (int i = 0; i <= s; i++)
            {
                Console.Write("f");
            }
            Console.WriteLine();
            for (int i = 0; i <= s; i++)
            {
                Console.Write("g");
            }
            Console.WriteLine();
            for (int i = 0; i <= s; i++)
            {
                Console.Write("h");
            }
            Console.WriteLine();
        }
    }
}

