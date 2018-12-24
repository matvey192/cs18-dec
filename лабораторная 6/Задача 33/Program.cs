using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_33
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            if (0 >= s || s >= 20) { Console.WriteLine("Значение W должно быть в интервале [0, 20]"); return; }
            for (int i = 0; i <= s; i++)
            {
                Console.Write("0");
            }
            Console.WriteLine();
            for (int i = 0; i <= s; i++)
            {
                Console.Write("1");
            }
            Console.WriteLine();
            for (int i = 0; i <= s; i++)
            {
                Console.Write("2");
            }
            Console.WriteLine();
            for (int i = 0; i <= s; i++)
            {
                Console.Write("3");
            }
            Console.WriteLine();
            for (int i = 0; i <= s; i++)
            {
                Console.Write("4");
            }
            Console.WriteLine();
            for (int i = 0; i <= s; i++)
            {
                Console.Write("5");
            }
            Console.WriteLine();
            for (int i = 0; i <= s; i++)
            {
                Console.Write("6");
            }
            Console.WriteLine();
            for (int i = 0; i <= s; i++)
            {
                Console.Write("7");
            }
            Console.WriteLine();
            for (int i = 0; i <= s; i++)
            {
                Console.Write("8");
            }
            Console.WriteLine();
            for (int i = 0; i <= s; i++)
            {
                Console.Write("9");
            }
            Console.WriteLine();
        }
    }
}
