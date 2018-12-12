using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            double x1 = double.Parse(x);
            string y = Console.ReadLine();
            double y1 = Math.Sqrt(double.Parse(y));
            if (x1+y1 < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            double res = -5 * Math.Sqrt(x1 + y1);
            Console.WriteLine("{0:F4}", res);
            /////??????????????????????????
        }
    }
}
