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
            string x = Console.ReadLine();
            double x1 = double.Parse(x);
            if (x1 < 0)
            {
                Console.WriteLine("Значение X должно быть неотрицательным");
                return;
            }
            double res = Math.Sqrt(x1);
            Console.WriteLine("{0:F4}",res);
        }
    }
}
