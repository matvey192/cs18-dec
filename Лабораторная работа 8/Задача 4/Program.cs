using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            string str = "abcabcabbacbacbaaac";
            string b = Console.ReadLine();
            int i = 0;
            res = str.IndexOf(b);
            while (i < str.Length)
            {
                Console.Write(res+" ");
                res = str.IndexOf(b, res+1);
                if (res == -1) { break; }
                i++;
            }
        }
    }
}
