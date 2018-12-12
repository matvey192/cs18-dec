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
            string x = Console.ReadLine();
            int x1 = int.Parse(x);
            int ch = x1 / 3600;
            int min = x1 % 3600 / 60;
            int sec = x1 % 3600 % 60;
            Console.WriteLine("Часов "+ch+"Минут "+min+"Секунд"+sec);
        }
    }
}
