using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_33
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1 = Console.ReadLine();
            double a = double.Parse(x1);
            if (a == 0)
            {
                Console.WriteLine("Значение a должно быть не равно нулю");
                return;
            }
            string x2 = Console.ReadLine();
            double b = double.Parse(x2);
            string x = Console.ReadLine();
            double c = double.Parse(x);
            string x3 = Console.ReadLine();
            double d = double.Parse(x3);
            if (d == 0)
            {
                Console.WriteLine("Значение d должно быть не равно нулю");
                return;
            }
            double res = (a * d + b * c) /( a * d);
            Console.WriteLine("{0:F4}",res);
        }
    }
}
