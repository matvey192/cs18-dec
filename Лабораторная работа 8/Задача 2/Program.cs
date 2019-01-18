using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch = "abcdefwxyz";
            string b = Console.ReadLine();
            if (!(ch.Contains(b)))
            {
                Console.WriteLine("Значение отсутствует в строке");
                return;
            }
            int c = ch.IndexOf(b)+1;
            Console.WriteLine(c);
            Console.WriteLine(ch.Length);
            int res = ch.Length - c;
            Console.WriteLine(res);
        }
    }
}
