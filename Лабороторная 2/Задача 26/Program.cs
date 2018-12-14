using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_26
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1 = Console.ReadLine();
            double initialVelocity = double.Parse(x1);
            if (initialVelocity < 0)
            {
                Console.WriteLine("Начальная скорость должна быть неотрицательна");
                return;
            }
            string x = Console.ReadLine();
            double time = double.Parse(x);
            if (time <= 0)
            {
                Console.WriteLine("Время должно быть положительным");
                return;
            }
            string y = Console.ReadLine();
            double acceleration = double.Parse(y);
            double res = initialVelocity * time + acceleration * Math.Pow(time, 2) / 2;
            Console.WriteLine("{0:F2}",res);
        }
    }
}
