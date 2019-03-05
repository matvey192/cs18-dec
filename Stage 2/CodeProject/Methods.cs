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
        public static void task2632(int cx, int cy, int r, string fill)//3
        {
            Console.WriteLine(@"<circle cx=""{0}"" cy=""{1}"" r=""{2}"" fill=""{3}""/>", cx, cy, r, fill);
        }
        public static void task7474(int a, int b, int c) //4
        {

            Console.WriteLine(" Квадратное уравнение " + a + "* x*x + " + b + "* x + " + c + " = 0.");
            Console.WriteLine(@"Его дискриминант вычисляется по формуле: d = " + b + " *" + b + " - 4 *" + a + " *" + c + "");
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
        public static string Task5662(int a, int b, int c) //7
        {
            string d = "";
            double D;
            D = Math.Pow(b, 2) - 4 * a * c;
            string a1 = a.ToString();
            string b1 = b.ToString();
            string c1 = c.ToString();
            if (a == 0) { d = "Данное уравнение не является квадратным"; }
            else if (D == 0) { d = "Уравнение " + a1 + "x ^ 2 + " + b1 + "x + " + c1 + " = 0 имеет один корень"; }
            else if (D > 0) { d = "У уравнения" + a1 + "x ^ 2 + " + b1 + "x + " + c1 + " = 0 два вещественных корня"; }
            else if (D < 0) { d = "Вещественных корней уравнения" + a1 + "x ^ 2 + " + b1 + "x + " + c1 + "= 0 нет"; }
            return d;
        }
        public static long Task3669(int a, int b)//8
        {
            long res1 = 1; ;
            if (a > b)
            {
                while (b <= a)
                {
                    res1 = b * res1;
                    b++;
                }
                return res1;
            }
            else
            {
                while (b >= a)
                {
                    res1 = a * res1;
                    a++;
                }
                return res1;
            }
        }
        public static string Task1292(string a) //9
        {
            int i = 0;
            string res = "";
            string[] str = new string[] { "a", "b", "c", "d", "e", "f", "g", "h" };
            while (i < str.Length)
            {
                res = res + str[i];
                if (str[i] == a) { return res; }
                i++;
            }
            return res;
        }
        public static double task3946(int[] arr) //10
        {
            int i = 0;
            double res = 0;
            if (arr.Length == 0) { return 0; }
            while (i < arr.Length)
            {
                res = arr[i] + res;
                i++;
            }
            res = res / arr.Length;
            return res;
        }
        //11
        public static int task4283(int k, int[] arr)
        {
            int res = 0;
            int i = 0;
            while (i < arr.Length)
            {
                if (k == arr[i]) { res++; }
                i++;
            }
            return res;
        }
        //12
        public static double[] task6497(int[] arr)
        {
            int i = 0;
            double[] res1 = new double[arr.Length];
            double sr = 0;
            while (i < arr.Length)
            {
                sr = arr[i] + sr;
                i++;
            }
            sr = sr / arr.Length;
            i = 0;
            while (i < arr.Length)
            {
                if (arr[i] < sr) { res1[i] = sr - arr[i]; }
                else { res1[i] = arr[i] - sr; }
                i++;
            }
            return res1;
        }
        public static void task9774(int x, int[] arr) // 13
        {
            int i = 0;
            while (i < arr.Length)
            {
                arr[i] = arr[i] * x;
                i++;
            }
        }
        //14 
        public static bool task4847(int x, int y, int c) // 15
        {
            bool res = x == y || x == c || y == c;
            return res;
        }
        // 13/3 
        public static double Task1934(int a, int b)
        {
            if (b > 0)
            {
                throw new ArgumentException("Подкоренное выражение должно быть неотрицательно");
            }
            return a * Math.Sqrt(-7 * b);
        }
        //13/4
        public static double Task3943(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                throw new ArgumentException("Подкоренное выражение должно быть неотрицательно");
            }
            return -5 * Math.Sqrt(x + Math.Sqrt(y));
        }
        //13/5
        public static double  Task9020(int a)
        {
            if(a>=61)
            {
                throw new ArgumentException("Подкоренное выражение должно быть неотрицательно");
            }
            return 3 * Math.Sqrt(61 - a);
        }
        //13/6
        public static double Task5871(int x)
        {
            if(x<5)
            {
                throw new ArgumentException("Подкоренное выражение должно быть неотрицательно");
            }
            return (Math.Sqrt(x - 5) + Math.Sqrt(x + 5)) / 2 * Math.Sqrt(x);
        }
        //13/7
        public static double Task7799(int m, int deg)
        {
            if(m<=0)
            {
                throw new ArgumentException("Масса должна быть положительной");
            }
            return m * 9.8067 * Math.Cos(deg * Math.PI / 180);
        }
        //13/8
        public static double Task9354(int a, int b ,int c)
        {
            if (a == 0)
            {
                throw new ArgumentException(@"Уравнение y="+a+"x^2+"+b+"x+"+c+" не является квадратным");
            }
            return Math.Pow(b, 2) * 4 * a * c;
        }
        //13/9
        public static bool task5170(int a )
        {
            if (a <= 0)
            {
                throw new ArgumentException("Значение Y должно быть положительным");
            }
            if (a == 2) { return true; }
           else if (a % 2 == 0||a%3==0||a%5==0||a%7==0) { return false; }
            else { return true; }
        }
        //14/5
        public static Direction BackwardTask(Point a , Point b)
        {
            double dis;
            double ang = 0;
            double x1 = b.x - a.x;
            double y1 = b.y - a.y;
            double r =Math.Atan(Math.Abs(y1/x1));
            r = r / Math.PI * 180;
            if (x1 >= 0&&y1>0) { ang = r; }
            else if (x1 < 0 && y1 >= 0) { ang = 180-r; }
            else if (x1 <= 0 && y1 < 0) { ang = 180 + r; }
            else if (x1 > 0 && y1 <= 0) { ang = 360-r; }
            dis = Math.Sqrt(Math.Pow((b.x - a.x), 2) + Math.Pow((b.y - a.y), 2));
            Direction Res;
            Res = new Direction();
            Res.angle = ang;
            Res.distance = dis;
            return Res;
        }
        //14.7
        public static LiquidPortion MixLiquids(LiquidPortion a, LiquidPortion b)
        {
            int v = 0;
            double temp = 0;
            v = a.volume + b.volume;
            temp = (a.volume * a.temperature + b.volume * a.temperature) / a.volume + b.volume;
            LiquidPortion Res;
            Res = new LiquidPortion();
            Res.volume = v;
            Res.temperature = temp;
            return Res;
        }
    }
}
