using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_22._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sim = Console.ReadLine();
            int x = int.Parse(sim);
            int a = 10;
            while (a<=20)
            if (x == a)
            {
                string slo = x + "+";
                Console.WriteLine(slo);
                    a++;
            }
            else
            {
                Console.WriteLine(a);
                a++;
            }
        }
    }
}
