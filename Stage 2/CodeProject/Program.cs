using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CodeProject
{
    class Program
    {
        static void Main(string[] args)
        {//2
            Methods.task1860("Знаниям");
            Methods.task1860("Умениям");
            Methods.task1860("Результату");
            Methods.task4140("Бонд", "Джеймс");
            Methods.task4140("Джек Воробой", "Капитан");
            Methods.task4140("Крюков", "Алекснадр");
            //3
            Methods.task2632(50, 50, 40, "yellow");
            Methods.task2632(400, 300, 200, "green");
            Methods.task2632(254, 356, 100, "#cc6600");
            //4
            Methods.task7474(1, 2, 3);
            Methods.task7474(-3, 0, 2);
            //7 
            Console.WriteLine(Methods.Task5662(1, 2, 3));
            Console.WriteLine(Methods.Task5662(11, 13, 19));
            Console.WriteLine(Methods.Task5662(3, 17, 5));
            Console.WriteLine(Methods.Task5662(5, 31, 29));
            Console.WriteLine(Methods.Task5662(3, 6, 3));
            Console.WriteLine(Methods.Task5662(1, 2, 1));
            Console.WriteLine(Methods.Task5662(0, 7, 13));
            //8
            Console.WriteLine(Methods.Task3669(8, 13));
            Console.WriteLine(Methods.Task3669(13, 8));
            Console.WriteLine(Methods.Task3669(159, 161));
            Console.WriteLine(Methods.Task3669(648, 648));
            Console.WriteLine(Methods.Task3669(-2, 600));
            Console.WriteLine(Methods.Task3669(35, 24));
            //9
            Console.WriteLine(Methods.Task1292("a"));
            Console.WriteLine(Methods.Task1292("b"));
            Console.WriteLine(Methods.Task1292("d"));
            Console.WriteLine(Methods.Task1292("h"));
            Console.WriteLine(Methods.Task1292("i"));
            //11
            Console.WriteLine(Methods.task4283(3, new int[] { 1, 2, 3, 4, 1, 2 }));
            Console.WriteLine(Methods.task4283(5, new int[] { 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3 }));
            Console.WriteLine(Methods.task4283(2, new int[] { 3, 2, 2, 2, 2, 2 }));
            Console.WriteLine(Methods.task4283(1, new int[] { 4, 4, 4, 4, 4, 4 }));
            //12
            double[] arr = Methods.task6497(new int[] { 1, 2, 3, 4, 1, 2 });

        double res;
            res = Methods.task4411(11.13);
            Console.WriteLine("{0:F4}", res);
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
            res = Methods.task3946(new int[] { 1, 2, 3, 4, 1, 3, 4, 4, 4, 4 });
            Console.WriteLine(res);
            res = Methods.task3946(new int[] { });
            Console.WriteLine(res);
            //13/9
            Console.WriteLine(Methods.task5170(9));
        }
    }
}
