using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_22
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double aInitial = double.Parse(a);
            double aRemainder = aInitial % 360;
            Console.WriteLine(aRemainder);
        }
    }
}
