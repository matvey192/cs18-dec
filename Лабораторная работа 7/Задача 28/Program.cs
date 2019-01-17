using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_28
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            int i = 0;
            string b = Console.ReadLine();
            string[] bill = b.Split(' ');
            int[] chs = new int[bill.Length];
            while (i < bill.Length)
            {
                chs[i] = int.Parse(bill[i]);
                i++;
            }
            i = 0;
            res = chs[i];
            while (i < bill.Length-1)
            {
                if (res > chs[i + 1]) {res = chs[i + 1]; }
                i++;
            }
            i = 0;
            while (i < bill.Length)
            {
                chs[i] = chs[i] - res;
                Console.Write(chs[i]+" ");
                i++;
            }
        }
    }
}
