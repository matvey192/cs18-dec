using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            if (t.Length != 13) { Console.WriteLine("Некорректная длина штрих-кода");return; }
            int i = 0;
            Console.Write("Код страны: ");
            string t1 = t;
            t1 = t.Substring(0, 3);
            Console.Write(t1); Console.WriteLine();
            Console.Write("Код изготовителя: ");
            string t2 = t;
            t2 = t.Substring(3, 3);
            Console.Write(t2); Console.WriteLine();
            Console.Write("Код товара: ");
            string t3 = t;
            t3 = t.Substring(7, 4);
            Console.Write(t3);
            Console.WriteLine();
            Console.WriteLine("Контрольное число: "+t[12]);
        }
    }
}
