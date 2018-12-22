using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            do
            {
                a = int.Parse(Console.ReadLine());
                if (a<=83) { c++; }
                if (a >= 199) { b++; }
            } while (!(a>=83&&a<=199));
            Console.WriteLine("Количество слева: "+ c+", количество справа:"+b);
        }
    }
}
