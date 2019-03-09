using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab13Task1439
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            string x = Console.ReadLine();
            string[] cw = x.Split(' ');
            int[] res1 = new int[cw.Length];
            double res = 0;
            int k = 0;
            int i = 0;
            while (i < cw.Length)
            {
                try
                {
                    {
                        res1[i] = int.Parse(cw[i]);
                        res = res1[i] + res;
                        k++;
                    }
                }
                catch (FormatException )
                {
                    Console.WriteLine("Элемент № " + i + "со значением " + cw[i] + "не число");
                }
                i++;
            }
            if (k == 0) { Console.WriteLine("В исходном массиве отсутствовали числа"); }
            else
            {
                Console.WriteLine("{0:F2}", res = res / k);
            }
        }
    }
}
