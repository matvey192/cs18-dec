using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            do
            {
                a = int.Parse(Console.ReadLine());
                b =b + a;
            } while (a != 0);
            Console.WriteLine(b);
            int a1 = 0;
            int b1 = 0;
            for (int i=0;i<=1000;i++)
            {
                a1 = int.Parse(Console.ReadLine());
                b1 = b1 + a1;
                if (a1 == 0) { Console.WriteLine(b); return; }
            }
        }
    }
}
