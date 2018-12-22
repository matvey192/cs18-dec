using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            if (s < 0 || s>15) { Console.WriteLine("Значение N должно быть неотрицательным"); return; }
            int a = 0;
            for (int i = 0; i < 15; i++)
            {
                if (i >= s)
                {
                    Console.Write(".");
                    a++;
                }
                else { Console.Write("#"); }
            }
        }
    }
}
