using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string ss = "";
            string[] text;
            string s = Console.ReadLine();
            string ch = "task4642/test" + s + ".txt"; // относительный 
            if (!File.Exists(ch)) // истино если существует
            {
                Console.WriteLine("File not found " + Path.GetFullPath(ch));
                return;
            } // File not foundC:\Users\adm\Desktop\cs18-dec\Лабораторная 9\Задание 1\bin\Debug\task6175\test13.txt
            // АБсолютный путь 
            StreamReader sr = new StreamReader(ch); // указываем на файл 
            while (sr.EndOfStream != true)
            {
                ss += sr.ReadLine();
            }
            text = ss.Split(' ');
            Console.WriteLine("Количество слов:");
            Console.WriteLine(text.Length);
            sr.Close(); /////////// 1 111111 1 1 1 1 11 1 1 1 1 1
        }
    }
}
