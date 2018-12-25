using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_40
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine()); // 5
            int B = int.Parse(Console.ReadLine()); // 6
            int a = A;
            int b = B;
            int res = 0;
            if(A<B)
            {
                while (a != B)
                {
                    res = a % 2;
                    a++;
                    if (res == 0)
                    {
                        Console.Write(a+",");
                        if (a == B) { Console.Write(a); }
                    }
                }
            }
            if (A > B) // убывание
            {
                while (a != B)
                {
                    res = a % 2;
                    a--;
                    if (res == 0)
                    {
                        Console.Write(a);
                        if (a != B) { Console.Write(","); }
                    }
                }
            }
        }
    }
}
