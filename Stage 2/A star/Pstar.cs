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
        public double g;
        public double h;
        public double f;
        public bool field;
        public Pstar CameFrom;
        public override string ToString()
        {
            return "(" + this.x + "; " + this.y +")";
        }
        public void set(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
       public override bool Equals(object other)
        {
            if (other == null) return false;
            if (GetType() != other.GetType()) return false;
            if (this == other) return true;
            Pstar point = (Pstar)other;
            if (x == point.x && y == point.y) return true;
            return false;
        }
        public override int GetHashCode()
        {
            int c = this.x + 31 * this.y;
            return c;
        }
    }
}
