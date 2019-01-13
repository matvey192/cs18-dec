using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int res = 0;
            int num = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            string[] bill = b.Split(' ');
            if (num < 0 || num > bill.Length) { Console.WriteLine("Число B должно быть в интервале [0, размер массива)");return; }
            int[] chs = new int[bill.Length];
            while (i < bill.Length)
            {
                chs[i] = int.Parse(bill[i]);
                i++;
            }
            i = 0;
            while (i < bill.Length)
            {
                if (chs[num] > chs[i]) { res =res+1; }
                i++;
            }
            Console.WriteLine(res);
        }
    }
}
