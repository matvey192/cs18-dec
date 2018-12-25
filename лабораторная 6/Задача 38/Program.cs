using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_38
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine()); // 8
            int b = int.Parse(Console.ReadLine()); // 13
            string avb = null;
            int i = 0;
            int h1 = h; // 8
            int b1 = b; // 13
            int hb;
            int re = 0;
            if (h < b)
            {
                hb = b - h;
                while (i <= hb)
                {
                    re = h1 % 2;
                    if (re != 0) { Console.WriteLine(avb + h1); avb = avb + "."; }
                    h1++;
                    i++;
                }
            }
            else
            {
                avb = null; 
                hb = h - b;
                while (i <= hb)
                {
                    re = h1 % 2;
                    if (re != 0) { Console.WriteLine(avb + b1); avb = avb + "."; }
                    b1++;
                    i++;
                }
            }
        }
    }
}
