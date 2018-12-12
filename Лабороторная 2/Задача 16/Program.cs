using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double b = double.Parse(a);
            if (b <= 0)
            {
                Console.WriteLine("Значение radius должно быть положительным");

                return;
            }
            double res = 4 * Math.PI * Math.Pow(b,3)/3;
            Console.WriteLine("{0:F4}", res);
        }
    }
}
