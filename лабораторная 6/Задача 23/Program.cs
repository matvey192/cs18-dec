using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_23
{
    class Program
    {
        static void Main(string[] args)
        {

            int s = int.Parse(Console.ReadLine());
            if (s < 0) { Console.WriteLine("Значение N должно быть неотрицательным"); return; }
            int a = 0;
            int b = 0;
            while (a < s)
            {
                Console.WriteLine(a+"-"+b);
                a++;
                b++;
                if (b == 5) { b = 0; }
            } 
        }
    }
}
