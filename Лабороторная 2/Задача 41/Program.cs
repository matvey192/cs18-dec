using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_41
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1 = Console.ReadLine();
            double yarnDiameterCm = double.Parse(x1);
            if (yarnDiameterCm <= 0) { Console.WriteLine("Длина проволоки должна быть неотрицательна");return; }
            string x12 = Console.ReadLine();
            double wireCoils = double.Parse(x12);
            if (wireCoils <= 0) { Console.WriteLine("Количество витков должно быть неотрицательно"); return; }
            double res = yarnDiameterCm * wireCoils * Math.PI;
            Console.WriteLine(Math.Floor(res));
        }
    }
}
