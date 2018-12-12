using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = int.Parse(a);
            int res = 7 * (b*b) - 3 * b + 6;
            Console.WriteLine(res);
        }
    }
}
