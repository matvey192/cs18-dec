using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProject
{
    // Класс Comparator8258 наследует абстрактный класс Comparer<int>
    public class Comparator8258 : Comparer<int>
    {
        public
            override // Заменяем метод, реализованный в классе Comparer<int>
            int Compare(int a, int b)
        {
            int res = 0;
            int res1 = 0;
            if (a > 6)
            {
                res = a - 6;
            }
            else if (a < 6)
            {
                res = 6 - a;
            }
            if (b > 6)
            {
                res1 = b - 6;
            }
            else if (b < 6)
            {
                res1 = 6 - b;
            }
            if (res > res1) { return 1; }
            else if (res < res1) { return -1; }
            else if (res == res1) { return 0; }
            return 0;
        }
    }
}
