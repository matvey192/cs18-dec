using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            int d = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (b <= d)
            {
                int c = b % 7;
                if (c == 0)
                {
                    res = b + res;
                }
                b++;
            }
            while (b >= d)
            {
                int c = d % 7;
                if (c == 0)
                {
                    res = d + res;
                }
                d++;
            }
            Console.WriteLine(res);
        }
    }
}