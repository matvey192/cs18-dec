using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_36
{
    class Program
    {
        static void Main(string[] args)
        {
            string x4 = Console.ReadLine();
            double x = double.Parse(x4);
                if (x - 5 < 0) { Console.WriteLine("Подкоренное выражение должно быть неотрицательным");return; }
                if (x + 5 < 0) { Console.WriteLine("Подкоренное выражение должно быть неотрицательным");return; }
                if (x <= 0) { Console.WriteLine("Подкоренное выражение должно быть неотрицательным");return; }
            double res =( Math.Sqrt(x + 5) + Math.Sqrt(x - 5)) / (2 * Math.Sqrt(x));
            Console.WriteLine("{0:F6}",res);
        }
    }
}
