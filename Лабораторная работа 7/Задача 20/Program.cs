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
            string b = Console.ReadLine();
            string[] bill = b.Split(' '); // text
            string num = Console.ReadLine();
            string[] nums = num.Split(' '); // numbers 
            int i = 0;
            int ic = 0;
            int[] numss = new int[nums.Length]; // to int
            while (i < nums.Length)
            {
                numss[i] = int.Parse(nums[i]);
                ic = numss[i]; // number go to ic   0;2;3
                if (ic < bill.Length) { Console.WriteLine(bill[ic]); }
                else { Console.WriteLine("Фрагмент на индексе " +nums[i]+ " отсутствует"); }
                ic = 0;
                i++;
            }
        }
    }
}
