using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_35
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int w = int.Parse(Console.ReadLine()); //5
            if (w < 0) { Console.WriteLine("Значение W должно быть неотрицательно "); return; }
            int i = w-2;//3
            int e = 0;
            Console.Write("+");
            for(int id=0;id<i;id++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.WriteLine();
            Console.Write("|");
            for (int ide=0; ide < i; ide++)
            {
                Console.Write(".");
            }
            Console.Write("|");
            Console.WriteLine();
            Console.Write("+");
            for (int id = 0; id < i; id++)
            {
                Console.Write("-");
            }
            Console.Write("+");
        }
    }
}
