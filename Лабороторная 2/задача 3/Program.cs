using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double b = double.Parse(a);
            double ad = b + 7; 
            Console.WriteLine("{0:F4}", b);
        }
    }
}
