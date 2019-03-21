using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProject
{
   public class Comparator1457 : Comparer<int>
    {
        public
        override // Заменяем метод, реализованный в классе Comparer<int>
        int Compare(int a, int b)
        {
            if (a > b)
            {
                return 1;
            }
            else if (a < b)
            {
                return -1;
            }
            else return 0;
        }
    }
}
