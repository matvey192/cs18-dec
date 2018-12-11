using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string edge = Console.ReadLine();
            double e = double.Parse(edge);
            if (e <= 0)
            {
                Console.WriteLine("Длина основания треугольника должна быть положительна");
                return;
            }
            string H = Console.ReadLine();
            double h = double.Parse(H);
            if (h <= 0)
            {
                Console.WriteLine("Высота треугольника должна быть положительна");
                return;
            }
            double res = e * h / 2;
            Console.WriteLine("{0:F2}",res);
        }
    }
}
