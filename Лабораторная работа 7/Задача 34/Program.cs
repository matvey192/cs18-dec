using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_34
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int c = 0;
            string b = Console.ReadLine();
            string[] nums = b.Split(' ');
            int[] num = new int[nums.Length];
            while (c < nums.Length)
            {
                num[c] = int.Parse(nums[c]);
                c++;
            }
            c = 0;
            int[] num1 = new int[nums.Length];
            while (c < nums.Length)
            {
                while (i < nums.Length)
                {
                    if (num[c] == num[i]) { num1[c] += 1; }
                    i++;
                }
                i = 0;
                c++;
            }
            c = 0;
            while (c < num.Length)
            {
                Console.Write(num1[c]);
                c++;
            }
        }
    }
}
