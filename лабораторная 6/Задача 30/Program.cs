using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());//6
            if (x <= 0) { Console.WriteLine("Значение X должно быть положительным");return; }
            int a = 1;
            int res = 0;
            while (x >= a)
            {
                res = x % a;
                if (res == 0) { Console.Write(a+" "); }
                a++;
            }
        }
    }
}
