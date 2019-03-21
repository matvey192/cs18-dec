using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CodeProject
{
    public class PointComparator
    {
        public int x;
        public int y;
        public int x1;
        public int y1;
        public double ComparatorP(Point a ,int x1, int y1 /*A2*/)
        {
            
            double l = 0;
            l = Math.Sqrt(Math.Pow(x1 - a.x, 2)+ Math.Pow(y1 - a.y, 2));
            return l;
        }
    }
}
