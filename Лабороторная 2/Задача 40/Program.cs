using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_40
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1 = Console.ReadLine();
            double volume1 = double.Parse(x1);
            if (volume1 <= 0) { Console.WriteLine("Объем должен быть неотрицательным");return; }
            string x12 = Console.ReadLine();
            double temperature1 = double.Parse(x12);
            string x123 = Console.ReadLine();
            double volume2 = double.Parse(x123);
            if (volume2 <= 0) { Console.WriteLine("Объем должен быть неотрицательным"); return; }
            string x = Console.ReadLine();
            double temperature2 = double.Parse(x);
            double volume = volume1 + volume2;
            double temperature = (temperature1 * volume1 + temperature2 * volume2)/( volume1 + volume2);
            Console.WriteLine("volume= "+volume+ "temperature= {0:F4}", temperature);
        }
    }
}
