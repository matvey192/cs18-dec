using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int p = int.Parse(Console.ReadLine()); //1
            int q = int.Parse(Console.ReadLine());//3
            string b = Console.ReadLine();
            string[] bill = b.Split(' ');
            if (q < 0 || q > bill.Length) { Console.WriteLine("Число Q должно быть в интервале [0, размер массива) ");return; }
            if (p < 0 || p > bill.Length) { Console.WriteLine("Число P должно быть в интервале [0, размер массива) ");return; }
            int[] chs = new int[bill.Length];
            while (i < bill.Length)
            {
                chs[i] = int.Parse(bill[i]);
                i++;
            }
            int res = chs[p];
            i = p; //1
            Console.Write("Фрагмент массива: ");
            while (i >= p && i <= q)
            {
                Console.Write(chs[i]+" ");
                if (i == q) { goto vrr; }
                if (res > chs[i+1]) { res = chs[i+1]; }
                i++;
            }
            vrr:
            Console.WriteLine();
            Console.WriteLine("Минимальное среди них: "+res);
        }
    }
}
