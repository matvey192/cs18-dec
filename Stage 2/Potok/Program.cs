using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Potok
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread pr = new Thread(proces);
            pr.Start();
            int i = 0;
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };
            string[] words = new string[] { " num "," num1 ", " num2 "," num3 "," num4 " };
            while(i<words.Length) // Выполняются одновременно
            {
                Thread.Sleep(1);
                Console.WriteLine(words[i]);
                i++;
            }
        }
        public static void proces()
        {
            int i = 0;
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };
            while(i<nums.Length)
            {
                Thread.Sleep(1);
                Console.WriteLine(nums[i]);
                i++;
            }
        }
    }
}
