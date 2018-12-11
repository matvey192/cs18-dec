using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double b = double.Parse(a);
            double c = b * Math.PI / 180;
            double res = Math.Sin(c);     
            Console.WriteLine("{0:F4}",res);
        }
    }
}
