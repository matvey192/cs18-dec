using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_21
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double a1 = a; //3
            double b1 = b; // 1
            double res1 = 0;
            double res2 = 0;
            while (a1 <= b) 
            {
                res1 = res1 + Math.Pow(a1,2);
                a1++;
            }
            while (b1 <= a) 
            {
                res2 = res2 + Math.Pow(b1, 2);
                b1++;
            }
            Console.WriteLine(res1+res2);
        }
    }
}
