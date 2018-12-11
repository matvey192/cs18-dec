using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = Console.ReadLine();
            int a11 = int.Parse(a1);
            string a2 = Console.ReadLine();
            int a22 = int.Parse(a2);
            string a3 = Console.ReadLine();
            int a33 = int.Parse(a3);
            int res = a11 * a22 + a11 * a33 + a22 * a33;
            Console.WriteLine(res);
        }
    }
}
