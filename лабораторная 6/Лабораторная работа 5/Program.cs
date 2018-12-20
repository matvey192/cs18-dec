using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = int.Parse(a);
            string a1 = Console.ReadLine();
            int c = int.Parse(a1);
            if (b < c) { Console.WriteLine("Второе "); }
            else { Console.WriteLine("Первое"); }
        }
    }
}
