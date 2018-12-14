using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_24
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1 = Console.ReadLine();
            double x = double.Parse(x1);
            if (x <-273.15)
            {
                Console.WriteLine("Температура должна быть выше абсолютного нуля");
                return;
            }
            double res = x * 1.8 + 32;
            Console.WriteLine("{0:F4}",res);
        }
    }
}
