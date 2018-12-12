using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double b = double.Parse(a);
            if (b <= 0)
            {
                Console.WriteLine("Значение edge должно быть положительным");
                return;
            }
            double res = Math.Pow(b, 3);
            Console.WriteLine(res);
        }
    }
}
