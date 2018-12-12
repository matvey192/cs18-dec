using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double b = double.Parse(a);
            if (b <= 0)
            {
                Console.WriteLine("Радиус должен быть положительным");

                return;
            }
            double res = 2 * Math.PI * b;
            Console.WriteLine("{0:F4}",res);
        }
    }
}
