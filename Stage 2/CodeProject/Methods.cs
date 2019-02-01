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
        public static void task1860(string x) // 1
        {
            Console.WriteLine("Мы стремимся к " + x);
        }
        public static void task4140(string l, string f) //2
        {
            Console.WriteLine("Меня зовут " + l + "," + f + " " + l);
        }
        public static void task2632(int cx ,int cy ,int r ,string fill)//3
        {
            Console.WriteLine(@"<circle cx=""{0}"" cy=""{1}"" r=""{2}"" fill=""{3}""/>",cx,cy,r,fill);
        }
        public static void task7474(int a , int b, int c) //4
        {

            Console.WriteLine(" Квадратное уравнение "+a+"* x*x + "+b+"* x + "+c+" = 0.");
            Console.WriteLine(@"Его дискриминант вычисляется по формуле: d = "+b+" *"+b+" - 4 *"+a+" *"+c+"");
        }
        public static double task4411(double x) // 5
        {
            double result;
            result = x + 7;
            return result;
        }
        public static double task2790(double x) // 6
        {
            double cR;
            double res;
            cR = x * Math.PI / 180;
            res = Math.Sqrt(1 - Math.Pow(Math.Sin(cR), 2));
            return res;
        }
        public static string Task5662(int a, int b, int c)
        {
            string d = "";
            double D;
            D = Math.Pow(b, 2)-4*a*c;
            if (a == 0) { d="Данное уравнение не является квадратным"; }
            else if (D == 0) { d="Уравнение " + a + "x ^ 2 + " + b + "x + " + c + " = 0 имеет один корень "; }
            else if (D > 0) {d = "У уравнения" + a + "x ^ 2 + " + b + "x + " + c + " = 0 два вещественных корня"; }
            else if (D < 0) { d="Вещественных корней уравнения" + a + "x ^ 2 + " + b + "x + " + c +"= 0 нет"; }
            return d;
        }
        public static double task3946(int[] arr) //10
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
        public static void task9774(int x,int[] arr) // 13
        {
            int i = 0;
            while(i<arr.Length)
            {
                arr[i] = arr[i] * x;
                i++;
            }
        }
        public static bool task4847(int x, int y , int c) // 15
        {
            bool res = x == y || x == c || y == c;
            return res;
        }

    }
}
