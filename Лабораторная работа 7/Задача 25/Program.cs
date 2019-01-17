using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 0;
            string b = Console.ReadLine();
            string[] bill = b.Split();
            int i = bill.Length - 1;
            while (i > 0)
            {
                while (i1 < bill.Length)
                {
                    if (i1 != i && bill[i] == bill[i1])
                    {
                        Console.WriteLine("Повторения есть");
                        return;
                    }
                    i1++;
                }
                i1 = 0;
                i--;
            }
            Console.WriteLine("Повторений нет");
        }
    }
}
