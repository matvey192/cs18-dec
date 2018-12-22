using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            if (0 >= s && s >= 20) { Console.WriteLine("Значение W должно быть в интервале [0, 20]"); return; }
            int i = 0;
            string bs;
            string bs1;
            string bs2;
            string bs3;
            string bs4;
            string bs5;
            string bs6;
            string bs7;
            string bs8;
            while (i <= s)
            {
                string bs = "a" + "a";
                string bs1 = "a" + "a";
                string bs2 = "b" + "b";
                string bs3 = "c" + "c";
                string bs4 = "d" + "d";
                string bs5 = "e" + "e";
                string bs6 = "f" + "f";
                string bs7 = "g" + "g";
                string bs8 = "h" + "h";
                
                i++;
            }
            Console.Write(bs + "\n" + bs1 + "\n" + bs2 + "\n" + bs3 + "\n" + bs4 + "\n" + bs5 + "\n" + bs6 + "\n" + bs7 + "\n" + bs8);
        }
    }
}//////////

