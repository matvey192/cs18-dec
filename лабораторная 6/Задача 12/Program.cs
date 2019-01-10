using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = Console.ReadLine();
            int a = int.Parse(a1);
            if (a < -100 || a > 500) { Console.WriteLine("Значение A должно быть в интервале [-100, 500]"); return; }
            int sum=0;
            while (a<=500)
            {
                
                sum+=a;
                a++;
                Console.WriteLine(sum);
            }
            }
        }
    }

