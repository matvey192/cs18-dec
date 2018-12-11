using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string aDeg1 = Console.ReadLine();
            int aDeg = int.Parse(aDeg1); 
            double aRad = aDeg*Math.PI/180;
            Console.WriteLine("{0:F4}",aRad);
        }
    }
}
