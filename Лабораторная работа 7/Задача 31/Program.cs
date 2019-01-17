using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int cd = 0;
            int c = 0;
            string b = Console.ReadLine();
            string[] bill = b.Split(' ');
            int[] chs = new int[bill.Length];
            while (c < bill.Length)
            {
                chs[c] = int.Parse(bill[c]);
                c++;
            }
            c = 0;
            for (int i = 0; i < bill.Length; i++)
            {
                for (int j = i + 1; j < bill.Length; j++)
                {
                    if (chs[i] > chs[j])
                    {
                        cd = chs[i];
                        chs[i] = chs[j];
                        chs[j] = cd;
                    }
                }
            }
            while (c < bill.Length)
            {
                Console.Write(chs[c]+" ");
                c++;
            }
        }
    }
}
