using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_20
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int i = 0;
                int p = 0;
                int a = int.Parse(Console.ReadLine());
                if (a < 83) { i++; };
                if (a > 199) { p++; };
                string s1 = i.ToString();
                string s2 = p.ToString();
            }
            while (a >= 93 && a <= 199);
                ////111111
            
        }
    }
}
