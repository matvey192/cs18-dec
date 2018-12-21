using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string b1 = Console.ReadLine();
            double b = double.Parse(b1);
            if (b <= 0) { Console.WriteLine("Значение N должно быть положительным");return; }
            double x = 2;
            double res = 1;
            while (x <= b)
            {
                res =res + 1 / x;
                x++;
            }
            Console.WriteLine("{0:F4}",res);
        }
    }
}
