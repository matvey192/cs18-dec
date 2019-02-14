using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProject
{
   public class Range
    {
       public static bool HasIntersection(int la , int lb , int ra , int rb)
        {
            int a = la;
            int b = ra;
            if (la < ra)
            {
                while (a < lb)
                {
                    if (a == ra || a == rb) { return true; }
                    a++;
                }
            }
            else if (ra < la)
            {
                while (b < rb)
                {
                    if (b == la || b == lb) { return true; }
                    b++;
                }
            }
            else if (la > lb || ra > rb)
            {
                Console.WriteLine("Значение A должно быть меньше значения B");
                return false; 
            }
             return false; 
        }
    }
}
