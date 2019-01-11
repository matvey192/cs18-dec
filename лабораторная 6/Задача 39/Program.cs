using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_39
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine()); // 55
            int h = int.Parse(Console.ReadLine()); // 6
            string avb ="+";
            int i = 0;
            int c = 0;
            int v = w; //4
            int e = 0;
            while (w >= i)
            {
                Console.Write(avb);
                i++;
                if (i == v)
                {
                    while (v + e != w) { Console.Write("#"); e++; }
                    e = 0;
                    Console.WriteLine();
                    v--;
                    i = 0;
                }
            }
        }
    }
}
