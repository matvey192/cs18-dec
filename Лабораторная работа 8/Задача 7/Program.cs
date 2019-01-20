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
            while (i<2)
            {
                Console.Write(t[i]);
                i++;
            }
            i += 1;
            Console.WriteLine();
            Console.Write("Код изготовителя: ");
            while (i < 6)
            {
                Console.Write(t[i]);
                i++;
            }
            Console.WriteLine();
            Console.Write("Код товара: ");
            i += 1;
            while (i < 11)
            {
                Console.Write(t[i]);
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Контрольное число: "+t[12]);
        }
    }
}
