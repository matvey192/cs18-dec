using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double b = double.Parse(a);
            double res = 12*(b*b) + 7*b - 16;
            Console.WriteLine("{0:F4}",res);
        }
    }
}
