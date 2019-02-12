using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProject
{
    public class Point
    {
        public double x;
        public double y;
        public static double distanceBetween(int xa, int ya, int xb, int yb)
        {
            return Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));
        }
        public static double distanceBetween1(Point a,Point b)
        {
            return Math.Sqrt(Math.Pow((b.x-a.x), 2) + Math.Pow((b.y-a.y), 2));
        }
    }
}
