using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CodeProject
{
    public class Point
    {
        //1
        public double x;
        public double y;
        public string c;
        public override bool Equals(object other)
        {
            if (other == null) return false;
            if (GetType() != other.GetType()) return false;
            if (this == other) return true;
            Point point = (Point)other;
            if (x == point.x && y == point.y&&c==point.c) return true;
            return false;
        }
        public static double distanceBetween(int xa, int ya, int xb, int yb)
        {
            return Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));
        }
        //2
        public static double distanceBetween1(Point a,Point b)
        {
            return Math.Sqrt(Math.Pow((b.x-a.x), 2) + Math.Pow((b.y-a.y), 2));
        }
        public double distanceTo(int x, int y)
        {
            return Math.Sqrt(Math.Pow((x - this.x), 2) + Math.Pow((y - this.y), 2));
        }
        public double distanceTo1(Point a)
        {
            return Math.Sqrt(Math.Pow((a.x - this.x), 2) + Math.Pow((a.y - this.y), 2));
        }
        public void setCoordinates(int x , int y)
        {
            this.x = x;
            this.y = y;
        }
        public double GetX()
        {
            return this.x;
        }
        public double GetY()
        {
            return this.y;
        }
        public void setColor(string p)
        {
            this.c = p;
        }
        public static bool AreSame(Point a , Point b)
        {
            if (a.x == b.x && a.y == b.y) { return true; }
            else return false;
        }
        public  Point(int a, int b)
        {
            this.x = a;
            this.y = b;
            this.c = "white";
        }
        public override string ToString()
        {
            return "("+this.x+"; "+this.y+"; "+this.c+")";
        }
    }
}
