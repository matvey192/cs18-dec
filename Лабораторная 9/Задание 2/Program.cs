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
            if (!File.Exists(ch)) // истино если  существует
            {
                Console.WriteLine("File not found " + Path.GetFullPath(ch));
                return;
            } // File not foundC:\Users\adm\Desktop\cs18-dec\Лабораторная 9\Задание 1\bin\Debug\task6175\test13.txt
            // АБсолютный путь 
            StreamReader sr = new StreamReader(ch); // указываем на файл 
            String line = sr.ReadLine();
            FileInfo file = new FileInfo("task4488/test" + s + ".txt");
            long size = file.Length ;
            Console.Write(line+" "+size);
        }
    }
}
