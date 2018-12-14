using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_38
{
    class Program
    {
        static void Main(string[] args)
        {
            string x3 = Console.ReadLine();
            double x1 = double.Parse(x3);
            string x = Console.ReadLine();
            double x2 = double.Parse(x);
            double res = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(x2, 2));
            Console.WriteLine("{0:F4}",res);
        }
    }
}
