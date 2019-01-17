using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            string[] bill = b.Split(' ');
            string b1 = Console.ReadLine();
            string[] bill1 = b1.Split(' ');
            int i = 0;
            int[] chs1 = new int[bill1.Length];
            int[] chs = new int[bill.Length];
            if (bill.Length < bill1.Length || bill.Length > bill1.Length) { Console.WriteLine("Размеры массивов должны быть одинаковы");return; }
            while (i < bill.Length)
            {
                chs[i] = int.Parse(bill[i]);
                chs1[i] = int.Parse(bill1[i]);
                Console.Write(chs[i] * chs1[i] + " ");
                i++;
            }
        }
    }
}
