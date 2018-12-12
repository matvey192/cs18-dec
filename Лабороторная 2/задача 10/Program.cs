using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string aDeg1 = Console.ReadLine();
            int aDeg = int.Parse(aDeg1);
            string bDeg1 = Console.ReadLine();
            int bDeg = int.Parse(bDeg1);
            double aRad = aDeg * Math.PI / 180;
            double bRad = bDeg * Math.PI / 180;
            double res = Math.Sin(aRad) * Math.Cos(bRad) + Math.Cos(aRad) * Math.Sin(bRad);
            Console.WriteLine("{0:F4}",res);
        }
    }
}
