using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            if (s < 0) { Console.WriteLine("Значение N должно быть неотрицательным"); return; }
            int a = 30;
            int b = 40;
            while (a <= b)
            {
                if (s == a) { Console.WriteLine(a + "+"); }
                Console.WriteLine(a + "-");
                a++;
            }
        }
    }
}
