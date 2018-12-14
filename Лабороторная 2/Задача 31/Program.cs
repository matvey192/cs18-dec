using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_31
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1 = Console.ReadLine();
            double mass1 = double.Parse(x1);
            if (mass1 <= 0) {
                Console.WriteLine("Масса должна быть неотрицательной");
                return;
            }
            string x2 = Console.ReadLine();
            double mass2 = double.Parse(x2);
            if (mass2 <= 0)
            {
                Console.WriteLine("Масса должна быть неотрицательной");
                return;
            }
            string x3 = Console.ReadLine();
            double distance = double.Parse(x3);
            if (distance <= 0)
            {
                Console.WriteLine("Дистанция должна быть неотрицательной");
                return;
            }
            double force = 9.8067 * (mass1 * mass2) / Math.Pow(distance, 2);
            Console.WriteLine("{0:F4}",force);
        }
    }
}
