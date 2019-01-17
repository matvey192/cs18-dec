using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            string[] bill = b.Split(' ');
            int i = 0;
            double c = 0;
            while (i < bill.Length)
            {
                double[] chs = new double[bill.Length];
                chs[i] = double.Parse(bill[i]);
                c = chs[i] + c;
                i++;
            }
            Console.WriteLine(c / bill.Length);
        }
    }
}
