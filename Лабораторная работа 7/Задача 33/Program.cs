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
            int res = 0;
            int c = 0;
            int K = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            string[] nums = b.Split(' ');
            int[] num = new int[nums.Length];
            while (c < nums.Length)
            {
                num[c] = int.Parse(nums[c]);
                c++;
            }
            c = 0;
            while(c<num.Length)
            {
                if (num[c] == K) { res++; }
                c++;
            }
            Console.WriteLine(res);
        }
    }
}
