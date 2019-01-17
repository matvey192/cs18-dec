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
            double[] chs = new double[bill.Length];
            while (i < bill.Length)
            {
                chs[i] = double.Parse(bill[i]);
                c = chs[i] + c;
                i++;
            }
            Console.WriteLine(c / bill.Length); // ru.wikipedia.org/wiki/%D0%A1%D1%80%D0%B5%D0%B4%D0%BD%D0%B5%D0%BA%D0%B2%D0%B0%D0%B4%D1%80%D0%B0%D1%82%D0%B8%D1%87%D0%B5%D1%81%D0%BA%D0%BE%D0%B5_%D0%BE%D1%82%D0%BA%D0%BB%D0%BE%D0%BD%D0%B5%D0%BD%D0%B8%D0%B5
        }
    }
}
