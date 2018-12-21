using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            int i = 0;
            while (res < 1000)
            {
                int a = int.Parse(Console.ReadLine());
                res = res + a;
                i++;
            }
            Console.WriteLine(i);
        }
    }
}
