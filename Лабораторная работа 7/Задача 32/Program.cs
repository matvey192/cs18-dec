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
            int c = 0;
            string k = Console.ReadLine();
            string[] cha = k.Split(' ');
            string b = Console.ReadLine();
            string[] nums = b.Split(' ');
            int[] chs = new int[nums.Length];
            while (c < nums.Length)
            {
                chs[c] = int.Parse(nums[c]);
                c++;
            }
            c = 0;
            while(c<cha.Length)
            {
                Console.Write(cha[c]);
                c++;
            }

        }

    }
}
