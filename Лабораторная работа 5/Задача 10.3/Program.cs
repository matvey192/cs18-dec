using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = Console.ReadLine();
            int a = int.Parse(a1);
            string a2 = Console.ReadLine();
            int b = int.Parse(a2);
            int x = a;
            int x1 = b 
            if (a<b)
            {
                Console.WriteLine(b + " " + a);
                b--;
                a++;
            }
            else
                Console.WriteLine(b+" " +a);
            b++;
            a--;
        }
    }
}
