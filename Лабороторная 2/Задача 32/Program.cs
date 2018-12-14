using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_32
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1 = Console.ReadLine();
            double a = double.Parse(x1);
            string x2 = Console.ReadLine();
            double b = double.Parse(x2);
            string x = Console.ReadLine();
            double aDeg = double.Parse(x);
            double aRad = aDeg * Math.PI / 180;
            double res = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(aRad));
            Console.WriteLine("{0:F4}",res);
        }
    }
}
