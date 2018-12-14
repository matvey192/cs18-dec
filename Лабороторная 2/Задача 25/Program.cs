using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_25
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1 = Console.ReadLine();
            double sk = double.Parse(x1);
            if (sk < 0)
            {
                Console.WriteLine("Скорость должна быть неотрицательна");
                return;
            }
            string a1 = Console.ReadLine();
            double sk1 = double.Parse(a1);
            if (sk1 < 0)
            {
                Console.WriteLine("Скорость должна быть неотрицательна");
                return;
            }
            string b1 = Console.ReadLine();
            double km = double.Parse(b1);
            if (sk1 < 0)
            {
                Console.WriteLine("Расстояние должно быть неотрицательно");
                return;
            }
            double res = km / (sk + sk1);
            Console.WriteLine("{0:F4}",res);
        }
    }
}
