using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_35_5
{
    class Program
    {
        static void Main(string[] args)
        {
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

            int n = num.Length;

            for (int i = 0, m = 0; i != n; i++, n = m)
            {
                for (int j = m = i + 1; j != n; j++)
                {
                    if (num[j] != num[i])
                    {
                        if (m != j) num[m] = num[j];
                        m++;
                    }
                }
            }


            if (n != num.Length)
            {
                int[] x = new int[num.Length];
                for (int i = 0; i < n; i++) x[i] = num[i];

                num = x;
            }
            int bc = 0;
            while (bc < num.Length) { Console.WriteLine(num[bc]); bc++; }
        }
    }
}
