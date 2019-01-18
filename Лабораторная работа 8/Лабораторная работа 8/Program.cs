using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdefwxyz";
            string b = Console.ReadLine();
            if (str.Contains(b))
            {
                Console.WriteLine("Содержится");
            }
            else { Console.WriteLine("Не содержится"); }
        }
    }
}
