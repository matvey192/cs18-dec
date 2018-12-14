using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_27
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1 = Console.ReadLine();
            double mass = double.Parse(x1);
            if (mass <= 0)
            {
                Console.WriteLine("Значение mass должно быть положительным");
                return;
            }
            string x = Console.ReadLine();
            double velocity = double.Parse(x);
            if (velocity <= 0)
            {
                Console.WriteLine("Значение velocity должно быть положительным");
                return;
            }
            string y = Console.ReadLine();
            double height = double.Parse(y);
            if (height <= 0)
            {
                Console.WriteLine("Значение height должно быть неотрицательным");
                return;
            }
            double Kin = mass * Math.Pow(velocity, 2) / 2;
            double Pot = mass * 9.8067 * height;
            Console.WriteLine("Кинетическая энергия составляет: {0:F4}", Kin);
            Console.WriteLine("Потенциальная энергия составляет: {0:F4}",Pot);
        }
    }
}
