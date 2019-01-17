using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_32
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int z = 0;
            int c = 0;
            string k = Console.ReadLine();
            string[] cha = k.Split(' '); // if
            string b = Console.ReadLine();
            string[] nums = b.Split(' ');
            int[] chs = new int[nums.Length];
            while (c < nums.Length)
            {
                chs[c] = int.Parse(nums[c]);
                c++;
            }
            c = 0;
            i = chs[c];
            while (c < chs.Length - 1)
            {
                if (i < chs[c + 1]) { i = chs[c + 1]; }
                c++;
            }
            c = 0;
            while (c<cha.Length)
            {
                if (chs[c] <=0) { Console.Write(" "); }
                else { Console.Write(cha[c]); }
                chs[c] = chs[c] - 1;
                c++;
                if (c == nums.Length) { Console.WriteLine();c = 0; z++; }
                if (z == i) { break; }
            }

        }

    }
}
