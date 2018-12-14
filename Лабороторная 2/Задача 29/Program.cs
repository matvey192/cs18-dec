using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_29
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            double mass = double.Parse(x);
            if (mass<=0)
            {
                Console.WriteLine("Масса должна быть положительной");
                return;
            }
            string x1 = Console.ReadLine();
            double aDeg = double.Parse(x1);
            double aRad = aDeg * Math.PI / 180;
            double force = mass * 9.8067 * Math.Cos(aRad);
            Console.WriteLine("{0:F6}",force);
        }
    }
}
