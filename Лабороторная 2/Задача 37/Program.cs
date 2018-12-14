using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_37
{
    class Program
    {
        static void Main(string[] args)
        {
            string x4 = Console.ReadLine();
            double h = double.Parse(x4);
            double R = 6350;
            if (h < 0) { Console.WriteLine("Высота над уровнем Земли должна быть неотрицательна");return; }
            double res = Math.Sqrt(h * (2 * R + h));
            Console.WriteLine("{0:F4}",res);
        }
    }
}
