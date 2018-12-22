using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_28
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 0;
            int res = 0;
            int b = 100;
            while (b <= 1000)
            {
                int c = b % 13;
                if (c == 0)
                {
                    d++;
                }
                b++;
            }
            Console.WriteLine(d);
        }
    }
}
