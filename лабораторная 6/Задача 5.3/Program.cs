using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = Console.ReadLine();
            int a = int.Parse(a1);
            string a2 = Console.ReadLine();
            char b = char.Parse(a2);
            int i = 0;
            Console.Write("\"");
            while (i <= a)   
            {
                Console.Write(b);
                i++;
            }
            Console.Write("\"");
        }
    }
}
