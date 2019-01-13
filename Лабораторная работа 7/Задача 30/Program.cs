using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            string[] bill = b.Split(' ');
            int[] chs = new int[bill.Length];
            while (i < bill.Length)
            {
                chs[i] = int.Parse(bill[i]);
                i++;
            }
            i = 0;
            while (i < bill.Length)
            {
                if (chs[i] == X) { chs[i] = Y; }
                Console.Write(chs[i]+" ");
                i++;
            }
        }
    }
}
