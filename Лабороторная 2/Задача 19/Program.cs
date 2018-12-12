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
            string x = Console.ReadLine();
            double a = double.Parse(x);
            string x1 = Console.ReadLine();
            double b = double.Parse(x1);
            if (-7*b < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            double res = a * Math.Sqrt(-7 * b);
            Console.WriteLine("{0:F4}",res);
        }
    }
}
