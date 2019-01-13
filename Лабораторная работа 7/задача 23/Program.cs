using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_23
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            string[] top = b.Split(' ');
            string c = Console.ReadLine();
            string[] left = c.Split(' ');
            int i = 0;
            int ic = 0;
            int bs = 0;
            Console.Write(" ");
            while (i < top.Length)
            {
                Console.Write(top[i]);
                i++;
            }
            for (; bs < left.Length; bs++)
            {
                Console.WriteLine();
                Console.Write(left[ic]+" ");
                i = 0;
                brr:
                while (i < top.Length-1)
                {
                    if (left[ic] == top[i]) { Console.Write("+"); }
                    i++;

                    if (left[ic] == top[i]) { goto brr; }
                    Console.Write(" ");
                }
                ic++;
                Console.Write("|"); //////////////////////////////////////////////
            }
        }
    }
}
