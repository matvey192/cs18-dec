using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = Console.ReadLine();
            int a = int.Parse(a1);
            string a2 = Console.ReadLine();
            int b = int.Parse(a2);
            string a3 = Console.ReadLine();
            int c = int.Parse(a3);
            if (a < b && b < c) { Console.WriteLine("Выполняется"); }
            else { Console.WriteLine("Невыполняется"); }
        }
    }
}
