using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_39
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1 = Console.ReadLine();
            double xa = double.Parse(x1);
            string x12 = Console.ReadLine();
            double ya = double.Parse(x12);
            string x123 = Console.ReadLine();
            double xb = double.Parse(x123);
            string x = Console.ReadLine();
            double yb = double.Parse(x);
            double res = Math.Sqrt(Math.Pow((xb - xa), 2)+ Math.Pow((yb - ya),2));
            Console.WriteLine("{0:F4}",res);
        }
    }
}
