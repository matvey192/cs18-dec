using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_36
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine()); //5
            if (w < 0) { Console.WriteLine("Значение W должно быть неотрицательно "); return; }
            int h = int.Parse(Console.ReadLine()); //5
            if (h < 0) { Console.WriteLine("Значение H должно быть неотрицательно "); return; }
            int i = w - 2;//3
            int ew = 0;
            int ch = 0; 
            Console.Write(" ");
            for (int ee = 0; ee < w; ee++) { Console.Write(ee); }
            Console.WriteLine();
           for (int ee = 0; ee < h; ee++)
            {
                int ee1 = 0;
                Console.Write(ee);
                for (; ee1 < w; ee1++) { Console.Write("."); }
                if (w == ee1) { Console.WriteLine("|"); }
            }
            Console.Write(" ");
            for (int ee = 0; ee < w; ee++) { Console.Write("-"); }
            Console.Write(" ");
        }
    }
}
