﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CodeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods.task1860("Знаниям");
            Methods.task1860("Умениям");
            Methods.task1860("Результату");
            Methods.task4140("Бонд", "Джеймс");
            Methods.task4140("Джек Воробой", "Капитан");
            Methods.task4140("Крюков", "Алекснадр");
            double res;
            res = Methods.task4411(11.13);
            Console.WriteLine("{0:F4}",res);
            res = Methods.task4411(-7919);
            Console.WriteLine("{0:F4}", res);
            res = Methods.task4411(0);
            Console.WriteLine("{0:F4}", res);
            res = Methods.task2790(6997);
            Console.WriteLine("{0:F4}", res);
            res = Methods.task2790(31);
            Console.WriteLine("{0:F4}", res);
            res = Methods.task2790(90);
            Console.WriteLine("{0:F4}", res);
            res = Methods.task2790(0);
            Console.WriteLine("{0:F4}", res);
            res = Methods.task2790(180);
            Console.WriteLine("{0:F4}", res);
            res = Methods.task3946(new int[] { 1, 2, 3, 4, 1 });
            Console.WriteLine(res);
            res = Methods.task3946(new int[] { 1 ,2, 3 ,4, 1 ,3, 4 ,4 ,4 ,4 });
            Console.WriteLine(res);
            res = Methods.task3946(new int[] {});
            Console.WriteLine(res);
        }
    }
}
