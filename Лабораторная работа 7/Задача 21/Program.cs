using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_21
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            string[] bill = b.Split(' '); // text
            if (b == "") { Console.WriteLine("Отсутствуют данные о символах");return; }
            string num = Console.ReadLine();
            string[] nums = num.Split(' '); // numbers 
            if (num == "") { Console.WriteLine("Отсутствуют данные о символах"); return; }
            if (bill.Length > nums.Length || bill.Length < nums.Length) { Console.WriteLine("Длины массивов не совпадают");return; }
            int i = 0;
            int ic = 0;
            while (i < bill.Length)
            {

                int[] numss = new int[nums.Length]; // to int
                numss[i] = int.Parse(nums[i]);
                ic = numss[i]; // number go to ic   0;2;3
                for (int cc = 0; cc < ic; cc++)
                {
                    Console.Write(bill[i]);
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}