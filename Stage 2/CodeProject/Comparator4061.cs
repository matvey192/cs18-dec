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
            if (Math.Abs(a) > Math.Abs(b))
            {
                return 1;               // <0 если а меньше б
            }
            else if (Math.Abs(a) < Math.Abs(b))
            {
                return -1;                    //>0 если а больше б 
            }
            else if (Math.Abs(a) == Math.Abs(b)) // если равны 0
            {
                if (a <0&&b>0) {
                    return -1; }
                else if(a > 0 && b < 0) {
                    return 1; }
                return 0;
            }
            else return 1;
        }
    }
}
