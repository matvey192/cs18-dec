using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProject
{
   public class Comparator4061 : Comparer<int>
    {
        public
        override // Заменяем метод, реализованный в классе Comparer<int>
        int Compare(int a, int b)
        {
            int res1 = 0;
            int res2 = 0;
            if (Math.Abs(a) > Math.Abs(b))
            {
                res1 = b;
                res2 = a;
            }
            else if (Math.Abs(a) < Math.Abs(b))
            {
                res1 = b;
                res2 = a;
            }
            else if (Math.Abs(a) == Math.Abs(b))
            {
                if (a > b) { res1 = b; res2 = a; }
                else { res1 = a; res2 = b; }
            }
            else return a;
        }
    }
}
