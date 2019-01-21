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
            int i = 0;
            string str = "abcdefwxyz";
            int CA = int.Parse(Console.ReadLine());
            if (CA > str.Length||CA<0)
            { Console.WriteLine("Значение CA должно быть в интервале[0, длина строки)");return; }
            int CB = int.Parse(Console.ReadLine());
            if  (CB > str.Length || CB < 0)
            { Console.WriteLine("Значение CB должно быть в интервале[0, длина строки)"); return; }
            if(CA > CB)
            {
                i = CA - CB + 1 ;
                str = str.Substring(CB, i);
            }
            else
            {
                i = CB - CA + 1;
                str = str.Substring(CA, i);
            }
            Console.WriteLine(str);
        }
    }
}
