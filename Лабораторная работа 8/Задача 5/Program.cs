using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdefwxyz";
            int CA = int.Parse(Console.ReadLine());
            if (CA > str.Length) { Console.WriteLine("Значение CA должно быть в интервале[0, длина строки)");return; }
            int i = CA;
            int CB = int.Parse(Console.ReadLine());
            if (CB > str.Length) { Console.WriteLine("Значение CB должно быть в интервале[0, длина строки)"); return; }
            int i1 = CB;
            while (i <= CB)
            {
                char x = str[i];
                Console.Write(x);
                i++;
            }
            if (i == CB+1) { return; }
            while (CA >= i1)
            {
                char x = str[i1];
                Console.Write(x);
                i1++;
            }
            if (i1 == CA+1) { return; }
        }
    }
}
