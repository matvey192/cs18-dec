using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = "";
            int line=0;
            int b = 0;
            int k = 0;
            string x = Console.ReadLine();
            string ch = "task6882/test"+x+".txt";
            if(!File.Exists(ch))
            {
                Console.WriteLine("Файл не существует");
            }
            StreamReader sr = new StreamReader(ch);
            if (sr.EndOfStream) { Console.WriteLine("Файл пуст"); sr.Close(); }
            try
            {
                k++;
                line1 = sr.ReadLine();
                line = int.Parse(line1);
                b = line;
                while (!sr.EndOfStream)
                {
                    k++;
                    line1 = sr.ReadLine();
                    line = int.Parse(line1);
                    if (b > line) { b = line; }
                }
                Console.WriteLine("Минимальное число: " + b);
                Console.WriteLine("Всего чисел " + k);
            }
            catch (FormatException)
            {
                Console.WriteLine("Не удалось преобразовать строку в число в строке " + k);
                Console.WriteLine(line1);
            }
            sr.Close();
        }
    }
}
