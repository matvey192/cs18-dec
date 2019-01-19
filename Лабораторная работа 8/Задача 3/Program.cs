using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            string str = "abcdefwxyz";
            string CA = Console.ReadLine();
            if (!(str.Contains(CA)))
            {
                Console.WriteLine("Значение CA отсутствует в строке"); return;
            }
            string CB = Console.ReadLine();
            if (!(str.Contains(CB)))
            {
                Console.WriteLine("Значение CB отсутствует в строке"); return;
            }
            if (str.IndexOf(CB) > str.IndexOf(CA))
            {
                 res = str.IndexOf(CB)-1 - str.IndexOf(CA);
            }
            else
            {
                res = str.IndexOf(CA)-1 - str.IndexOf(CB);
            }
            Console.WriteLine(res);
        }
    }
}
