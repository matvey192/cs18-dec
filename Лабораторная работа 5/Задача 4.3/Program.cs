using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = Console.ReadLine();
            int a = int.Parse(a1);
            string a2 = Console.ReadLine();
            int b = int.Parse(a2);
            if (a > b) { Console.WriteLine("Значение A должно быть не больше значения B"); return; }
            while (b >= a)
            {
                Console.Write(b+" ");
                b--;
            }

        }
    }
}
