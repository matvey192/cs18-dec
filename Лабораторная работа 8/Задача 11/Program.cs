using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch = Console.ReadLine();
            ch = ch.Replace("\"", "");
            ch = ch.Replace(" ", "");
            Console.WriteLine(ch);
        }
    }
}
