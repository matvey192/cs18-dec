using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_34
{
    class Program
    {
        static void Main(string[] args)
        {
            string x2 = Console.ReadLine();
            double aDeg = double.Parse(x2);
            double aRad = aDeg * Math.PI / 180;
            double res = Math.Sqrt(1 - Math.Pow(Math.Sin(aRad), 2) );
            Console.WriteLine("{0:F4}",res);
        }
    }
}
