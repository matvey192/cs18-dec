using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_16
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = 20;
            double b = 40;
            double sum = 0;
            while (20 <= a && a <= 40)
            {

                sum +=Math.Pow(a,3);
                a++;
                Console.WriteLine(sum);
                if (a == 41) { Console.WriteLine("Ответ= " + sum); };
            }
        }
    }
}
