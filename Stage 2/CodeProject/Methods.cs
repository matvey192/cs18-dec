using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProject
{
    public class Methods
    {
        // В классе Methods реализуйте публичный статический метод task1860.
        // принимает в качестве аргумента 1 строку.
        //В теле метода task1860 напечатайте в консоль решение задачи, используя значение аргумента в качестве исходных данных.
        public static void task1860(string x)
        {
            Console.WriteLine("Мы стремимся к " + x);
        }
        public static void task4140(string l, string f)
        {
            Console.WriteLine("Меня зовут " + l + "," + f + " " + l);
        }
        public static double task4411(double x)
        {
            double result;
            result = x + 7;
            return result;
        }
        public static double task2790(double x)
        {
            double cR;
            double res;
            cR = x * Math.PI / 180;
            res = Math.Sqrt(1 - Math.Pow(Math.Sin(cR), 2));
            return res;
        }
        public static double task3946(int[] arr)
        {
            int i = 0;
            double res = 0;
            if (arr.Length == 0) { return 0; }
            while (i<arr.Length)
            {
                res = arr[i] + res;
                i++;
            }
            res = res / arr.Length;
            return res;
        }
        public static void task9774(int x,int[] arr)
        {
            int i = 0;
            while(i<arr.Length)
            {
                arr[i] = arr[i] * x;
                i++;
            }
        }
        public static bool task4847(int x, int y , int c)
        {
            bool res = x == y || x == c || y == c;
            return res;
        }
    }
}
