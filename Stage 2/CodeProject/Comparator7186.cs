using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProject
{
   public class Comparator7186 : Comparer<int>
    {
        public int p;

        public
        override // Заменяем метод, реализованный в классе Comparer<int>
        int Compare(int a, int b)
        {
            int res = 0;
            int res1 = 0;

            if (a > p)
            {
                res = a - p;
            }
            else if (a < p)
            {
                res = p - a;
            }
            if (b > p)
            {
                res1 = b - p;
            }
            else if (b < p)
            {
                res1 = p - b;
            }
            if (res > res1) { return 1; }
            else if (res < res1) { return -1; }
            else if (res == res1) { return 0; }
            return 0;
        }
    }
}
