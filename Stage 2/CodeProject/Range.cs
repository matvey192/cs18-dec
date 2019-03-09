using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProject
{
    public class Range
    {
        public int from;
        public int to;
        public static bool HasIntersection(Range a, Range b)
        {
            int i = 0;
            int kx;
            int min;
            if (a.from>a.to||b.from>b.to)
            {
                throw new ArgumentException("Подкоренное выражение должно быть неотрицательно");
            }
            if (a.from < b.from)
            {
                min = a.to - a.from;
                kx = a.from;
                while (i <= min)
                {
                    if (kx == b.from) { return true; }
                    kx++;
                    i++;
                }
            }
            else if (b.from < a.from)
            {
                min = b.to - b.from;
                kx = b.from;
                while (i <= min)
                {
                    if (kx == a.from) { return true; }
                    kx++;
                    i++;
                }
            }
            return false;
        }
    }
}
