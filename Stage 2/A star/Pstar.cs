using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_star
{
   public class Pstar
    {
        public int x;
        public int y;
        public void set(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static double Ldis(int xa, int ya, int xb, int yb)
        {
            return Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));
        }
    }
}
