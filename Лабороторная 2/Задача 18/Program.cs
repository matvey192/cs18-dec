using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1 = Console.ReadLine();
            double x = double.Parse(x1);
            if (61 - x < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            double r = 3 * Math.Sqrt(61 - x);
            Console.WriteLine("{0:F4}", r);
        }
    }
}
