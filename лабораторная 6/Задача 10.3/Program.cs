using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = Console.ReadLine();
            int a = int.Parse(a1);
            string a2 = Console.ReadLine();
            int b = int.Parse(a2);
            int x= a ; //3 
            int x1 = b; //10
            while(x < b) //3 <=10
            {
                Console.WriteLine(x + " " +x1 );
                x++;
                x1--;
            }
            while (x1 <= a) //10<=3
            {
                Console.WriteLine(x + " " + x1);
                x1++;
                x--;
            }
        }
    }
}
