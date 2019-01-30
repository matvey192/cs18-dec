using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int res1 = 0;
            int s = 0;
            int c = 0;
            int res = 0;
            while (s < 11)
            {
                brr:
                string ch = "task9417/data" + s + ".txt";
                Console.WriteLine("Обработка файла"+ch);
                if (!File.Exists(ch)) // истино если существует
                {
                    Console.WriteLine("Файл не найден ");
                    s++;
                    goto brr;
                }
                StreamReader sr = new StreamReader(ch);
                if (sr.EndOfStream) { Console.WriteLine("Файл пуст"); sr.Close();s++; goto brr;  }
                while (!sr.EndOfStream)
                {
                    try
                    {
                        int line = int.Parse(sr.ReadLine());
                        c = line;
                        res1 = res1 + c;
                        res = res + c;
                    }
                    catch { Console.WriteLine("Данные некорректного формата");s++;goto brr; }
                }
                Console.WriteLine("Сумма в файле = "+res1);
                res1 = 0;
                s++;
                if (s == 10) {  sr.Close(); }
            }
            Console.WriteLine("Общайя сумма = " + res);
        }
    }
}
