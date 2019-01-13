using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int res = 0;
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
            Console.WriteLine("Ход решения :");
            Console.WriteLine("Начинаю с "+res);
            while (i < bill.Length-1)
            {
                Console.WriteLine("сравниваю "+res+" и "+ chs[i+1] );
                if (res > chs[i+1]) { Console.WriteLine("Заменяю");res = chs[i+1]; }
                i++;
            }
            i = 0;
            Console.Write("в массиве {"); while (i < bill.Length) { Console.Write(chs[i] + " ");i++; }
            Console.WriteLine("}минимальный элемент это "+res);
        }
    }
}
