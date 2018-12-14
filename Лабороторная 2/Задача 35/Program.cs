using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_35
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1 = Console.ReadLine();
            double a = double.Parse(x1);
            string x2 = Console.ReadLine();
            double b = double.Parse(x2);
            string x3 = Console.ReadLine();
            double c = double.Parse(x3);
            string x4 = Console.ReadLine();
            double x = double.Parse(x4);
            if (a*Math.Pow(x,2)+b*x+c < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            if (Math.Sqrt(a * Math.Pow(x, 2) + b * x + c) == 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю");
                return;
            }
            double res = 1 / (Math.Sqrt(a * Math.Pow(x, 2) + b * x + c));
            Console.WriteLine("{0:F4}",res);
        }
    }
}
