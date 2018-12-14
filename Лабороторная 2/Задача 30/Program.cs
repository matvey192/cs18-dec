using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_30
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
            if (a == 0)
            {
                Console.WriteLine("Уравнение y = "+a+"x ^ 2 + "+b+"x + "+c+" не является квадратным");
                return;
            }
            double dis = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("{0:F4}",dis);
        }
    }
}
