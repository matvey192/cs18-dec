using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            string[] bill = b.Split(' ');
            int i = 0;
            while (i<bill.Length)
            {
                int[] chs = new int[bill.Length];
                chs[i] = int.Parse(bill[i])*m;
                Console.Write(chs[i]+" ");
                i++;
            }
        }
    }
}
