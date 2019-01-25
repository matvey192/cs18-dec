using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string ch = "task4488/test" + s + ".txt"; // относительный 
            if (!File.Exists(ch)) // истино если существует
            {
                Console.WriteLine("File not found " + Path.GetFullPath(ch));
                return;
            } // File not foundC:\Users\adm\Desktop\cs18-dec\Лабораторная 9\Задание 1\bin\Debug\task6175\test13.txt
            // АБсолютный путь 
            StreamReader sr = new StreamReader(ch); // указываем на файл 
            if (sr.EndOfStream) { Console.WriteLine("Файл пуст"); sr.Close(); return;  }
            String line = sr.ReadLine();
            Console.Write(line);
            int count = 0;
            while(!sr.EndOfStream)
            {
                String сс = sr.ReadLine();
                count++;
            }
            Console.WriteLine(" "+count);
            sr.Close();
        }
    }
}
