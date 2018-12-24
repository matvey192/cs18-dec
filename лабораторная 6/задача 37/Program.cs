using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_37
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int h = int.Parse(Console.ReadLine()); // 5 
            if (h < 0) { Console.WriteLine("Значение H должно быть неотрицательно "); return; }
            string avb=s;
            int i = 0;
            if (s == "\\")
            {
                while (i < h)
                {
                    Console.Write(avb); Console.WriteLine();
                    avb = avb + s;
                    i++;
                }
            }
            else
            {
                while (i < h)
                {
                    Console.Write(avb); Console.WriteLine();
                    avb = avb + s;
                    i++;
                }
            }
        }
    }
}
