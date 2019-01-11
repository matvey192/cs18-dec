using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_33
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine()); 
            int b = 0; 
            if (0 >= s || s >= 20) { Console.WriteLine("Значение W должно быть в интервале [0, 20]"); return; }
            for (int i = 0; i <= s; i++) 
            {
                if (i == s) { b++; Console.WriteLine(); i = 0; }
                Console.Write(b); 
                if (b == 10) { break; }
            }
        }
    }
}
