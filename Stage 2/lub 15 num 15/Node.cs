using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lub_15_num_15
{
   public class Node
    {
       public int x;
       public int y;
       public string c;
       public void Set1(int x, int y, string c)
       {
           this.x = x;
           this.y = y;
           this.c = c;
       }
       public override bool Equals(object other)
       {
           if (other == null) return false;
           if (GetType() != other.GetType()) return false;
           if (this == other) return true;
           Node point = (Node)other;
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
