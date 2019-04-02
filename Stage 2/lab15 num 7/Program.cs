using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab15_num_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string s=null;
            HashSet<string> set = new HashSet<string>();
            while (s != " ")
            {
                s = Console.ReadLine();
                set.Add(s);
            }
            string str = String.Join(", ", set);
            Console.WriteLine(str); //q w e r q w    qw qw er er ty ty
        }
    }
}
