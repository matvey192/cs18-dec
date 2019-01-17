using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_39._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int w1 = w;
            int h1 = h;
            string abc = "*";
            int i = 0;
            int i1 = 0;
            while (i<w)
            {
                Console.Write("*");
                i++;
                if (i == w)
                {
                    w1--;//4
                    Console.WriteLine();
                    h--;//4
                    while (i1 < w1)
                    {
                        Console.Write(abc);    
                        i1++;
                    }
                }
            }
        }


    }
}
