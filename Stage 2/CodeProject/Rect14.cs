using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CodeProject
{
    public class Rect14
    {
        public int x = 100;
        public int y = 100;
        public int w = 100;
        public int h = 100;
        public void ShiftX(string a)
        {
            int a1 = int.Parse(a);
            if (this.x+a1 < 0) { throw new ArgumentException("Error"); }
            this.x = this.x + a1;

        }
        public void ShiftY(string a)
        {
            int a1 = int.Parse(a);
            if (this.y + a1 < 0) { throw new ArgumentException("Error"); }
            this.y = this.y + a1;
        }
        public void stretchX(string a)
        {
            int a1 = int.Parse(a);
            if (this.w + a1 < 0) { throw new ArgumentException("Error"); }
            this.w = this.w + a1;
        }
        public void stretchY(string a)
        {
            int a1 = int.Parse(a);
            if (this.h + a1 <= 0) { throw new ArgumentException("Error"); }
            this.h = this.h + a1;
        }

    }
}
