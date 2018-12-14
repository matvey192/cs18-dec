using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_28
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            double r1 = double.Parse(x);
            if (r1 == 0)
            {
                Console.WriteLine("Значение r2 должно быть не равно нулю");
                return;
            }
            string x1 = Console.ReadLine();
            double r2 = double.Parse(x1);
            if (r2 == 0)
            {
                Console.WriteLine("Значение r2 должно быть не равно нулю");
                return;
            }
            double res = 1 / r1 + 1 / r2;
            Console.WriteLine("{0:F4}",res);
        }
    }
}
